using BlazorWebAssemblyApp.Models;
using BlazorWebAssemblyApp.Services;
using BlazorWebAssemblyApp.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Layout;
public partial class Footer
{
    [Inject]
    public required IContentService ContentService { get; set; }

    [Parameter]
    public string Tenant { get; set; } = TenantNames.Consulting;

    private IEnumerable<TenantEntry> Policies = [];

    protected override async Task OnInitializedAsync()
    {
        Policies = await ContentService.GetFooterPoliciesAsync(Tenant);
    }
}