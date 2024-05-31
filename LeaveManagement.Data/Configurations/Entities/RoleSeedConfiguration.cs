using LeaveManagement.Common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "dfc63980-bb2a-4281-aa45-6c14b0c9e47a",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "klm63980-bb2a-5024-zz69-6c14b0c9e47b",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
           );
        }
    }
}