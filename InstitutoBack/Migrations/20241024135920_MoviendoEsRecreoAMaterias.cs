using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class MoviendoEsRecreoAMaterias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsRecreo",
                table: "horas");

            migrationBuilder.AddColumn<bool>(
                name: "EsRecreo",
                table: "materias",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 24, 10, 59, 19, 580, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 1,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 2,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 3,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 4,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 5,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 6,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 7,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 8,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 9,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 10,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 11,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 12,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 13,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 14,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 15,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 16,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 17,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 18,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 19,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 20,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 21,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 22,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 23,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 24,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 25,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 26,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 27,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 28,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 29,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 30,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 31,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 32,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 33,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 34,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 35,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 36,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 37,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 38,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 39,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 40,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 41,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 42,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 43,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 44,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 45,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 46,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 47,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 48,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 49,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 50,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 51,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 52,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 53,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 54,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 55,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 56,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 57,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 58,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 59,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 60,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 61,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 62,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 63,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 64,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 65,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 66,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 67,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 68,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 69,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 70,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 71,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 72,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 73,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 74,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 75,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 76,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 77,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 78,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 79,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 80,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 81,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 82,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 83,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 84,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 85,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 86,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 87,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 88,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 89,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 90,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 91,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 92,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 93,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 94,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 95,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 96,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 97,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 98,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 99,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 100,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 101,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 102,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 103,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 104,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 105,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 106,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 107,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 108,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 109,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 110,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 111,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 112,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 113,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 114,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 115,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 116,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 117,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 118,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 119,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 120,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 121,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 122,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 123,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 124,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 125,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 126,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 127,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 128,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 129,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 130,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 131,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 132,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 133,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 134,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 135,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 136,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 137,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 138,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 139,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 140,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 141,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 142,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 143,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 144,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 145,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 146,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 147,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 148,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 149,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 150,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 151,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 152,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 153,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 154,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 155,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 156,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 157,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 158,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 159,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 160,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 161,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 162,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 163,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 164,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 165,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 166,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 167,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 168,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 169,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 170,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 171,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 172,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 173,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 174,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 175,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 176,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 177,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 178,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 179,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 180,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 181,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 182,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 183,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 184,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 185,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 186,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 187,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 188,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 189,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 190,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 191,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 192,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 193,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 194,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 195,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 196,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 197,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 198,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 199,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 200,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 201,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 202,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 203,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 204,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 205,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 206,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 207,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 208,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 209,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 210,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 211,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 212,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 213,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 214,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 215,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 216,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 217,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 218,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 219,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 220,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 221,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 222,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 223,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 224,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 225,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 226,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 227,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 228,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 229,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 230,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 231,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 232,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 233,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 234,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 235,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 236,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 237,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 238,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 239,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 240,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 241,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 242,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 243,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 244,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 245,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 246,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 247,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 248,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 249,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 250,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 251,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 252,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 253,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 254,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 255,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 256,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 257,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 258,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 259,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 260,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 261,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 262,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 263,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 264,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 265,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 266,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 267,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 268,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 269,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 270,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 271,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 272,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 273,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 274,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 275,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 276,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 277,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 278,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 279,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 280,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 281,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 282,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 283,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 284,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 285,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 286,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 287,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 288,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 289,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 290,
                column: "EsRecreo",
                value: false);

            migrationBuilder.UpdateData(
                table: "materias",
                keyColumn: "Id",
                keyValue: 291,
                column: "EsRecreo",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsRecreo",
                table: "materias");

            migrationBuilder.AddColumn<bool>(
                name: "EsRecreo",
                table: "horas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 21, 14, 59, 35, 807, DateTimeKind.Local).AddTicks(4700));
        }
    }
}
