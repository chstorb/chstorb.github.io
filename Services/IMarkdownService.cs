
namespace BlazorWebAssemblyApp.Services;

public interface IMarkdownService
{
    Task<string> GetContentAsync(string rawUrl);
}