﻿// <auto-generated />
using System;
using Auftragsverwaltung;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Auftragsverwaltung.Migrations
{
    [DbContext(typeof(AuftragsverwaltungDbContext))]
    [Migration("20240314190223_AddingAdditionalFields")]
    partial class AddingAdditionalFields
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Auftragsverwaltung.Models.Adresse", b =>
                {
                    b.Property<int>("AdresseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdresseID"));

                    b.Property<int>("KundeId")
                        .HasColumnType("int");

                    b.Property<string>("Ort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLZ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strasse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresseID");

                    b.HasIndex("KundeId");

                    b.ToTable("Adresse");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Artikel", b =>
                {
                    b.Property<int>("ArtikelNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtikelNr"));

                    b.Property<int>("ArtikelgruppeID")
                        .HasColumnType("int");

                    b.Property<string>("Bezeichnung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preis")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ArtikelNr");

                    b.HasIndex("ArtikelgruppeID");

                    b.ToTable("Artikel");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Artikelgruppe", b =>
                {
                    b.Property<int>("ArtikelgruppeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtikelgruppeID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UebergeordneteGruppeArtikelgruppeID")
                        .HasColumnType("int");

                    b.HasKey("ArtikelgruppeID");

                    b.HasIndex("UebergeordneteGruppeArtikelgruppeID");

                    b.ToTable("Artikelgruppe");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Auftrag", b =>
                {
                    b.Property<int>("Auftragsnummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Auftragsnummer"));

                    b.Property<int>("AdresseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KundenId")
                        .HasColumnType("int");

                    b.Property<int>("KundenNr")
                        .HasColumnType("int");

                    b.HasKey("Auftragsnummer");

                    b.HasIndex("AdresseId");

                    b.HasIndex("KundenNr");

                    b.ToTable("Auftrag");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Auftragsposition", b =>
                {
                    b.Property<int>("AuftragspositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuftragspositionID"));

                    b.Property<int>("Anzahl")
                        .HasColumnType("int");

                    b.Property<int>("ArtikelID")
                        .HasColumnType("int");

                    b.Property<int>("Auftragsnummer")
                        .HasColumnType("int");

                    b.Property<int>("Auftragsnummer1")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<decimal>("Preis")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AuftragspositionID");

                    b.HasIndex("Auftragsnummer1");

                    b.ToTable("Auftragsposition");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Kunde", b =>
                {
                    b.Property<int>("KundenNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KundenNr"));

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nachname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passwort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vorname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KundenNr");

                    b.ToTable("Kunde");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Adresse", b =>
                {
                    b.HasOne("Auftragsverwaltung.Models.Kunde", "Kunde")
                        .WithMany("Adressen")
                        .HasForeignKey("KundeId")
                        .IsRequired();

                    b.Navigation("Kunde");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Artikel", b =>
                {
                    b.HasOne("Auftragsverwaltung.Models.Artikelgruppe", "Artikelgruppe")
                        .WithMany("Artikels")
                        .HasForeignKey("ArtikelgruppeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artikelgruppe");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Artikelgruppe", b =>
                {
                    b.HasOne("Auftragsverwaltung.Models.Artikelgruppe", "UebergeordneteGruppe")
                        .WithMany()
                        .HasForeignKey("UebergeordneteGruppeArtikelgruppeID")
                        .IsRequired();

                    b.Navigation("UebergeordneteGruppe");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Auftrag", b =>
                {
                    b.HasOne("Auftragsverwaltung.Models.Adresse", "Adresse")
                        .WithMany()
                        .HasForeignKey("AdresseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auftragsverwaltung.Models.Kunde", "Kunde")
                        .WithMany("Auftraege")
                        .HasForeignKey("KundenNr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adresse");

                    b.Navigation("Kunde");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Auftragsposition", b =>
                {
                    b.HasOne("Auftragsverwaltung.Models.Auftrag", "Auftrag")
                        .WithMany("Auftragspositionen")
                        .HasForeignKey("Auftragsnummer1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auftrag");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Artikelgruppe", b =>
                {
                    b.Navigation("Artikels");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Auftrag", b =>
                {
                    b.Navigation("Auftragspositionen");
                });

            modelBuilder.Entity("Auftragsverwaltung.Models.Kunde", b =>
                {
                    b.Navigation("Adressen");

                    b.Navigation("Auftraege");
                });
#pragma warning restore 612, 618
        }
    }
}
