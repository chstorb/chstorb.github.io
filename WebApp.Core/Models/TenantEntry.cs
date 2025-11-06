namespace WebApp.Core.Models;

public class TenantEntry
{
    public string Title { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string File { get; set; } = string.Empty;
    public string Section { get; set; } = "main";
    public int Order { get; set; } = 0;
    public string Tenant { get; set; } = "default";
    public string Icon { get; set; } = "folder";
    public bool Hidden { get; set; } = false;
    public string Tooltip { get; set; } = string.Empty;
    public string Badge { get; set; } = string.Empty;
    public SeoMetadata Seo { get; set; } = new();
    public List<TenantEntry> Children { get; set; } = [];
}
