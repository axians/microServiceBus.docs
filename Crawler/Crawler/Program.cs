using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace Crawler
{
    class Program
    {
        static List<Page> _pages = new List<Page>();
        static void Main(string[] args)
        {
            var url = args.Length >0 ? args[0]:"http://127.0.0.1:4000";// "https://docs.microservicebus.com";
            Crawl(url).Wait();
        }
        static async Task Crawl(string url)
        {
            
            await CrawlPage(url, "/", "/");
            var json = JsonConvert.SerializeObject(_pages);
            var path = @"..\..\assets\index.json";
            if (File.Exists(path))
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(json);
            }
            Console.WriteLine($"Done crawling {_pages.Count} pages");
            Console.WriteLine();
            Console.WriteLine("Press Y to run again...");
            var result = Console.ReadKey();
            if (result.Key.ToString().ToLower() == "y")
            {
                _pages.Clear();
                await Crawl(url);
            }
        }
        static async Task CrawlPage(string baseurl, string url, string from)
        {
//            Console.WriteLine(url);
            try
            {
                var htmlClient = new HttpClient();
                var html = await htmlClient.GetStringAsync($"{baseurl}{url}");
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                if (url != "/")
                {
                    var title = htmlDocument.DocumentNode.Descendants("h1")
                        .Where(h1 => h1.Attributes.FirstOrDefault(attr => attr.Name == "class" && attr.Value.Contains("post-title")) != null)
                        .Select(h => h.InnerText)
                        .FirstOrDefault();

                    if (title == "Installing microServiceBus-node") {
                        Console.WriteLine();
                    }

                    var pageConent = htmlDocument.DocumentNode.Descendants("div")
                        .Where(c => c.Attributes.FirstOrDefault(attr => attr.Name == "class" && attr.Value.Contains("post-content")) != null)
                        .SelectMany(c => c.Descendants("p"))
                        .Where(c => c.Attributes.FirstOrDefault(attr => attr.Name == "class" && attr.Value.Contains("related-content")) == null)
                        .Select(p => p.InnerText)
                        .ToList();
                    var content = string.Join(" ", pageConent);

                    _pages.Add(new Page { url = $"{baseurl}{url}", title = title, content = content, relativeUrl = url });
                }
                var links = htmlDocument.DocumentNode.Descendants("a")
                    .Select(a => a.Attributes.FirstOrDefault(attr => attr.Name == "href").Value)
                    .Where(l => l != "/" && l.StartsWith("/"))
                    .Distinct()
                    .ToList();

                foreach (var link in links.Where(l=> !_pages.Exists(p => p.relativeUrl == l)))
                {
                    await CrawlPage(baseurl, link, url);
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"{url} Referenced from {from} does not exist");
            }
        }
    }

    public class Page {
        public string relativeUrl { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public override string ToString()
        {
            return this.relativeUrl;
        }
    }
}
