using Infrastructuur.DTO;

namespace Infrastructuur.Services.Interfaces
{
    public interface IHtmlParserService
    {
        Task<List<VacancyDescriptionDto>>? JobDescriptionParserAsync(int vacancyAmount,int vacancyNumber);
    }
}