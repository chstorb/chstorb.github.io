using BlazorWebAssemblyApp;
using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddRadzenComponents();
builder.Services.AddScoped<IContentService, ContentService>();
builder.Services.AddScoped<IMarkdownService, MarkdownService>();

await builder.Build().RunAsync();
