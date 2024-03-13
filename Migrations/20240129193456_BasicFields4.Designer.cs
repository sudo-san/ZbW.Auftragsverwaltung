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
    [Migration("20240129193456_BasicFields4")]
    partial class BasicFields4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Auftragsverwaltung.Artikel", b =>
                {
                    b.Property<int>("ArtikelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtikelID"));

                    b.Property<int>("Artikelgruppe")
                        .HasColumnType("int");

                    b.Property<string>("Artikelname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Artikelnummer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtikelID");

                    b.ToTable("Artikel");
                });

            modelBuilder.Entity("Auftragsverwaltung.Auftrag", b =>
                {
                    b.Property<int>("KundeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KundeID"));

                    b.Property<int>("Auftragsnummer")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KundenId")
                        .HasColumnType("int");

                    b.Property<int>("KundenNr")
                        .HasColumnType("int");

                    b.HasKey("KundeID");

                    b.HasIndex("KundenNr");

                    b.ToTable("Auftrageblablabd");
                });

            modelBuilder.Entity("Auftragsverwaltung.Kunde", b =>
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

            modelBuilder.Entity("Auftragsverwaltung.Auftrag", b =>
                {
                    b.HasOne("Auftragsverwaltung.Kunde", "Kunde")
                        .WithMany("Auftraege")
                        .HasForeignKey("KundenNr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kunde");
                });

            modelBuilder.Entity("Auftragsverwaltung.Kunde", b =>
                {
                    b.Navigation("Auftraege");
                });
#pragma warning restore 612, 618
        }
    }
}
