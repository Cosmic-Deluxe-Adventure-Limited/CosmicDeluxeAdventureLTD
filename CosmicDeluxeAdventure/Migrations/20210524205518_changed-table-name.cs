using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmicDeluxeAdventure.Migrations
{
    public partial class changedtablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TABLENAME",
                table: "TABLENAME");

            migrationBuilder.RenameTable(
                name: "TABLENAME",
                newName: "UserInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo");

            migrationBuilder.RenameTable(
                name: "UserInfo",
                newName: "TABLENAME");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TABLENAME",
                table: "TABLENAME",
                column: "ID");
        }
    }
}
