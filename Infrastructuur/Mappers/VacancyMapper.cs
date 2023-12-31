using Infrastructuur.DTO;
using Scrape.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructuur.Mappers
{
    public static class VacancyMapper
    {
        public static Vacancy MapToVacancy(VacancyDescriptionDto vacancy)
        {
            return new Vacancy
            {
                Id = vacancy.Id,
                Description =   vacancy.Description,
                // add rest of properties later
            };
        }
    }
}
