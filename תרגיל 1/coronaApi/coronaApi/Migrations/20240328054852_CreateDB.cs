using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coronaApi.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date3 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date4 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Maker1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfResult = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfRecovery = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "members");
        }
    }
}
