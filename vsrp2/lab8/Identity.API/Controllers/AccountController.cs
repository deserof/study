using Domain.Models;
using Identity.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Identity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IReaderService _readerService;

        public AccountController(IReaderService readerService)
        {
            _readerService = readerService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserLoginResponseModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> LoginAsync(UserLoginRequestModel userLoginRequestModel)
        {
            IEnumerable<UserModel> users = await _readerService.ReadListAsync<UserModel>("Administrators.json");

            var user = users.FirstOrDefault(x=>x.LastName == userLoginRequestModel.LastName);

            if (user.Password == userLoginRequestModel.Password)
            {
                return Ok(new UserLoginResponseModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Position = user.Position
                });
            }

            return Unauthorized();
        }
    }
}
