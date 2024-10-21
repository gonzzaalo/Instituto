using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class ActializamosModeloTurnoExamen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Actual",
                table: "turnosexamenes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 21, 15, 2, 6, 680, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "turnosexamenes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Actual",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actual",
                table: "turnosexamenes");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 17, 16, 47, 25, 631, DateTimeKind.Local).AddTicks(4537));
        }
    }
}
