using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrape.Model
{
    public class SearchPattern
    {
        public SearchPattern()
        {
            Vacancies = new Collection<Vacancy>();
        }

        public string URL = "https://www.vdab.be/vindeenjob/vacatures?sort=standaard";

        public string Domain {  get; set; }

        public Collection<Vacancy> Vacancies { get; set; }
    }
}
