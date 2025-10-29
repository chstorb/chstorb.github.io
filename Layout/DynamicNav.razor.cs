using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Layout;
public partial class DynamicNav
{
    [Inject] 
    public required IContentService ContentService { get; set; }

    List<ContentEntry> Navigation = new();

    protected override async Task OnInitializedAsync()
    {
        var index = await ContentService.GetContentIndexAsync();
        Navigation = index
            .Where(e => e.Section == "main" && !e.Hidden)
            .OrderBy(e => e.Order)
            .ToList();
    }
}