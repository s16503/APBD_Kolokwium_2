using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Kolokwium_2.Migrations
{
    public partial class SeedBazy2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists_Events",
                keyColumns: new[] { "IdEvent", "IdArtist" },
                keyValues: new object[] { 1, 1 },
                column: "PerformanceDate",
                value: new DateTime(2020, 6, 20, 14, 10, 12, 592, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Artists_Events",
                keyColumns: new[] { "IdEvent", "IdArtist" },
                keyValues: new object[] { 1, 2 },
                column: "PerformanceDate",
                value: new DateTime(2020, 6, 21, 14, 10, 12, 592, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "IdEvent",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 24, 14, 10, 12, 587, DateTimeKind.Local).AddTicks(9136), new DateTime(2020, 6, 19, 14, 10, 12, 583, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "IdEvent", "EndDate", "Name", "StartDate" },
                values: new object[] { 2, new DateTime(2020, 7, 19, 14, 10, 12, 587, DateTimeKind.Local).AddTicks(9938), "Festiwal muzyki Giżycko", new DateTime(2020, 7, 9, 14, 10, 12, 587, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.InsertData(
                table: "Artists_Events",
                columns: new[] { "IdEvent", "IdArtist", "PerformanceDate" },
                values: new object[] { 2, 1, new DateTime(2020, 7, 10, 14, 10, 12, 592, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.InsertData(
                table: "Events_Organisers",
                columns: new[] { "IdEvent", "IdOrganiser" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists_Events",
                keyColumns: new[] { "IdEvent", "IdArtist" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Events_Organisers",
                keyColumns: new[] { "IdEvent", "IdOrganiser" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "IdEvent",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Artists_Events",
                keyColumns: new[] { "IdEvent", "IdArtist" },
                keyValues: new object[] { 1, 1 },
                column: "PerformanceDate",
                value: new DateTime(2020, 6, 20, 13, 45, 29, 741, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Artists_Events",
                keyColumns: new[] { "IdEvent", "IdArtist" },
                keyValues: new object[] { 1, 2 },
                column: "PerformanceDate",
                value: new DateTime(2020, 6, 21, 13, 45, 29, 741, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "IdEvent",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 24, 13, 45, 29, 737, DateTimeKind.Local).AddTicks(6806), new DateTime(2020, 6, 19, 13, 45, 29, 730, DateTimeKind.Local).AddTicks(450) });
        }
    }
}
