using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Shared;
public partial class Footer
{
    [Inject]
    public required IContentService ContentService { get; set; }

    [Parameter] 
    public string Tenant { get; set; } = "stc-consulting";

    private IEnumerable<ContentEntry> Policies = [];

    protected override async Task OnInitializedAsync()
    {
        Policies = await ContentService.GetFooterPoliciesAsync(Tenant);
    }
}