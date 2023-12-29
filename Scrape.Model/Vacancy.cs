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

        public string Title { get; set; }

        public string Description { get; set; }

        public Domain Domain { get; set; }

        public IList<Vacancy> Vacancies { get; set; }
    }
}
