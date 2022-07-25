﻿// <auto-generated />
using System;
using ListaStudenti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ListaStudenti.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20220722114454_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ListaStudenti.Models.student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AnStudiu")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Nota")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Studenti");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            AnStudiu = 1,
                            Nota = 8,
                            Nume = "Iosif Bodnar"
                        },
                        new
                        {
                            StudentID = 2,
                            AnStudiu = 2,
                            Nota = 7,
                            Nume = "Carmen Tanase"
                        },
                        new
                        {
                            StudentID = 3,
                            AnStudiu = 3,
                            Nota = 10,
                            Nume = "Adela Borogean"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}