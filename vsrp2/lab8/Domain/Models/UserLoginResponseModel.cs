﻿namespace Domain.Models
{
    public class UserLoginResponseModel
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public PositionType Position { get; set; }
    }
}
