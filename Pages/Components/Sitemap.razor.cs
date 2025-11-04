using BlazorWebAssemblyApp.Services;
using BlazorWebAssemblyApp.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Pages.Components;
public partial class Sitemap
{
    [Inject]
    public required IContentService ContentService { get; set; }

    [Parameter]
    public string Tenant { get; set; } = TenantNames.Consulting;

    List<string> AllSlugs = [];

    protected override async Task OnInitializedAsync()
    {
        var root = await ContentService.GetTenantIndexAsync(Tenant);
        if (root is not null)
        {
            AllSlugs = ContentService.GetAllSlugs(root).ToList();
        }
    }
}