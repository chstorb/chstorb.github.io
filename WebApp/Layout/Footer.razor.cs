using Microsoft.AspNetCore.Components;
using WebApp.Core.Configuration;
using WebApp.Core.Interfaces;
using WebApp.Core.Models;

namespace WebApp.Layout;
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