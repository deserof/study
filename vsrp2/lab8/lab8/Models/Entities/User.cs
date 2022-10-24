﻿using lab8.Models.Enums;

namespace lab8.Models.Entities
{
    public class User
    {
        public string UserName { get; set; }  

        public string? Password { get; set; }  

        public PositionType? Position { get; set; }

        public UserType UserType { get; set; }
    }
}
