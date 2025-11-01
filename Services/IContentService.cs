
namespace BlazorWebAssemblyApp.Services;

public interface IContentService
{
    Task<ContentEntry?> GetTenantRootAsync(string tenant);
    IEnumerable<ContentEntry> GetTenantNavigation(ContentEntry root);
    Task<IEnumerable<ContentEntry>> GetFooterPoliciesAsync(string tenant);
    IEnumerable<string> GetAllSlugs(ContentEntry root);
}
