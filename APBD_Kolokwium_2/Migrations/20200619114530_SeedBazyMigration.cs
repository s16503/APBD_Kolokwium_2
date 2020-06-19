using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Kolokwium_2.Migrations
{
    public partial class SeedBazyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "IdArtist", "Nickname" },
                values: new object[,]
                {
                    { 1, "Kazik" },
                    { 2, "Madonna" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "IdEvent", "EndDate", "Name", "StartDate" },
                values: new object[] { 1, new DateTime(2020, 6, 24, 13, 45, 29, 737, DateTimeKind.Local).AddTicks(6806), "Opole 2020", new DateTime(2020, 6, 19, 13, 45, 29, 730, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.InsertData(
                table: "Organisers",
                columns: new[] { "IdOrganiser", "Name" },
                values: new object[] { 1, "Orange" });

            migrationBuilder.InsertData(
                table: "Artists_Events",
                columns: new[] { "IdEvent", "IdArtist", "PerformanceDate" },
                values: new object[] { 1, 1, new DateTime(2020, 6, 20, 13, 45, 29, 741, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.InsertData(
                table: "Artists_Events",
                columns: new[] { "IdEvent", "IdArtist", "PerformanceDate" },
                values: new object[] { 1, 2, new DateTime(2020, 6, 21, 13, 45, 29, 741, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.InsertData(
                table: "Events_Organisers",
                columns: new[] { "IdEvent", "IdOrganiser" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists_Events",
                keyColumns: new[] { "IdEvent", "IdArtist" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Artists_Events",
                keyColumns: new[] { "IdEvent", "IdArtist" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Events_Organisers",
                keyColumns: new[] { "IdEvent", "IdOrganiser" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "IdArtist",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "IdArtist",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "IdEvent",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organisers",
                keyColumn: "IdOrganiser",
                keyValue: 1);
        }
    }
}
