using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmicDeluxeAdventure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ship",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ship", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Miles = table.Column<long>(type: "bigint", nullable: false),
                    ShipIdID = table.Column<int>(type: "int", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Flight_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flight_Ship_ShipIdID",
                        column: x => x.ShipIdID,
                        principalTable: "Ship",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "ID", "Arrival", "Departure", "LocationID", "Miles", "ShipIdID", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 23, 23, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 7, 56, 0, 0, DateTimeKind.Unspecified), null, 1000000L, null, 1 },
                    { 2, new DateTime(2023, 12, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 30, 10, 10, 0, 0, DateTimeKind.Unspecified), null, 2309847123L, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[] { 1, "Originally built as a science and exploration space.  Since the growth of inter-planetary travel has become the premier gateway to other planets", "Internation Space Station" });

            migrationBuilder.InsertData(
                table: "Ship",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[] { 1, "First and the finest of the Adventure Class Ships.", "Orbital Horizons" });

            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "ID", "Address", "City", "Country", "FirstName", "LastName", "PhoneNumber", "State", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { 1, "1234 Corneria Way", "Imperial Base", "Corneria", "Fox", "McCloud", 1112223333, "Alpha", "barrelRoll1", 12345 },
                    { 2, "SR388", "Ancient City", "Zebes", "Samus", "Aran", 1234567890, "Unknown", "lastMet2", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flight_LocationID",
                table: "Flight",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_ShipIdID",
                table: "Flight",
                column: "ShipIdID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Ship");
        }
    }
}
