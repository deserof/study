﻿using Microsoft.AspNetCore.Identity;

namespace Lab.Dal.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }

    public string Address { get; set; }

    public string BankCode { get; set; }

    public string CardNumber { get; set; }
}