using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityAPI.Models.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();

            builder.HasData
            (
                new User
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Email = "user@email.com",
                    NormalizedEmail = "USER@EMAIL.COM",
                    UserName = "user@email.com",
                    NormalizedUserName = "USER@EMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "/Password12")
                }
            );
        }
    }
}
