using System.Text.Json;
using WebApp.Core.Configuration.Http;
using WebApp.Core.Interfaces;
using WebApp.Core.Models;

namespace WebApp.Core.Services;

public class ContentService(IHttpClientFactory httpClientFactory) : IContentService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient(HttpClientNames.App);

    // CA1869: Cache JsonSerializerOptions instance for reuse
    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public async Task<TenantEntry?> GetTenantIndexAsync(string tenant)
    {
        var url = $"index.{tenant}.json";
        var json = await _httpClient.GetStringAsync(url);

        var tenantEntry = JsonSerializer.Deserialize<TenantEntry>(json, _jsonOptions);
        return tenantEntry;
    }

    public IEnumerable<TenantEntry> GetTenantNavigation(TenantEntry root)
    {
        return root.Children
            .Where(e => e.Section == "main" && !e.Hidden)
            .OrderBy(e => e.Order);
    }

    public async Task<IEnumerable<TenantEntry>> GetFooterPoliciesAsync(string tenant)
    {
        var root = await GetTenantIndexAsync(tenant);
        var policies = root?.Children?.FirstOrDefault(e => e.Slug == "policies");
        return policies?.Children?.Where(e => e.Section == "footer" && !e.Hidden)
                                  .OrderBy(e => e.Order) ?? Enumerable.Empty<TenantEntry>();
    }

    public IEnumerable<string> GetAllSlugs(TenantEntry root)
    {
        var slugs = new List<string>();

        void Collect(TenantEntry entry)
        {
            if (!string.IsNullOrWhiteSpace(entry.Slug))
                slugs.Add(entry.Slug);

            foreach (var child in entry.Children ?? Enumerable.Empty<TenantEntry>())
                Collect(child);
        }

        Collect(root);
        return slugs;
    }
}
