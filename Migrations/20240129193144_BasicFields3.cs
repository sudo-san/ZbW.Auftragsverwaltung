using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auftragsverwaltung.Migrations
{
    /// <inheritdoc />
    public partial class BasicFields3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artikel",
                columns: table => new
                {
                    ArtikelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artikelgruppe = table.Column<int>(type: "int", nullable: false),
                    Artikelnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artikelname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikel", x => x.ArtikelID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artikel");
        }
    }
}
