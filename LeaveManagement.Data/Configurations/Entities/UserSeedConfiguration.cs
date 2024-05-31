using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "6dd43043-2c51-4076-a4c9-1d4ca42e5749",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P_ssword1"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "baf63980-aa8b-5678-aa36-6c14b0c3e49b",
                    Email = "user@localhost.com",
                    NormalizedEmail = "user@LOCALHOST.COM",
                    NormalizedUserName = "user@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P_ssword2"),
                    EmailConfirmed = true
                }
            );
        }
    }
}