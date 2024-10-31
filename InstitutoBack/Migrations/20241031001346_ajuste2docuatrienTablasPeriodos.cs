using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class ajuste2docuatrienTablasPeriodos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoloMaterias2doCuatrimestre",
                table: "periodosinscripciones",
                newName: "Es2doCuatrimestre");

            migrationBuilder.AddColumn<bool>(
                name: "Es2doCuatrimestre",
                table: "periodoshorarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 30, 21, 13, 44, 833, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "periodoshorarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Es2doCuatrimestre",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Es2doCuatrimestre",
                table: "periodoshorarios");

            migrationBuilder.RenameColumn(
                name: "Es2doCuatrimestre",
                table: "periodosinscripciones",
                newName: "SoloMaterias2doCuatrimestre");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 28, 15, 58, 20, 233, DateTimeKind.Local).AddTicks(4));
        }
    }
}
