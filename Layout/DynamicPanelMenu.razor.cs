using BlazorWebAssemblyApp.Models;
using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Layout;
public partial class DynamicPanelMenu
{
    [Inject]
    public required IContentService ContentService { get; set; }

    [Parameter]
    public required string Tenant { get; set; }

    List<TenantEntry> Navigation = [];

    protected override async Task OnInitializedAsync()
    {
        var root = await ContentService.GetTenantIndexAsync(Tenant);
        if (root is not null)
        {
            Navigation = [.. ContentService.GetTenantNavigation(root)];
        }
    }
}