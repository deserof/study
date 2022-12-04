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
        [ProducesResponseType(typeof(UserModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> LoginAsync(UserModel userLoginRequestModel)
        {
            var users = await _readerService.ReadListAsync<UserModel>("Administrators.json");

            var user = users.FirstOrDefault(x=>x.LastName == userLoginRequestModel.LastName);

            if (user.Password == userLoginRequestModel.Password)
            {
                return Ok(new UserModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Position = user.Position,
                    Password = user.Password,
                });
            }

            return Unauthorized();
        }
    }
}
