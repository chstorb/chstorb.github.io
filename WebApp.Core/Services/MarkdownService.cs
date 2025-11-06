using System.Text.RegularExpressions;
using WebApp.Core.Configuration.Http;
using WebApp.Core.Interfaces;

namespace WebApp.Core.Services;

public class MarkdownService(IHttpClientFactory httpClientFactory) : IMarkdownService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient(HttpClientNames.GitHubRaw);

    /// <summary>
    /// Loads markdown content from a public GitHub raw URL and sanitizes it.
    /// </summary>
    public async Task<string> GetContentAsync(string relativePath)
    {
        var raw = await _httpClient.GetStringAsync(relativePath);
        return SanitizeMarkdown(raw);
    }

    /// <summary>
    /// Cleans and prepares raw Markdown content for safe rendering in Razor components,
    /// converting HTML <img> tags to Markdown syntax and preserving empty lines and line breaks.
    /// </summary>
    /// <param name="raw">The raw Markdown string, potentially containing HTML entities, Razor-unsafe symbols, or malformed tags.</param>
    /// <returns>
    /// A sanitized Markdown string with the following adjustments:
    /// - HTML entities decoded
    /// - Razor-unsafe '@' symbols inside Markdown links escaped
    /// - HTML <img> tags converted to Markdown image syntax
    /// - Incomplete Markdown tags removed
    /// - Empty lines preserved
    /// - Markdown line breaks (two trailing spaces) preserved
    /// </returns>
    private static string SanitizeMarkdown(string raw)
    {
        // Decode HTML entities
        var decoded = System.Net.WebUtility.HtmlDecode(raw);

        // Remove HTML comment blocks (including multiline)
        decoded = Regex.Replace(decoded, @"<!--[\s\S]*?-->", "");

        // // Escape @ symbols inside Markdown links to avoid Razor parsing errors
        // decoded = Regex.Replace(decoded, @"\[@([^\]]+)\]\(", "[@@$1](");
        // Escape @ symbols only in Markdown link text to avoid Razor parsing errors
        decoded = Regex.Replace(decoded, @"(?<=\[)@(?=[^\]]+\]\()", "@@");

        // Convert <img> tags to Markdown image syntax
        decoded = Regex.Replace(decoded, @"<img\s+[^>]*src\s*=\s*[""']([^""']+)[""'][^>]*alt\s*=\s*[""']([^""']+)[""'][^>]*>",
            m => $"![{m.Groups[2].Value}]({m.Groups[1].Value})");

        // Split into lines for granular filtering
        var lines = decoded.Split('\n')
            .Select(line =>
            {
                // Preserve empty lines
                if (string.IsNullOrWhiteSpace(line)) return line;

                // Preserve lines with Markdown line breaks (two trailing spaces)
                var trimmed = line.EndsWith("  ") ? line : line.TrimEnd();

                return trimmed;
            })
            // Remove lines that contain only special characters (but not empty lines)
            .Where(line => line == "" || !Regex.IsMatch(line, @"^[\W_]+$"))
            // Remove incomplete Markdown tags (e.g. lone asterisks or brackets)
            .Where(line => !Regex.IsMatch(line, @"^\*{1,2}$|^\[$"))
            .ToList();

        return string.Join("\n", lines);
    }
}

