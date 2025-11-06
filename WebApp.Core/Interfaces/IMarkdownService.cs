namespace WebApp.Core.Interfaces;

public interface IMarkdownService
{
    Task<string> GetContentAsync(string rawUrl);
}