using LanguageManagement.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LanguageManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ICultureService _cultureService;

        public LanguageController(ICultureService cultureService)
        {
            _cultureService = cultureService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCultures()
        {
            var cultures = await _cultureService.GetCulturesAsync();
            return Ok(cultures);
        }
    }
}
