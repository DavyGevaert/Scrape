

using HtmlAgilityPack;
using Scrape.Model;
using System.Net.Http;
using System.Xml;

namespace Scrape.Data.Helpers
{
    public class HTMLRequest
    {
        private HttpClient _httpClient;

        public HTMLRequest(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task ScrapeVDABWebsite(string route)
        {
            // instance or static variable
            _httpClient = new HttpClient();

            // get answer in non-blocking way
            using (var response = await _httpClient.GetAsync(route))
            {
                using (var content = response.Content)
                {
                    // read answer in non-blocking way
                    var result = await content.ReadAsStringAsync();
                    var doc = new HtmlDocument();

                    doc.LoadHtml(result);

                    var nodes = doc.DocumentNode.SelectNodes("ul _ngcontent-vej-c53 class='c-vacature-container'");

                    foreach (var node in nodes)
                    {
                        var li = node.SelectSingleNode("li _ngcontent-vej-c53 class='c-vacature'");

                        li.ToString();
                    }



                    //Some work with page....
                }
            }


            // <ul _ngcontent-vej-c53 class="c-vacature-container">
            //     <li _ngcontent-vej-c53 class="c-vacature"></li>
            // </ul>
        }
    }
}
