using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auftragsverwaltung.Migrations
{
    /// <inheritdoc />
    public partial class AddingAdditionalFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auftrageblablabd");

            migrationBuilder.DropColumn(
                name: "Artikelnummer",
                table: "Artikel");

            migrationBuilder.RenameColumn(
                name: "Artikelname",
                table: "Artikel",
                newName: "Bezeichnung");

            migrationBuilder.RenameColumn(
                name: "Artikelgruppe",
                table: "Artikel",
                newName: "ArtikelgruppeID");

            migrationBuilder.RenameColumn(
                name: "ArtikelID",
                table: "Artikel",
                newName: "ArtikelNr");

            migrationBuilder.AddColumn<decimal>(
                name: "Preis",
                table: "Artikel",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Adresse",
                columns: table => new
                {
                    AdresseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strasse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KundeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresse", x => x.AdresseID);
                    table.ForeignKey(
                        name: "FK_Adresse_Kunde_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunde",
                        principalColumn: "KundenNr");
                });

            migrationBuilder.CreateTable(
                name: "Artikelgruppe",
                columns: table => new
                {
                    ArtikelgruppeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UebergeordneteGruppeArtikelgruppeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikelgruppe", x => x.ArtikelgruppeID);
                    table.ForeignKey(
                        name: "FK_Artikelgruppe_Artikelgruppe_UebergeordneteGruppeArtikelgruppeID",
                        column: x => x.UebergeordneteGruppeArtikelgruppeID,
                        principalTable: "Artikelgruppe",
                        principalColumn: "ArtikelgruppeID");
                });

            migrationBuilder.CreateTable(
                name: "Auftrag",
                columns: table => new
                {
                    Auftragsnummer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KundenId = table.Column<int>(type: "int", nullable: false),
                    KundenNr = table.Column<int>(type: "int", nullable: false),
                    AdresseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auftrag", x => x.Auftragsnummer);
                    table.ForeignKey(
                        name: "FK_Auftrag_Adresse_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresse",
                        principalColumn: "AdresseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Auftrag_Kunde_KundenNr",
                        column: x => x.KundenNr,
                        principalTable: "Kunde",
                        principalColumn: "KundenNr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auftragsposition",
                columns: table => new
                {
                    AuftragspositionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtikelID = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Anzahl = table.Column<int>(type: "int", nullable: false),
                    Preis = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Auftragsnummer = table.Column<int>(type: "int", nullable: false),
                    Auftragsnummer1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auftragsposition", x => x.AuftragspositionID);
                    table.ForeignKey(
                        name: "FK_Auftragsposition_Auftrag_Auftragsnummer1",
                        column: x => x.Auftragsnummer1,
                        principalTable: "Auftrag",
                        principalColumn: "Auftragsnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikel_ArtikelgruppeID",
                table: "Artikel",
                column: "ArtikelgruppeID");

            migrationBuilder.CreateIndex(
                name: "IX_Adresse_KundeId",
                table: "Adresse",
                column: "KundeId");

            migrationBuilder.CreateIndex(
                name: "IX_Artikelgruppe_UebergeordneteGruppeArtikelgruppeID",
                table: "Artikelgruppe",
                column: "UebergeordneteGruppeArtikelgruppeID");

            migrationBuilder.CreateIndex(
                name: "IX_Auftrag_AdresseId",
                table: "Auftrag",
                column: "AdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_Auftrag_KundenNr",
                table: "Auftrag",
                column: "KundenNr");

            migrationBuilder.CreateIndex(
                name: "IX_Auftragsposition_Auftragsnummer1",
                table: "Auftragsposition",
                column: "Auftragsnummer1");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikel_Artikelgruppe_ArtikelgruppeID",
                table: "Artikel",
                column: "ArtikelgruppeID",
                principalTable: "Artikelgruppe",
                principalColumn: "ArtikelgruppeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikel_Artikelgruppe_ArtikelgruppeID",
                table: "Artikel");

            migrationBuilder.DropTable(
                name: "Artikelgruppe");

            migrationBuilder.DropTable(
                name: "Auftragsposition");

            migrationBuilder.DropTable(
                name: "Auftrag");

            migrationBuilder.DropTable(
                name: "Adresse");

            migrationBuilder.DropIndex(
                name: "IX_Artikel_ArtikelgruppeID",
                table: "Artikel");

            migrationBuilder.DropColumn(
                name: "Preis",
                table: "Artikel");

            migrationBuilder.RenameColumn(
                name: "Bezeichnung",
                table: "Artikel",
                newName: "Artikelname");

            migrationBuilder.RenameColumn(
                name: "ArtikelgruppeID",
                table: "Artikel",
                newName: "Artikelgruppe");

            migrationBuilder.RenameColumn(
                name: "ArtikelNr",
                table: "Artikel",
                newName: "ArtikelID");

            migrationBuilder.AddColumn<string>(
                name: "Artikelnummer",
                table: "Artikel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Auftrageblablabd",
                columns: table => new
                {
                    KundeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KundenNr = table.Column<int>(type: "int", nullable: false),
                    Auftragsnummer = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KundenId = table.Column<int>(type: "int", nullable: false)
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
    }
}
