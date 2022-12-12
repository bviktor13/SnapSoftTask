using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgrammingTask.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculationLogs",
                columns: table => new
                {
                    CalculationLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationLogs", x => x.CalculationLogId);
                });

            migrationBuilder.CreateTable(
                name: "CalculationItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CalculationLogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationItem_CalculationLogs_CalculationLogId",
                        column: x => x.CalculationLogId,
                        principalTable: "CalculationLogs",
                        principalColumn: "CalculationLogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalculationItem_CalculationLogId",
                table: "CalculationItem",
                column: "CalculationLogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculationItem");

            migrationBuilder.DropTable(
                name: "CalculationLogs");
        }
    }
}
