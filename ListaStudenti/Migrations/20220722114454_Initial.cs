﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaStudenti.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studenti",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnStudiu = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "StudentID", "AnStudiu", "Nota", "Nume" },
                values: new object[] { 1, 1, 8, "Iosif Bodnar" });

            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "StudentID", "AnStudiu", "Nota", "Nume" },
                values: new object[] { 2, 2, 7, "Carmen Tanase" });

            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "StudentID", "AnStudiu", "Nota", "Nume" },
                values: new object[] { 3, 3, 10, "Adela Borogean" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studenti");
        }
    }
}
