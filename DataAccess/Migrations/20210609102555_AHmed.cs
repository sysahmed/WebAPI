using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AHmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    City = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Conutry = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "ChargePoints",
                columns: table => new
                {
                    ChangePointId = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: false),
                    FloorLevel = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationId = table.Column<string>(type: "nvarchar(39)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargePoints", x => x.ChangePointId);
                    table.ForeignKey(
                        name: "FK_ChargePoints_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChargePoints_LocationId",
                table: "ChargePoints",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChargePoints");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
