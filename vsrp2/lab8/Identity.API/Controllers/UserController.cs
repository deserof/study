using Microsoft.OpenApi.Validations;

namespace Identity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IReaderService _readerService;
        private readonly IWriterService _writerService;

        public UserController(IReaderService readerService, IWriterService writerService)
        {
            _readerService = readerService;
            _writerService = writerService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UserModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _readerService.ReadListAsync<UserModel>("Administrators.json");

            return Ok(users);
        }

        [HttpPut]
        [ProducesResponseType(typeof(IEnumerable<UserModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateUser(UserModel userModel)
        {
            if (userModel.Id is null)
            {
                return Ok();
            }

            var users = await _readerService.ReadListAsync<UserModel>("Administrators.json");

            var user = users.FirstOrDefault(x => x.Id == userModel.Id);

            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.Password = userModel.Password;
            user.Position = userModel.Position;

            _writerService.Write(users, "Administrators.json");

            return Ok();
        }
    }
}
