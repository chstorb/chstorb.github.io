
namespace BlazorWebAssemblyApp.Services;

public interface IContentService
{
    Task<ContentEntry?> GetTenantRootAsync(string tenant);
    IEnumerable<ContentEntry> GetTenantNavigation(ContentEntry root);
    IEnumerable<ContentEntry> GetFooterLinks(ContentEntry root);
    IEnumerable<string> GetAllSlugs(ContentEntry root);
}
