using LanguageManagement.Application.DTOs;
using LanguageManagement.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LanguageManagement.Application
{
    public class LanguageMediator : ILanguageMediator
    {
        private readonly ICultureService _cultureService;

        public LanguageMediator(ICultureService cultureService)
        {
            _cultureService = cultureService;
        }

        public async Task<List<CultureData>> GetCulturesAsync()
        {
            return await _cultureService.GetCulturesAsync();
        }
    }
}
