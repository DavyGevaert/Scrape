

using Scrape.Sdk.Abstractions;
using System.Net.Http.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using System.Text;
using Scrape.Model;

namespace Scrape.Sdk
{
    public class ScrapeApi : IScrapeApi
    {

        // https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-8.0

        private readonly IHttpClientFactory _httpClientFactory;

        public ScrapeApi(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetString(string url, string className)
        {
            var httpClient = _httpClientFactory.CreateClient("Scrape");

            var route = $"/Scrape/Get?url={url}&className={className}";   // zelfde als route in Swagger UI


            var httpResponse = await httpClient.GetAsync(route);

            httpResponse.EnsureSuccessStatusCode();

            var result = await httpResponse.Content.ReadAsStringAsync();

            if (result is null)
            {
                return "";
            }

            return result;
        }
    }
}
