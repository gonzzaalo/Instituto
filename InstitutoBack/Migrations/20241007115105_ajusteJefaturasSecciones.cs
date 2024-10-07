using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class ajusteJefaturasSecciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jefessecciones");

            migrationBuilder.CreateTable(
                name: "jefaturassecciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DocenteId = table.Column<int>(type: "int", nullable: true),
                    CarreraId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jefaturassecciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_jefaturassecciones_carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "carreras",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_jefaturassecciones_docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "docentes",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 7, 8, 51, 4, 716, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.CreateIndex(
                name: "IX_jefaturassecciones_CarreraId",
                table: "jefaturassecciones",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_jefaturassecciones_DocenteId",
                table: "jefaturassecciones",
                column: "DocenteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jefaturassecciones");

            migrationBuilder.CreateTable(
                name: "jefessecciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarreraId = table.Column<int>(type: "int", nullable: true),
                    DocenteId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jefessecciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_jefessecciones_carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "carreras",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_jefessecciones_docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "docentes",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 7, 8, 32, 23, 628, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.CreateIndex(
                name: "IX_jefessecciones_CarreraId",
                table: "jefessecciones",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_jefessecciones_DocenteId",
                table: "jefessecciones",
                column: "DocenteId");
        }
    }
}
