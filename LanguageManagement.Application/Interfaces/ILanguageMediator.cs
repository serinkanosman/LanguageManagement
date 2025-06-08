using LanguageManagement.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LanguageManagement.Application.Interfaces
{
    public interface ILanguageMediator
    {
        Task<List<CultureData>> GetCulturesAsync();
    }
}
