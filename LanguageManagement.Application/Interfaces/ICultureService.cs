using LanguageManagement.Application.DTOs;

namespace LanguageManagement.Application.Interfaces
{
    public interface ICultureService
    {
        Task<List<CultureData>> GetCulturesAsync();
    }
}
