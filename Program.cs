using BlazorWebAssemblyApp;
using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using System.Text;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add appsettings.json to configuration
using var client = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
var response = await client.GetAsync("appsettings.json");
var json = await response.Content.ReadAsStringAsync();

var config = new ConfigurationBuilder()
    .AddJsonStream(new MemoryStream(Encoding.UTF8.GetBytes(json)))
    .Build();

builder.Configuration.AddConfiguration(config);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddRadzenComponents();

builder.Services.AddSingleton<GitHubService>();

builder.Services.Configure<PeriodicDataServiceOptions>(options =>
{
    builder.Configuration.GetSection(nameof(PeriodicDataService)).Bind(options);
});
builder.Services.AddSingleton<PeriodicDataService>();

await builder.Build().RunAsync();
