using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstitutoBack.Migrations
{
    /// <inheritdoc />
    public partial class ajusteHoras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "horas");

            migrationBuilder.AddColumn<DateTime>(
                name: "Desde",
                table: "horas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Hasta",
                table: "horas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Desde", "Hasta" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 10, 14, 26, 28, 964, DateTimeKind.Local).AddTicks(6249));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desde",
                table: "horas");

            migrationBuilder.DropColumn(
                name: "Hasta",
                table: "horas");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "horas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "08:00 a 08:40");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "08:40 a 09:20");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "09:20 a 10:00");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nombre",
                value: "10:00 a 10:40");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nombre",
                value: "10:00 a 10:10");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nombre",
                value: "10:10 a 10:50");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Nombre",
                value: "10:40 a 10:50");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Nombre",
                value: "10:50 a 11:30");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Nombre",
                value: "11:10 a 11:50");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Nombre",
                value: "11:30 a 12:10");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 11,
                column: "Nombre",
                value: "11:50 a 12:30");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 12,
                column: "Nombre",
                value: "12:10 a 12:50");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 13,
                column: "Nombre",
                value: "12:30 a 13:10");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 14,
                column: "Nombre",
                value: "12:50 a 13:30");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 15,
                column: "Nombre",
                value: "13:10 a 13:50");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 16,
                column: "Nombre",
                value: "13:50 a 14:30");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 17,
                column: "Nombre",
                value: "14:30 a 15:10");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 18,
                column: "Nombre",
                value: "15:10 a 15:50");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 19,
                column: "Nombre",
                value: "15:50 a 16:00");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 20,
                column: "Nombre",
                value: "15:50 a 16:10");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 21,
                column: "Nombre",
                value: "16:00 a 16:40");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 22,
                column: "Nombre",
                value: "16:10 a 16:50");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 23,
                column: "Nombre",
                value: "16:40 a 17:20");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 24,
                column: "Nombre",
                value: "16:50 a 17:30");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 25,
                column: "Nombre",
                value: "17:20 a 18:00");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 26,
                column: "Nombre",
                value: "17:30 a 18:10");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 27,
                column: "Nombre",
                value: "18:00 a 18:40");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 28,
                column: "Nombre",
                value: "18:10 a 18:50");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 29,
                column: "Nombre",
                value: "18:40 a 19:20");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 30,
                column: "Nombre",
                value: "18:50 a 19:30");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 31,
                column: "Nombre",
                value: "19:00 a 19:40");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 32,
                column: "Nombre",
                value: "19:20 a 20:00");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 33,
                column: "Nombre",
                value: "19:30 a 19:40");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 34,
                column: "Nombre",
                value: "19:40 a 20:20");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 35,
                column: "Nombre",
                value: "20:00 a 20:40");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 36,
                column: "Nombre",
                value: "20:20 a 21:00");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 37,
                column: "Nombre",
                value: "20:40 a 21:20");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 38,
                column: "Nombre",
                value: "21:00 a 21:40");

            migrationBuilder.UpdateData(
                table: "horas",
                keyColumn: "Id",
                keyValue: 39,
                column: "Nombre",
                value: "21:20 a 22:00");

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 7, 8, 51, 4, 716, DateTimeKind.Local).AddTicks(4731));
        }
    }
}
