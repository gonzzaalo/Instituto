using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class ajusteTurnoExamen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CicloLectivoId",
                table: "turnosexamenes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InscripcionHabilitada",
                table: "turnosexamenes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 28, 1, 21, 56, 745, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "turnosexamenes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CicloLectivoId", "InscripcionHabilitada" },
                values: new object[] { null, false });

            migrationBuilder.CreateIndex(
                name: "IX_turnosexamenes_CicloLectivoId",
                table: "turnosexamenes",
                column: "CicloLectivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_turnosexamenes_cicloslectivos_CicloLectivoId",
                table: "turnosexamenes",
                column: "CicloLectivoId",
                principalTable: "cicloslectivos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turnosexamenes_cicloslectivos_CicloLectivoId",
                table: "turnosexamenes");

            migrationBuilder.DropIndex(
                name: "IX_turnosexamenes_CicloLectivoId",
                table: "turnosexamenes");

            migrationBuilder.DropColumn(
                name: "CicloLectivoId",
                table: "turnosexamenes");

            migrationBuilder.DropColumn(
                name: "InscripcionHabilitada",
                table: "turnosexamenes");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 28, 0, 47, 47, 513, DateTimeKind.Local).AddTicks(9650));
        }
    }
}
