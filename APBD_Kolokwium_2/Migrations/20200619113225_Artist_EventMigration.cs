using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Kolokwium_2.Migrations
{
    public partial class Artist_EventMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists_Events",
                columns: table => new
                {
                    IdArtist = table.Column<int>(nullable: false),
                    IdEvent = table.Column<int>(nullable: false),
                    PerformanceDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists_Events", x => new { x.IdEvent, x.IdArtist });
                    table.ForeignKey(
                        name: "FK_Artists_Events_Artists_IdArtist",
                        column: x => x.IdArtist,
                        principalTable: "Artists",
                        principalColumn: "IdArtist",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artists_Events_Events_IdEvent",
                        column: x => x.IdEvent,
                        principalTable: "Events",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_Events_IdArtist",
                table: "Artists_Events",
                column: "IdArtist");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists_Events");
        }
    }
}
