using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class cambiohoras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "usuarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 10, 14, 32, 19, 423, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "usuarios");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 8, 29, 10, 41, 16, 543, DateTimeKind.Local).AddTicks(5313));
        }
    }
}
