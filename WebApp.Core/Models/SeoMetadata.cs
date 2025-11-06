namespace WebApp.Core.Models;

public class SeoMetadata
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Robots { get; set; } = "index,follow";
}