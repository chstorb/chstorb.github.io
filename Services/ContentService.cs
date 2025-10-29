using System.Text.Json;

namespace BlazorWebAssemblyApp.Services;

public class ContentService : IContentService
{
    private readonly HttpClient _http;

    public ContentService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<ContentEntry>> GetContentIndexAsync()
    {
        var json = await _http.GetStringAsync("content/index.json");
        return JsonSerializer.Deserialize<List<ContentEntry>>(json);
    }

    public IEnumerable<ContentEntry> GetTenantNavigation(List<ContentEntry> index, string tenant)
    {
        return index
            .Where(e => e.Tenant == tenant && e.Section == "main" && !e.Hidden)
            .OrderBy(e => e.Order);
    }

    public IEnumerable<ContentEntry> GetFooterLinks(List<ContentEntry> index, string tenant)
    {
        return index
            .SelectMany(e => e.Children ?? new())
            .Where(c => c.Section == "footer" && !c.Hidden && c.Tenant == tenant)
            .OrderBy(c => c.Order);
    }

    public IEnumerable<string> GetAllSlugs(List<ContentEntry> index, string tenant)
    {
        var slugs = new List<string>();
        void Collect(ContentEntry entry)
        {
            if (entry.Tenant == tenant)
            {
                slugs.Add(entry.Slug);
                foreach (var child in entry.Children ?? new()) Collect(child);
            }
        }
        foreach (var entry in index) Collect(entry);
        return slugs;
    }
}
