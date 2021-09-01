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
                    ShipId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Flight_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flight_Ship_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ship",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Originally built as a science and exploration space.  Since the growth of inter-planetary travel has become the premier gateway to other planets", "International Space Station" },
                    { 2, "It's our first and largest satellite, tidally locked for a perfect view of earth", "Moon" },
                    { 3, "It's red, and windy.  Perfect for that wonder desert getaway!", "Mars" }
                });

            migrationBuilder.InsertData(
                table: "Ship",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "First and the finest of the Adventure Class Ships.", "Orbital Horizons" },
                    { 2, "Second Adventure Class Ship with bigger boosters.", "Terminal Velocity" },
                    { 3, "Third Adventure Class Ship to get you to the moon in luxury", "Lunar Bliss" }
                });

            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "ID", "Address", "City", "Country", "FirstName", "LastName", "PhoneNumber", "State", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { 1, "1234 Corneria Way", "Imperial Base", "Corneria", "Fox", "McCloud", 1112223333, "Alpha", "barrelRoll1", 12345 },
                    { 2, "SR388", "Ancient City", "Zebes", "Samus", "Aran", 1234567890, "Unknown", "lastMet2", 0 }
                });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "ID", "Arrival", "Departure", "LocationId", "Miles", "ShipId", "Status" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), 3, 2309847123L, 1, 2 });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "ID", "Arrival", "Departure", "LocationId", "Miles", "ShipId", "Status" },
                values: new object[] { 2, new DateTime(2023, 12, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 30, 10, 10, 0, 0, DateTimeKind.Unspecified), 1, 2309847123L, 2, 2 });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "ID", "Arrival", "Departure", "LocationId", "Miles", "ShipId", "Status" },
                values: new object[] { 1, new DateTime(2022, 10, 23, 23, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 7, 56, 0, 0, DateTimeKind.Unspecified), 2, 1000000L, 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Flight_LocationId",
                table: "Flight",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_ShipId",
                table: "Flight",
                column: "ShipId");
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
