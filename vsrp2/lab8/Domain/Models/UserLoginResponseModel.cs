using Domain.Enums;

namespace Domain.Models
{
    public class UserLoginResponseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public PositionType Position { get; set; }
    }
}
