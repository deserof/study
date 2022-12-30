using Microsoft.AspNetCore.Identity;

namespace Lab.Dal.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
}
