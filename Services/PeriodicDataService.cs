using global::BlazorWebAssemblyApp.Models.GitHub;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorWebAssemblyApp.Services;

public class PeriodicDataService
{
    private readonly JsonSerializerOptions options;
    private readonly PeriodicTimer timer;
    private readonly PeriodicDataServiceOptions serviceOptions;
    private IEnumerable<Issue> issues = [];
    private readonly HttpClient httpClient;
    private CancellationTokenSource cancellationTokenSource;

    public event Action<IEnumerable<Issue>>? OnDataUpdated;

    public PeriodicDataService(IOptions<PeriodicDataServiceOptions> options)
    {
        serviceOptions = options.Value;
        this.options = new JsonSerializerOptions();
        this.options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
        httpClient = new HttpClient();
        timer = new PeriodicTimer(TimeSpan.FromMilliseconds(serviceOptions.IntervalInMilliseconds));
        cancellationTokenSource = new CancellationTokenSource();
    }

    public void Start()
    {
        // Rufe FetchData direkt nach dem Start auf
        _ = FetchIssues(DateTime.UtcNow.AddMonths(-1));
        // Starte den periodischen Aufruf
        _ = FetchDataPeriodically();
    }

    public void Stop()
    {
        cancellationTokenSource.Cancel();
    }

    private async Task FetchDataPeriodically()
    {
        while (await timer.WaitForNextTickAsync(cancellationTokenSource.Token))
        {
            var issues = await FetchIssues(DateTime.UtcNow.AddMonths(-1));
            OnDataUpdated?.Invoke(issues);
        }
    }

    private async Task<IEnumerable<Issue>> FetchIssues(DateTime since)
    {
        var issues = new List<Issue>();

        var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.github.com/repos/dotnet/aspnetcore/issues?state=all&labels=area-blazor&per_page=100&since={since:yyyy-MM-ddThh:mm:ssZ}");
        request.Headers.Add("User-Agent", "BlazorApp");

        var response = await httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            using var responseStream = await response.Content.ReadAsStreamAsync();
            var page = await JsonSerializer.DeserializeAsync<IEnumerable<Issue>>(responseStream, options);
            issues.AddRange(page);
            var link = Link.FromHeader(response.Headers.GetValues("Link"));

            while (link.Next != null)
            {
                request = new HttpRequestMessage(HttpMethod.Get, link.Next);
                request.Headers.Add("User-Agent", "BlazorApp");

                response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        page = await JsonSerializer.DeserializeAsync<IEnumerable<Issue>>(stream, options);
                        issues.AddRange(page);
                    }

                    link = Link.FromHeader(response.Headers.GetValues("Link"));
                }
                else
                {
                    break;
                }
            }
        }
        else
        {
            throw new ApplicationException(response.ReasonPhrase);
        }

        return issues;
    }
}
