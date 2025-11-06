using System.Text;
using System.Xml;
using System.Xml.Linq;
using WebApp.Core.Services;

namespace SitemapGenerator;

public class Program
{
    static async Task Main(string[] args)
    {
        var tenant = "consulting"; // später ggf. aus args oder Konfiguration

        var contentService = new ContentService(new HttpClientFactoryStub());
        var root = await contentService.GetTenantIndexAsync(tenant);

        if (root == null)
        {
            Console.WriteLine($"❌ Kein Index für Mandant '{tenant}' gefunden.");
            return;
        }

        var slugs = contentService.GetAllSlugs(root);

        var ns = XNamespace.Get("http://www.sitemaps.org/schemas/sitemap/0.9");

        var urlset = new XElement(ns + "urlset",
            new XAttribute("xmlns", "http://www.sitemaps.org/schemas/sitemap/0.9"),
            slugs.Select(slug =>
                new XElement("url",
                    new XElement("loc", $"https://chstorb.github.io/{tenant}/content/{slug}")
                )
            )
        );

        var doc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), urlset);
        var outputPath = Path.Combine("wwwroot", "sitemap.xml");
        Directory.CreateDirectory("wwwroot");

        var settings = new XmlWriterSettings { Indent = true, Encoding = Encoding.UTF8 };
        using var writer = XmlWriter.Create(outputPath, settings);
        doc.Save(writer);

        Console.WriteLine($"✅ sitemap.xml erfolgreich geschrieben nach: {outputPath}");
    }
}
