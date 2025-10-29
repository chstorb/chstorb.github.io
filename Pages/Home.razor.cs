using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Pages;

public partial class Home
{
    [Inject]
    public required IMarkdownService MarkdownService { get; set; }

    private bool allowHtml = true;
    private string? markdownContent = "";

    protected override async Task OnInitializedAsync()
    {
        var url = "https://raw.githubusercontent.com/chstorb/chstorb/main/content/consulting/index.md";
        markdownContent = await MarkdownService.GetContentAsync(url);
    }
}