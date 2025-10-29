namespace BlazorWebAssemblyApp.Services;

public class ContentEntry
{
    public string Title { get; set; }
    public string Slug { get; set; }
    public string File { get; set; }
    public string Section { get; set; } = "main";
    public bool Hidden { get; set; } = false;
    public int Order { get; set; } = 0;
    public string Tenant { get; set; } = "default";
    public List<ContentEntry> Children { get; set; } = new();
}
