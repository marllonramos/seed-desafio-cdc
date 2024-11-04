using DesafioCdc.ApplicationService.Requests;
using DesafioCdc.ApplicationService.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioCdc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> CreateAuthor(CreateAuthorRequest request)
        {
            await _authorService.CreateAuthor(request);
            return Ok(request);
        }
    }
}
