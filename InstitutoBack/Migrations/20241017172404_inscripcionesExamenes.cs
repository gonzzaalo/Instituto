using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class inscripcionesExamenes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inscripcionesExamenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    CarreraId = table.Column<int>(type: "int", nullable: false),
                    TurnoExamenId = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscripcionesExamenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inscripcionesExamenes_alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inscripcionesExamenes_carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inscripcionesExamenes_turnosexamenes_TurnoExamenId",
                        column: x => x.TurnoExamenId,
                        principalTable: "turnosexamenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detallesInscripcionesExamenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InscripcionExamenId = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detallesInscripcionesExamenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detallesInscripcionesExamenes_inscripcionesExamenes_Inscripc~",
                        column: x => x.InscripcionExamenId,
                        principalTable: "inscripcionesExamenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detallesInscripcionesExamenes_materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 17, 14, 24, 3, 291, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.CreateIndex(
                name: "IX_detallesInscripcionesExamenes_InscripcionExamenId",
                table: "detallesInscripcionesExamenes",
                column: "InscripcionExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_detallesInscripcionesExamenes_MateriaId",
                table: "detallesInscripcionesExamenes",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_inscripcionesExamenes_AlumnoId",
                table: "inscripcionesExamenes",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_inscripcionesExamenes_CarreraId",
                table: "inscripcionesExamenes",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_inscripcionesExamenes_TurnoExamenId",
                table: "inscripcionesExamenes",
                column: "TurnoExamenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detallesInscripcionesExamenes");

            migrationBuilder.DropTable(
                name: "inscripcionesExamenes");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 13, 11, 56, 51, 520, DateTimeKind.Local).AddTicks(368));
        }
    }
}
