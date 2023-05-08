using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dzial",
                columns: table => new
                {
                    ID_Dzial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dzial", x => x.ID_Dzial);
                });

            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    ID_Pracownik = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_urodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nr_konta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon_kontaktowy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownik", x => x.ID_Pracownik);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID_Status = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID_Status);
                });

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    ID_Place = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Pracownika = table.Column<int>(type: "int", nullable: false),
                    Stawka_Godzinowa = table.Column<double>(type: "float", nullable: false),
                    Wyplata_Netto = table.Column<double>(type: "float", nullable: false),
                    Wyplata_Brutto = table.Column<double>(type: "float", nullable: false),
                    pracownikID_Pracownik = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.ID_Place);
                    table.ForeignKey(
                        name: "FK_Place_Pracownik_pracownikID_Pracownik",
                        column: x => x.pracownikID_Pracownik,
                        principalTable: "Pracownik",
                        principalColumn: "ID_Pracownik",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrzepracowanyCzas",
                columns: table => new
                {
                    ID_Przpracowny = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ilosc_Godzin = table.Column<double>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pracownikID_Pracownik = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrzepracowanyCzas", x => x.ID_Przpracowny);
                    table.ForeignKey(
                        name: "FK_PrzepracowanyCzas_Pracownik_pracownikID_Pracownik",
                        column: x => x.pracownikID_Pracownik,
                        principalTable: "Pracownik",
                        principalColumn: "ID_Pracownik",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Szkolenia",
                columns: table => new
                {
                    ID_Szkolenia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Pracownika = table.Column<int>(type: "int", nullable: false),
                    Nazwa_Szkolenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Szkolenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pracownikID_Pracownik = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szkolenia", x => x.ID_Szkolenia);
                    table.ForeignKey(
                        name: "FK_Szkolenia_Pracownik_pracownikID_Pracownik",
                        column: x => x.pracownikID_Pracownik,
                        principalTable: "Pracownik",
                        principalColumn: "ID_Pracownik",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zatrudnienie",
                columns: table => new
                {
                    ID_pracownika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Dzial = table.Column<int>(type: "int", nullable: true),
                    Stanowisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_od = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_do = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikRefId = table.Column<int>(type: "int", nullable: false),
                    DzialRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zatrudnienie", x => x.ID_pracownika);
                    table.ForeignKey(
                        name: "FK_Zatrudnienie_Dzial_DzialRefId",
                        column: x => x.DzialRefId,
                        principalTable: "Dzial",
                        principalColumn: "ID_Dzial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zatrudnienie_Pracownik_PracownikRefId",
                        column: x => x.PracownikRefId,
                        principalTable: "Pracownik",
                        principalColumn: "ID_Pracownik",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosiadanyStatus",
                columns: table => new
                {
                    ID_Pracownika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Status = table.Column<int>(type: "int", nullable: false),
                    Data_od = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_do = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikRefId = table.Column<int>(type: "int", nullable: false),
                    StatusRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosiadanyStatus", x => x.ID_Pracownika);
                    table.ForeignKey(
                        name: "FK_PosiadanyStatus_Pracownik_PracownikRefId",
                        column: x => x.PracownikRefId,
                        principalTable: "Pracownik",
                        principalColumn: "ID_Pracownik",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PosiadanyStatus_Status_StatusRefId",
                        column: x => x.StatusRefId,
                        principalTable: "Status",
                        principalColumn: "ID_Status",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skladki",
                columns: table => new
                {
                    ID_Skladki = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Place = table.Column<int>(type: "int", nullable: false),
                    Rodzaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wielkosc = table.Column<double>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    placeID_Place = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladki", x => x.ID_Skladki);
                    table.ForeignKey(
                        name: "FK_Skladki_Place_placeID_Place",
                        column: x => x.placeID_Place,
                        principalTable: "Place",
                        principalColumn: "ID_Place",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Place_pracownikID_Pracownik",
                table: "Place",
                column: "pracownikID_Pracownik");

            migrationBuilder.CreateIndex(
                name: "IX_PosiadanyStatus_PracownikRefId",
                table: "PosiadanyStatus",
                column: "PracownikRefId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PosiadanyStatus_StatusRefId",
                table: "PosiadanyStatus",
                column: "StatusRefId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrzepracowanyCzas_pracownikID_Pracownik",
                table: "PrzepracowanyCzas",
                column: "pracownikID_Pracownik");

            migrationBuilder.CreateIndex(
                name: "IX_Skladki_placeID_Place",
                table: "Skladki",
                column: "placeID_Place");

            migrationBuilder.CreateIndex(
                name: "IX_Szkolenia_pracownikID_Pracownik",
                table: "Szkolenia",
                column: "pracownikID_Pracownik");

            migrationBuilder.CreateIndex(
                name: "IX_Zatrudnienie_DzialRefId",
                table: "Zatrudnienie",
                column: "DzialRefId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zatrudnienie_PracownikRefId",
                table: "Zatrudnienie",
                column: "PracownikRefId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PosiadanyStatus");

            migrationBuilder.DropTable(
                name: "PrzepracowanyCzas");

            migrationBuilder.DropTable(
                name: "Skladki");

            migrationBuilder.DropTable(
                name: "Szkolenia");

            migrationBuilder.DropTable(
                name: "Zatrudnienie");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Place");

            migrationBuilder.DropTable(
                name: "Dzial");

            migrationBuilder.DropTable(
                name: "Pracownik");
        }
    }
}
