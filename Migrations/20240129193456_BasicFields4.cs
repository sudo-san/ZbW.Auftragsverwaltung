using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auftragsverwaltung.Migrations
{
    /// <inheritdoc />
    public partial class BasicFields4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunde",
                columns: table => new
                {
                    KundenNr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passwort = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunde", x => x.KundenNr);
                });

            migrationBuilder.CreateTable(
                name: "Auftrageblablabd",
                columns: table => new
                {
                    KundeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Auftragsnummer = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KundenId = table.Column<int>(type: "int", nullable: false),
                    KundenNr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auftrageblablabd", x => x.KundeID);
                    table.ForeignKey(
                        name: "FK_Auftrageblablabd_Kunde_KundenNr",
                        column: x => x.KundenNr,
                        principalTable: "Kunde",
                        principalColumn: "KundenNr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auftrageblablabd_KundenNr",
                table: "Auftrageblablabd",
                column: "KundenNr");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auftrageblablabd");

            migrationBuilder.DropTable(
                name: "Kunde");
        }
    }
}
