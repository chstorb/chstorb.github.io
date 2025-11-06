using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using WebApp;
using WebApp.Core.Configuration.Http;
using WebApp.Core.Interfaces;
using WebApp.Core.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient(HttpClientNames.App, client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient(HttpClientNames.GitHubRaw, client =>
{
    // Try read configuration (from wwwroot/appsettings.json in Blazor WASM)
    var githubRawBase = builder.Configuration[HttpClientConfigKeys.GitHubRawBaseAddress];

    // Fallback to a public GitHub raw URL if not configured for the browser environment
    if (string.IsNullOrWhiteSpace(githubRawBase))
    {
        githubRawBase = "https://raw.githubusercontent.com/chstorb/chstorb/main/content/";
        Console.WriteLine($"Warning: HttpClients:GitHubRaw:BaseAddress not found. Falling back to '{githubRawBase}'.");
    }

    if (!Uri.TryCreate(githubRawBase, UriKind.Absolute, out var baseUri) ||
        (baseUri.Scheme != Uri.UriSchemeHttp && baseUri.Scheme != Uri.UriSchemeHttps))
    {
        throw new InvalidOperationException($"Invalid GitHubRaw BaseAddress: '{githubRawBase}'. Must be an absolute http(s) URL.");
    }

    client.BaseAddress = baseUri;
    client.DefaultRequestHeaders.UserAgent.ParseAdd(HttpClientNames.GitHubUserAgent);
});

builder.Services.AddRadzenComponents();
builder.Services.AddScoped<IContentService, ContentService>();
builder.Services.AddScoped<IMarkdownService, MarkdownService>();

await builder.Build().RunAsync();
