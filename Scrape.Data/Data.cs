using Scrape.Model;

namespace Scrape.Data
{
    public class Data
    {
        public IList<Vacancy> GetDomains()
        {
            IList<Vacancy> list = new List<Vacancy>
            {
                new Vacancy { Domain = new Domain { Id = 1, Title = "Aankoop", URLPattern = "&jobdomein=JOBCAT01" } },
                new Vacancy { Domain = new Domain { Id = 2, Title = "Administratie", URLPattern = "&jobdomein=JOBCAT02" } },
                new Vacancy { Domain = new Domain { Id = 3, Title = "Bouw", URLPattern = "&jobdomein=JOBCAT03" } },
                new Vacancy { Domain = new Domain { Id = 4, Title = "Communicatie", URLPattern = "&jobdomein=JOBCAT04" } },
                new Vacancy { Domain = new Domain { Id = 5, Title = "Creatief", URLPattern = "&jobdomein=JOBCAT05" } },
                new Vacancy { Domain = new Domain { Id = 6, Title = "Financieel", URLPattern = "&jobdomein=JOBCAT06" } },
                new Vacancy { Domain = new Domain { Id = 7, Title = "Gezondheid", URLPattern = "&jobdomein=JOBCAT07" } },
                new Vacancy { Domain = new Domain { Id = 8, Title = "Horeca en toerisme", URLPattern = "&jobdomein=JOBCAT08" } },
                new Vacancy { Domain = new Domain { Id = 9, Title = "Human resources", URLPattern = "&jobdomein=JOBCAT09" } },
                new Vacancy { Domain = new Domain { Id = 10, Title = "ICT", URLPattern = "&jobdomein=JOBCAT10" } },
                new Vacancy { Domain = new Domain { Id = 11, Title = "Juridisch", URLPattern = "&jobdomein=JOBCAT11" } },
                new Vacancy { Domain = new Domain { Id = 12, Title = "Land- en tuinbouw", URLPattern = "&jobdomein=JOBCAT12" } },
                new Vacancy { Domain = new Domain { Id = 13, Title = "Logistiek en transport", URLPattern = "&jobdomein=JOBCAT13" } },
                new Vacancy { Domain = new Domain { Id = 14, Title = "Dienstverlening", URLPattern = "&jobdomein=JOBCAT14" } },
                new Vacancy { Domain = new Domain { Id = 15, Title = "Management", URLPattern = "&jobdomein=JOBCAT15" } },
                new Vacancy { Domain = new Domain { Id = 16, Title = "Marketing", URLPattern = "&jobdomein=JOBCAT16" } },
                new Vacancy { Domain = new Domain { Id = 17, Title = "Onderhoud", URLPattern = "&jobdomein=JOBCAT17" } },
                new Vacancy { Domain = new Domain { Id = 18, Title = "Onderwijs", URLPattern = "&jobdomein=JOBCAT18" } },
                new Vacancy { Domain = new Domain { Id = 19, Title = "Overheid", URLPattern = "&jobdomein=JOBCAT19" } },
                new Vacancy { Domain = new Domain { Id = 20, Title = "Onderzoek en ontwikkeling", URLPattern = "&jobdomein=JOBCAT20" } },
                new Vacancy { Domain = new Domain { Id = 21, Title = "Productie", URLPattern = "&jobdomein=JOBCAT21" } },
                new Vacancy { Domain = new Domain { Id = 22, Title = "Techniek", URLPattern = "&jobdomein=JOBCAT22" } },
                new Vacancy { Domain = new Domain { Id = 23, Title = "Verkoop", URLPattern = "&jobdomein=JOBCAT23" } },
                new Vacancy { Domain = new Domain { Id = 24, Title = "Andere", URLPattern = "&jobdomein=JOBCAT24" } }
            };

            return list;
        }
    }
}
