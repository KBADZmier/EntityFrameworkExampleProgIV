﻿// <auto-generated />
using System;
using EntityFramework.Dane;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFramework.Migrations
{
    [DbContext(typeof(KadryContext))]
    [Migration("20230506180902_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFramework.Tabele.Dzial", b =>
                {
                    b.Property<int>("ID_Dzial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Dzial"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Dzial");

                    b.ToTable("Dzial");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Place", b =>
                {
                    b.Property<int>("ID_Place")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Place"));

                    b.Property<int>("ID_Pracownika")
                        .HasColumnType("int");

                    b.Property<double>("Stawka_Godzinowa")
                        .HasColumnType("float");

                    b.Property<double>("Wyplata_Brutto")
                        .HasColumnType("float");

                    b.Property<double>("Wyplata_Netto")
                        .HasColumnType("float");

                    b.Property<int>("pracownikID_Pracownik")
                        .HasColumnType("int");

                    b.HasKey("ID_Place");

                    b.HasIndex("pracownikID_Pracownik");

                    b.ToTable("Place");
                });

            modelBuilder.Entity("EntityFramework.Tabele.PosiadanyStatus", b =>
                {
                    b.Property<int>("ID_Pracownika")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Pracownika"));

                    b.Property<DateTime>("Data_do")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_od")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_Status")
                        .HasColumnType("int");

                    b.Property<int>("PracownikRefId")
                        .HasColumnType("int");

                    b.Property<int>("StatusRefId")
                        .HasColumnType("int");

                    b.HasKey("ID_Pracownika");

                    b.HasIndex("PracownikRefId")
                        .IsUnique();

                    b.HasIndex("StatusRefId")
                        .IsUnique();

                    b.ToTable("PosiadanyStatus");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Pracownik", b =>
                {
                    b.Property<int>("ID_Pracownik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Pracownik"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_urodzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nr_konta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon_kontaktowy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Pracownik");

                    b.ToTable("Pracownik");
                });

            modelBuilder.Entity("EntityFramework.Tabele.PrzepracowanyCzas", b =>
                {
                    b.Property<int>("ID_Przpracowny")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Przpracowny"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<double>("Ilosc_Godzin")
                        .HasColumnType("float");

                    b.Property<int>("pracownikID_Pracownik")
                        .HasColumnType("int");

                    b.HasKey("ID_Przpracowny");

                    b.HasIndex("pracownikID_Pracownik");

                    b.ToTable("PrzepracowanyCzas");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Skladki", b =>
                {
                    b.Property<int>("ID_Skladki")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Skladki"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_Place")
                        .HasColumnType("int");

                    b.Property<string>("Rodzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Wielkosc")
                        .HasColumnType("float");

                    b.Property<int>("placeID_Place")
                        .HasColumnType("int");

                    b.HasKey("ID_Skladki");

                    b.HasIndex("placeID_Place");

                    b.ToTable("Skladki");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Status", b =>
                {
                    b.Property<int>("ID_Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Status"));

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Status");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Szkolenia", b =>
                {
                    b.Property<int>("ID_Szkolenia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Szkolenia"));

                    b.Property<DateTime>("Data_Szkolenia")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_Pracownika")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa_Szkolenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pracownikID_Pracownik")
                        .HasColumnType("int");

                    b.HasKey("ID_Szkolenia");

                    b.HasIndex("pracownikID_Pracownik");

                    b.ToTable("Szkolenia");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Zatrudnienie", b =>
                {
                    b.Property<int?>("ID_pracownika")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID_pracownika"));

                    b.Property<DateTime>("Data_do")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_od")
                        .HasColumnType("datetime2");

                    b.Property<int>("DzialRefId")
                        .HasColumnType("int");

                    b.Property<int?>("ID_Dzial")
                        .HasColumnType("int");

                    b.Property<int>("PracownikRefId")
                        .HasColumnType("int");

                    b.Property<string>("Stanowisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_pracownika");

                    b.HasIndex("DzialRefId")
                        .IsUnique();

                    b.HasIndex("PracownikRefId")
                        .IsUnique();

                    b.ToTable("Zatrudnienie");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Place", b =>
                {
                    b.HasOne("EntityFramework.Tabele.Pracownik", "pracownik")
                        .WithMany("place")
                        .HasForeignKey("pracownikID_Pracownik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pracownik");
                });

            modelBuilder.Entity("EntityFramework.Tabele.PosiadanyStatus", b =>
                {
                    b.HasOne("EntityFramework.Tabele.Pracownik", "pracownik")
                        .WithOne("posiadanyStatus")
                        .HasForeignKey("EntityFramework.Tabele.PosiadanyStatus", "PracownikRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework.Tabele.Status", "status")
                        .WithOne("posiadanyStatus")
                        .HasForeignKey("EntityFramework.Tabele.PosiadanyStatus", "StatusRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pracownik");

                    b.Navigation("status");
                });

            modelBuilder.Entity("EntityFramework.Tabele.PrzepracowanyCzas", b =>
                {
                    b.HasOne("EntityFramework.Tabele.Pracownik", "pracownik")
                        .WithMany("przepracowanyCzas")
                        .HasForeignKey("pracownikID_Pracownik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pracownik");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Skladki", b =>
                {
                    b.HasOne("EntityFramework.Tabele.Place", "place")
                        .WithMany("skladki")
                        .HasForeignKey("placeID_Place")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("place");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Szkolenia", b =>
                {
                    b.HasOne("EntityFramework.Tabele.Pracownik", "pracownik")
                        .WithMany("szkolenia")
                        .HasForeignKey("pracownikID_Pracownik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pracownik");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Zatrudnienie", b =>
                {
                    b.HasOne("EntityFramework.Tabele.Dzial", "dzial")
                        .WithOne("zatrudnienie")
                        .HasForeignKey("EntityFramework.Tabele.Zatrudnienie", "DzialRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework.Tabele.Pracownik", "pracownik")
                        .WithOne("zatrudnienie")
                        .HasForeignKey("EntityFramework.Tabele.Zatrudnienie", "PracownikRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dzial");

                    b.Navigation("pracownik");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Dzial", b =>
                {
                    b.Navigation("zatrudnienie")
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFramework.Tabele.Place", b =>
                {
                    b.Navigation("skladki");
                });

            modelBuilder.Entity("EntityFramework.Tabele.Pracownik", b =>
                {
                    b.Navigation("place");

                    b.Navigation("posiadanyStatus")
                        .IsRequired();

                    b.Navigation("przepracowanyCzas");

                    b.Navigation("szkolenia");

                    b.Navigation("zatrudnienie")
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFramework.Tabele.Status", b =>
                {
                    b.Navigation("posiadanyStatus")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
