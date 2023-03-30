using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NajotD_Edu.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "PasswordHash", "Role", "UserName" },
                values: new object[] { 1, "Diyor Qurbonboyev", "5032E95A5DA27098273D49FFE608CA49C6A40EB756BDAE65431C6D1B5F8213B44963F2CD459B29704A8207CBE3A9CC8D35A6A1FC374078EF4FC08AC0BECD9DD7", 1, "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
