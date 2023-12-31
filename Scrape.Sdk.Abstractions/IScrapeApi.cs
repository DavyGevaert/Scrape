using Scrape.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrape.Sdk.Abstractions
{
    public interface IScrapeApi
    {
        Task<string> GetString(string url, string className);
    }
}
