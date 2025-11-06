using System.Net.Http;

namespace SitemapGenerator;

public class HttpClientFactoryStub : IHttpClientFactory
{
    public HttpClient CreateClient(string name)
    {
        return new HttpClient
        {
            BaseAddress = new Uri("https://raw.githubusercontent.com/chstorb/chstorb/main/content/")
        };
    }
}
