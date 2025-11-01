using System.Text.Json;

namespace BlazorWebAssemblyApp.Services;

public class ContentService : IContentService
{
    private readonly HttpClient _http;

    public ContentService(HttpClient http)
    {
        _http = http;
    }

    public async Task<ContentEntry?> GetTenantRootAsync(string tenant)
    {
        var url = "https://raw.githubusercontent.com/chstorb/chstorb/main/content/index.json";
        var json = await _http.GetStringAsync(url);

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var allRoots = JsonSerializer.Deserialize<List<ContentEntry>>(json, options) ?? new();
        return allRoots.FirstOrDefault(e => e.Tenant == tenant);
    }

    public IEnumerable<ContentEntry> GetTenantNavigation(ContentEntry root)
    {
        return root.Children
            .Where(e => e.Section == "main" && !e.Hidden)
            .OrderBy(e => e.Order);
    }

    public async Task<IEnumerable<ContentEntry>> GetFooterPoliciesAsync(string tenant)
    {
        var root = await GetTenantRootAsync(tenant);
        var policies = root?.Children?.FirstOrDefault(e => e.Slug == "policies");
        return policies?.Children?.Where(e => e.Section == "footer" && !e.Hidden)
                                  .OrderBy(e => e.Order) ?? Enumerable.Empty<ContentEntry>();
    }

    public IEnumerable<string> GetAllSlugs(ContentEntry root)
    {
        var slugs = new List<string>();

        void Collect(ContentEntry entry)
        {
            if (!string.IsNullOrWhiteSpace(entry.Slug))
                slugs.Add(entry.Slug);

            foreach (var child in entry.Children ?? Enumerable.Empty<ContentEntry>())
                Collect(child);
        }

        Collect(root);
        return slugs;
    }
}
