using Domain.Models;
using Identity.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Identity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IReaderService _readerService;

        public UserController(IReaderService readerService)
        {
            _readerService = readerService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UserModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUsers()
        {
            IEnumerable<UserModel> users = await _readerService.ReadListAsync<UserModel>("Administrators.json");

            return Ok(users);
        }
    }
}
