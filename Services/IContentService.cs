
using BlazorWebAssemblyApp.Models;

namespace BlazorWebAssemblyApp.Services;

public interface IContentService
{
    Task<TenantEntry?> GetTenantIndexAsync(string tenant);
    IEnumerable<TenantEntry> GetTenantNavigation(TenantEntry root);
    Task<IEnumerable<TenantEntry>> GetFooterPoliciesAsync(string tenant);
    IEnumerable<string> GetAllSlugs(TenantEntry root);
}
