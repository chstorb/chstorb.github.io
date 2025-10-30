using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Layout;
public partial class DynamicNav
{
    [Inject] 
    public required IContentService ContentService { get; set; }

    [Parameter]
    public required string Tenant { get; set; }

    List<ContentEntry> Navigation = [];

    bool sidebarExpanded = true;

    protected override async Task OnInitializedAsync()
    {
        var root = await ContentService.GetTenantRootAsync(Tenant);
        if (root is not null)
        {
            Navigation = [.. ContentService.GetTenantNavigation(root)];
        }
    }
}