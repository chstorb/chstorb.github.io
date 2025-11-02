using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Pages.Components;
public partial class MarkdownContent
{
    [Inject]
    public required IContentService ContentService { get; set; }

    [Inject]
    public required IMarkdownService MarkdownService { get; set; }

    [Parameter]
    public required string Tenant { get; set; } = "stc-consulting";

    [Parameter]
    public string Slug { get; set; } = string.Empty;

    protected ContentEntry? CurrentEntry { get; set; }

    private string PageTitle = "Lade Inhalt …";

    private string Description = string.Empty;
    private string Robots = "index, follow";
    private string OgTitle = string.Empty;
    private string OgDescription = string.Empty;
    private string OgType = "website";

    private string markdownContent = string.Empty;
    private bool allowHtml = true;

    protected override async Task OnParametersSetAsync()
    {
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

        CurrentEntry = FindEntryBySlug(root, Slug);
        if (CurrentEntry is null || string.IsNullOrWhiteSpace(CurrentEntry.File))
        {
            PageTitle = "Seite nicht gefunden";
            return;
        }

        PageTitle = CurrentEntry.Seo?.Title ?? CurrentEntry.Title;
        Description = CurrentEntry?.Seo?.Description ?? "STC STORB Consulting - Entdecken Sie unsere Cloud-, Dokumentations- und E-Commerce-Dienstleistungen.";
        Robots = CurrentEntry?.Seo?.Robots ?? "index, follow";
        OgTitle = CurrentEntry?.Seo?.Title ?? CurrentEntry?.Title ?? "STC STORB Consulting";
        OgDescription = CurrentEntry?.Seo?.Description ?? "STC STORB Consulting - Entdecken Sie unsere Cloud-, Dokumentations- und E-Commerce-Dienstleistungen.";

        var markdownFile = $"https://raw.githubusercontent.com/chstorb/chstorb/main/content/{CurrentEntry?.File ?? "consulting/index.md"}";

        markdownContent = await MarkdownService.GetContentAsync(markdownFile);
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