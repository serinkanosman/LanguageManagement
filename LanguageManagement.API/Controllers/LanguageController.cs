using LanguageManagement.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks; // Ensure this using directive is present

namespace LanguageManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageMediator _mediator;

        public LanguageController(ILanguageMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCultures()
        {
            var cultures = await _mediator.GetCulturesAsync();
            return Ok(cultures);
        }
    }
}
