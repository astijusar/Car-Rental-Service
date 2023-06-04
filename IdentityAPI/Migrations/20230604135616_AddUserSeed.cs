using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9471fb1b-0ee0-43d2-9004-e59be06ee256", 0, "92650611-dfbb-4bc1-97cc-c04bcdb6365b", "user@email.com", false, "FirstName", "LastName", false, null, "USER@EMAIL.COM", "USER@EMAIL.COM", "AQAAAAEAACcQAAAAEPx5yvsLZxojJNJ26oMfTBsti87JpC1KtBTMSEPfJcxkl64+YhZs1hzTSmiSoOorkQ==", null, false, "e2256d6c-6d7d-4fa1-9629-2075d550cb3c", false, "user@email.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9471fb1b-0ee0-43d2-9004-e59be06ee256");
        }
    }
}
