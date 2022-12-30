using Lab.Dal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

        SeedData(builder);
    }

    private void SeedData(ModelBuilder builder)
    {
        // Roles
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole()
            {
                Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                Name = "Client",
                ConcurrencyStamp = "1",
                NormalizedName = "Client Role"
            },
            new IdentityRole()
            {
                Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                Name = "Employee",
                ConcurrencyStamp = "2",
                NormalizedName = "Employee Role"
            }
            );

        // Client User
        ApplicationUser client = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
            FirstName = "Jonh",
            LastName = "Smith",
            UserName = "client@gmail.com",
            NormalizedUserName = "client@gmail.com",
            Email = "client@gmail.com",
            NormalizedEmail = "client@gmail.com",
            LockoutEnabled = false,
        };

        PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
        client.PasswordHash = passwordHasher.HashPassword(client, "123qQ!");

        builder.Entity<ApplicationUser>().HasData(client);

        // Employee User
        ApplicationUser employee = new ApplicationUser()
        {
            Id = "a35ddd14-6340-4840-95c2-db12554843e5",
            FirstName = "Adam",
            LastName = "Black",
            UserName = "employee@gmail.com",
            NormalizedUserName = "employee@gmail.com",
            Email = "employee@gmail.com",
            NormalizedEmail = "employee@gmail.com",
            LockoutEnabled = false,
        };
            
        PasswordHasher<ApplicationUser> passwordHasherForEmp = new PasswordHasher<ApplicationUser>(); 
        employee.PasswordHash = passwordHasherForEmp.HashPassword(employee, "123qQ!");

        builder.Entity<ApplicationUser>().HasData(employee);

        // Users to Role
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>()
            {
                RoleId = "fab4fac1-c546-41de-aebc-a14da6895711",
                UserId = "b74ddd14-6340-4840-95c2-db12554843e5"
            }
        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>()
            {
                RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330",
                UserId = "a35ddd14-6340-4840-95c2-db12554843e5"
            }
        );
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(100);
        builder.Property(u => u.LastName).HasMaxLength(100);
        builder.Property(u => u.MiddleName).HasMaxLength(100);
    }
}
