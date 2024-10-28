using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class tablasPeriodos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "periodoshorarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Actual = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CicloLectivoId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_periodoshorarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_periodoshorarios_cicloslectivos_CicloLectivoId",
                        column: x => x.CicloLectivoId,
                        principalTable: "cicloslectivos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "periodosinscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CicloLectivoId = table.Column<int>(type: "int", nullable: true),
                    InscripcionHabilitada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SoloMaterias2doCuatrimestre = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_periodosinscripciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_periodosinscripciones_cicloslectivos_CicloLectivoId",
                        column: x => x.CicloLectivoId,
                        principalTable: "cicloslectivos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 28, 1, 54, 55, 3, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.InsertData(
                table: "periodoshorarios",
                columns: new[] { "Id", "Actual", "CicloLectivoId", "Eliminado", "Nombre" },
                values: new object[] { 1, true, 1, false, "Ciclo lectivo 2024 - 2do cuatrimestre" });

            migrationBuilder.InsertData(
                table: "periodosinscripciones",
                columns: new[] { "Id", "CicloLectivoId", "Eliminado", "InscripcionHabilitada", "Nombre", "SoloMaterias2doCuatrimestre" },
                values: new object[,]
                {
                    { 1, 1, false, true, "Ciclo lectivo 2024 - Inicio año", false },
                    { 2, 1, false, true, "Ciclo lectivo 2024 - 2do cuatrimestre", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_periodoshorarios_CicloLectivoId",
                table: "periodoshorarios",
                column: "CicloLectivoId");

            migrationBuilder.CreateIndex(
                name: "IX_periodosinscripciones_CicloLectivoId",
                table: "periodosinscripciones",
                column: "CicloLectivoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "periodoshorarios");

            migrationBuilder.DropTable(
                name: "periodosinscripciones");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 28, 1, 21, 56, 745, DateTimeKind.Local).AddTicks(9804));
        }
    }
}
