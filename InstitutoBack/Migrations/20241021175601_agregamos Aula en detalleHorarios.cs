using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class agregamosAulaendetalleHorarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AulaId",
                table: "detalleshorarios",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 21, 14, 56, 0, 178, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.CreateIndex(
                name: "IX_detalleshorarios_AulaId",
                table: "detalleshorarios",
                column: "AulaId");

            migrationBuilder.AddForeignKey(
                name: "FK_detalleshorarios_aulas_AulaId",
                table: "detalleshorarios",
                column: "AulaId",
                principalTable: "aulas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detalleshorarios_aulas_AulaId",
                table: "detalleshorarios");

            migrationBuilder.DropIndex(
                name: "IX_detalleshorarios_AulaId",
                table: "detalleshorarios");

            migrationBuilder.DropColumn(
                name: "AulaId",
                table: "detalleshorarios");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 17, 16, 47, 25, 631, DateTimeKind.Local).AddTicks(4537));
        }
    }
}
