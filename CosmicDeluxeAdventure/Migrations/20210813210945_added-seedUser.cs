using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmicDeluxeAdventure.Migrations
{
    public partial class addedseedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "ID", "Address", "City", "Country", "FirstName", "LastName", "PhoneNumber", "State", "UserName", "ZipCode" },
                values: new object[] { 2, "SR388", "Ancient City", "Zebes", "Samus", "Aran", 1234567890, "Unknown", "lastMet2", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
