using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrape.Model
{
    public class Vacancy
    {
        public Vacancy()
        {
            Vacancies = new List<Vacancy>();
        }

        public string URL { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Company { get; set; }

        public string Location { get; set; }

        public string Logo {  get; set; }

        public Domain Domain { get; set; }

        public IList<Vacancy> Vacancies { get; set; }
    }
}
