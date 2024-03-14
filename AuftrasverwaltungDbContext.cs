using Auftragsverwaltung.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragsverwaltung
{

    public class AuftragsverwaltungDbContext : DbContext
    {
        public AuftragsverwaltungDbContext():base() { }
        
        public DbSet<Kunde> Kunde {  get; set; }
        public DbSet<Adresse> Adresse { get; set; }
        public DbSet<Auftrag> Auftrag {  get; set; }
        public DbSet<Auftragsposition> Auftragsposition { get; set; }
        public DbSet<Artikel> Artikel { get; set; }
        public DbSet<Artikelgruppe> Artikelgruppe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // ConnectionString der verwendet werden soll
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Auftragsverwaltung"));
            
            // Logging
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresse>()
                .HasOne(a => a.Kunde)
                .WithMany(k => k.Adressen)
                .HasForeignKey(a => a.KundeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Artikelgruppe>()
                .HasOne(ag => ag.UebergeordneteGruppe)
                .WithMany() 
                .OnDelete(DeleteBehavior.ClientSetNull);
        }

    }
}
