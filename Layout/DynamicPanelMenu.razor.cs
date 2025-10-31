using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Layout;
public partial class DynamicPanelMenu
{
    [Inject] 
    public required IContentService ContentService { get; set; }

    [Parameter]
    public required string Tenant { get; set; }

    List<ContentEntry> Navigation = [];

    protected override async Task OnInitializedAsync()
    {
        var root = await ContentService.GetTenantRootAsync(Tenant);
        if (root is not null)
        {
            Navigation = [.. ContentService.GetTenantNavigation(root)];
        }
    }
}