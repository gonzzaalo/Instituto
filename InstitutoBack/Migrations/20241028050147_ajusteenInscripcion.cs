using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class ajusteenInscripcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inscripciones_cicloslectivos_CicloLectivoId",
                table: "inscripciones");

            migrationBuilder.DropIndex(
                name: "IX_inscripciones_CicloLectivoId",
                table: "inscripciones");

            migrationBuilder.DropColumn(
                name: "CicloLectivoId",
                table: "inscripciones");

            migrationBuilder.AddColumn<int>(
                name: "PeriodoInscripcionId",
                table: "inscripciones",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "PeriodoInscripcionId" },
                values: new object[] { new DateTime(2024, 10, 28, 2, 1, 46, 710, DateTimeKind.Local).AddTicks(4632), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_inscripciones_PeriodoInscripcionId",
                table: "inscripciones",
                column: "PeriodoInscripcionId");

            migrationBuilder.AddForeignKey(
                name: "FK_inscripciones_periodosinscripciones_PeriodoInscripcionId",
                table: "inscripciones",
                column: "PeriodoInscripcionId",
                principalTable: "periodosinscripciones",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inscripciones_periodosinscripciones_PeriodoInscripcionId",
                table: "inscripciones");

            migrationBuilder.DropIndex(
                name: "IX_inscripciones_PeriodoInscripcionId",
                table: "inscripciones");

            migrationBuilder.DropColumn(
                name: "PeriodoInscripcionId",
                table: "inscripciones");

            migrationBuilder.AddColumn<int>(
                name: "CicloLectivoId",
                table: "inscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CicloLectivoId", "Fecha" },
                values: new object[] { 1, new DateTime(2024, 10, 28, 1, 54, 55, 3, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.CreateIndex(
                name: "IX_inscripciones_CicloLectivoId",
                table: "inscripciones",
                column: "CicloLectivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_inscripciones_cicloslectivos_CicloLectivoId",
                table: "inscripciones",
                column: "CicloLectivoId",
                principalTable: "cicloslectivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
