using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class aulacontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aulas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aulas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 17, 16, 30, 40, 457, DateTimeKind.Local).AddTicks(7465));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aulas");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 17, 16, 22, 41, 679, DateTimeKind.Local).AddTicks(4420));
        }
    }
}
