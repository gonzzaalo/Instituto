using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class llamado2EnTurnoExamen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TieneLLamado2",
                table: "turnosexamenes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 28, 15, 58, 20, 233, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "turnosexamenes",
                keyColumn: "Id",
                keyValue: 1,
                column: "TieneLLamado2",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TieneLLamado2",
                table: "turnosexamenes");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 28, 2, 1, 46, 710, DateTimeKind.Local).AddTicks(4632));
        }
    }
}
