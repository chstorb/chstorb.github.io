
namespace BlazorWebAssemblyApp.Services;

public interface IMarkdownService
{
    Task<string> LoadSanitizedMarkdownAsync(string rawUrl);
}