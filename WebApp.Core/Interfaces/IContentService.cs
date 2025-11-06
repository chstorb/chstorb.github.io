using WebApp.Core.Models;

namespace WebApp.Core.Interfaces;

public interface IContentService
{
    Task<TenantEntry?> GetTenantIndexAsync(string tenant);
    IEnumerable<TenantEntry> GetTenantNavigation(TenantEntry root);
    Task<IEnumerable<TenantEntry>> GetFooterPoliciesAsync(string tenant);
    IEnumerable<string> GetAllSlugs(TenantEntry root);
}
