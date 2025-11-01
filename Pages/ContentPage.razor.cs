using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Pages;
public partial class ContentPage
{
    [Inject]
    public required IContentService ContentService { get; set; }

    [Inject]
    public required IMarkdownService MarkdownService { get; set; }

    [Parameter]
    public required string Tenant { get; set; } = "stc-consulting";

    [Parameter]
    public string Slug { get; set; } = string.Empty;

    public ContentEntry? CurrentEntry { get; set; }

    private string PageTitle = "Lade Inhalt…";

    private string markdownContent = string.Empty;
    private bool allowHtml = true;

    protected override async Task OnParametersSetAsync()
    {
        markdownContent = string.Empty;

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

        var MarkdownFile = $"https://raw.githubusercontent.com/chstorb/chstorb/main/content/{entry.File}";

        markdownContent = await MarkdownService.GetContentAsync(MarkdownFile);
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