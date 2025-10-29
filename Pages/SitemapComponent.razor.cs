using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Pages;
public partial class SitemapComponent
{
    [Inject]
    public required IContentService ContentService { get; set; }

    [Parameter] 
    public string Tenant { get; set; }

    List<string> AllSlugs = new();

    protected override async Task OnInitializedAsync()
    {
        var root = await ContentService.GetTenantRootAsync(Tenant);
        if (root is not null)
        {
            AllSlugs = ContentService.GetAllSlugs(root).ToList();
        }
    }
}