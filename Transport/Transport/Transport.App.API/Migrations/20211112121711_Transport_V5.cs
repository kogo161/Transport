using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Transport.App.API.Migrations
{
    public partial class Transport_V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalNumber = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkLatName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarkGeoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelLatName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelGeoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfProduction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ColorIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelType = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<byte>(type: "tinyint", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transport_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transport_UserId",
                table: "Transport",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonalNumber",
                table: "User",
                column: "PersonalNumber",
                unique: true,
                filter: "[PersonalNumber] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transport");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
