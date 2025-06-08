using AutoMapper;
using LanguageManagement.Application.DTOs;
using LanguageManagement.Domain.Entities;

namespace LanguageManagement.Application.Mappings
{
    public class LanguageMappingProfile : Profile
    {
     public LanguageMappingProfile()
        {
            CreateMap<CultureData, Language>()
           .ConstructUsing(x => new Language(
                           x.Id,
                           x.Name,
                           x.CultureCode,
                           x.ShortCode,
                           x.IsActive,
                           x.InsertTime));
        }
                           
    }
}
