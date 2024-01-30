using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string> 
                {
                    RoleId = "dfc63980-bb2a-4281-aa45-6c14b0c9e47a",
                    UserId = "6dd43043-2c51-4076-a4c9-1d4ca42e5749"
                },
                new IdentityUserRole<string> 
                {
                    RoleId = "klm63980-bb2a-5024-zz69-6c14b0c9e47b",
                    UserId = "baf63980-aa8b-5678-aa36-6c14b0c3e49b"
                }
            );
        }
    }
}