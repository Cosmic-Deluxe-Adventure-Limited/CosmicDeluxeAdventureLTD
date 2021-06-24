using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmicDeluxeAdventure.Migrations
{
  public partial class initial : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "UserInfo",
          columns: table => new
          {
            ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            City = table.Column<string>(type: "nvarchar(max)", nullable: true),
            State = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ZipCode = table.Column<int>(type: "int", nullable: false),
            Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
            PhoneNumber = table.Column<int>(type: "int", nullable: false),
            UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_UserInfo", x => x.ID);
          });

      migrationBuilder.InsertData(
          table: "UserInfo",
          columns: new[] { "ID", "Address", "City", "Country", "FirstName", "LastName", "PhoneNumber", "State", "UserName", "ZipCode" },
          values: new object[] { 1, "1234 Corneria Way", "Imperial Base", "Corneria", "Fox", "McCloud", 1112223333, "Alpha", "barrelRoll1", 12345 });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "UserInfo");
    }
  }
}
