using EntityFramework.Tabele;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EntityFramework.Dane
{
  public class KadryContext : DbContext
    {
        public KadryContext()
    {
    }

    public KadryContext(DbContextOptions<KadryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pracownik> pracownik { get; set; }
    public virtual DbSet<Dzial> dzial { get; set; }
    public virtual DbSet<Place> place { get; set; }
    public virtual DbSet<PosiadanyStatus> posiadanyStatus { get; set; }
    public virtual DbSet<PrzepracowanyCzas> przepracowanyCzas { get; set; }

    public virtual DbSet<Skladki> skladki { get; set; }
    public virtual DbSet<Status> status { get; set; }
    public virtual DbSet<Szkolenia> szkolenia { get; set; }
    public virtual DbSet<Zatrudnienie> zatrudnienie { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Kadry;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

               modelBuilder.Entity<Pracownik>()
            .HasMany(e => e.szkolenia)
            .WithOne(e => e.pracownik);

            modelBuilder.Entity<Pracownik>()
          .HasMany(e => e.przepracowanyCzas)
          .WithOne(e => e.pracownik);

            modelBuilder.Entity<Pracownik>()
          .HasMany(e => e.place)
          .WithOne(e => e.pracownik);


            modelBuilder.Entity<Pracownik>()
          .HasOne(e => e.zatrudnienie)
          .WithOne(e => e.pracownik);


            modelBuilder.Entity<Dzial>()
      .HasOne(e => e.zatrudnienie)
      .WithOne(e => e.dzial);

            modelBuilder.Entity<Place>()
            .HasMany(e => e.skladki)
            .WithOne(e => e.place);

            modelBuilder.Entity<Place>()
       .HasMany(e => e.skladki)
       .WithOne(e => e.place);

            modelBuilder.Entity<Pracownik>()
            .HasOne(e => e.posiadanyStatus)
            .WithOne(e => e.pracownik);
           
            modelBuilder.Entity<Status>()
            .HasOne(e => e.posiadanyStatus)
            .WithOne(e => e.status);



        }
}
}

