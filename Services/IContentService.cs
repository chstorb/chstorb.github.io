
namespace BlazorWebAssemblyApp.Services;

public interface IContentService
{
    IEnumerable<string> GetAllSlugs(List<ContentEntry> index, string tenant);
    Task<List<ContentEntry>> GetContentIndexAsync();
    IEnumerable<ContentEntry> GetFooterLinks(List<ContentEntry> index, string tenant);
    IEnumerable<ContentEntry> GetTenantNavigation(List<ContentEntry> index, string tenant);
}