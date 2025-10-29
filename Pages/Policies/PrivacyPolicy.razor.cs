using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Pages.Policies;
public partial class PrivacyPolicy
{
    [Inject] 
    public required IMarkdownService MarkdownService { get; set; }

    private string markdownContent = "";
    private bool allowHtml = true;

    protected override async Task OnInitializedAsync()
    {
        var url = "https://raw.githubusercontent.com/chstorb/chstorb/main/content/consulting/policies/privacy-policy.md";
        markdownContent = await MarkdownService.GetContentAsync(url);
    }
}