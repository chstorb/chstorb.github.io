using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWebAssemblyApp.Pages;
public partial class ContentPage
{
    [Inject]
    public required IContentService ContentService { get; set; }

    [Inject]
    public required IJSRuntime JS { get; set; }

    [Inject]
    public required IMarkdownService MarkdownService { get; set; }

    [Inject]
    public required NavigationManager Navigation { get; set; }

    [Parameter]
    public required string Tenant { get; set; } = "stc-consulting";

    [Parameter]
    public string Slug { get; set; } = string.Empty;

    public ContentEntry? CurrentEntry { get; set; }

    private string PageTitle = "Lade Inhalt…";

    private string markdownContent = string.Empty;
    private bool allowHtml = true;

    private bool isRoot => string.IsNullOrEmpty(Tenant) && string.IsNullOrEmpty(Slug);


    protected override async Task OnParametersSetAsync()
    {
        var isRoot = string.IsNullOrWhiteSpace(Tenant) && string.IsNullOrWhiteSpace(Slug);

        if (isRoot)
        {
            // Try to get last route from session storage
            var lastRoute = await JS.InvokeAsync<string>("sessionStorage.getItem", "lastRoute");
            if (!string.IsNullOrEmpty(lastRoute))
            {
                Navigation.NavigateTo(lastRoute, forceLoad: true);
                return;
            }

            // Fallback to default
            Tenant = "stc-consulting";
            Slug = "company";
        }

        await LoadContentAsync(Tenant, Slug);
    }

    private async Task LoadContentAsync(string tenant, string slug)
    {
        markdownContent = string.Empty;

        if (string.IsNullOrWhiteSpace(Tenant))
        {
            Tenant = "stc-consulting";
        }

        if (string.IsNullOrWhiteSpace(Slug))
        {
            Slug = "company";
        }

        var root = await ContentService.GetTenantRootAsync(Tenant);
        if (root is null)
        {
            PageTitle = "Mandant nicht gefunden";
            return;
        }

        var entry = FindEntryBySlug(root, Slug);
        if (entry is null || string.IsNullOrWhiteSpace(entry.File))
        {
            PageTitle = "Seite nicht gefunden";
            return;
        }

        PageTitle = entry.Seo?.Title ?? entry.Title;

        var markdownFile = $"https://raw.githubusercontent.com/chstorb/chstorb/main/content/{entry.File}";

        markdownContent = await MarkdownService.GetContentAsync(markdownFile);

        var current = $"/{tenant}/content/{slug}";
        await JS.InvokeVoidAsync("sessionStorage.setItem", "lastRoute", current);
    }

    private static ContentEntry? FindEntryBySlug(ContentEntry entry, string slug)
    {
        if (entry.Slug == slug) return entry;

        foreach (var child in entry.Children ?? Enumerable.Empty<ContentEntry>())
        {
            var match = FindEntryBySlug(child, slug);
            if (match is not null) return match;
        }

        return null;
    }
}