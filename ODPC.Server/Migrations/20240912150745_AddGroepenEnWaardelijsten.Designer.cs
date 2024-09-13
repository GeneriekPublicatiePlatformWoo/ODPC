﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ODPC.Data;

#nullable disable

namespace ODPC.Migrations
{
    [DbContext(typeof(OdpcDbContext))]
    [Migration("20240912150745_AddGroepenEnWaardelijsten")]
    partial class AddGroepenEnWaardelijsten
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ODPC.Data.Entities.Gebruikersgroep", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Gebruikersgroepen");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d3da5277-ea07-4921-97b8-e9a181390c76"),
                            Name = "Groep 1"
                        },
                        new
                        {
                            Id = new Guid("8f939b51-dad3-436d-a5fa-495b42317d64"),
                            Name = "Groep 2"
                        },
                        new
                        {
                            Id = new Guid("0e7a0023-423a-421a-8700-359232fef584"),
                            Name = "Groep 3"
                        });
                });

            modelBuilder.Entity("ODPC.Data.Entities.GebruikersgroepWaardelijst", b =>
                {
                    b.Property<Guid>("GebruikersgroepId")
                        .HasColumnType("uuid");

                    b.Property<string>("WaardelijstId")
                        .HasColumnType("text");

                    b.HasKey("GebruikersgroepId", "WaardelijstId");

                    b.ToTable("GebruikersgroepWaardelijsten");
                });

            modelBuilder.Entity("ODPC.WeatherForecast", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("integer");

                    b.HasKey("Guid");

                    b.ToTable("WeatherForecasts");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("ab8d9c19-f14d-464a-937f-80ecedfa3ed4"),
                            Date = new DateOnly(2024, 9, 13),
                            Summary = "Mild",
                            TemperatureC = 20
                        },
                        new
                        {
                            Guid = new Guid("c6097727-f925-4b74-a720-da47e693a8f0"),
                            Date = new DateOnly(2024, 9, 14),
                            Summary = "Warm",
                            TemperatureC = 25
                        },
                        new
                        {
                            Guid = new Guid("b868204b-a2b7-40b7-a73f-a45da611c7d0"),
                            Date = new DateOnly(2024, 9, 15),
                            Summary = "Cool",
                            TemperatureC = 15
                        },
                        new
                        {
                            Guid = new Guid("456386b3-acc6-4883-847c-bee133a508f5"),
                            Date = new DateOnly(2024, 9, 16),
                            Summary = "Hot",
                            TemperatureC = 30
                        },
                        new
                        {
                            Guid = new Guid("9aea5478-2a85-4ebd-9abf-fb0d650b0ec8"),
                            Date = new DateOnly(2024, 9, 17),
                            Summary = "Chilly",
                            TemperatureC = 10
                        });
                });

            modelBuilder.Entity("ODPC.Data.Entities.GebruikersgroepWaardelijst", b =>
                {
                    b.HasOne("ODPC.Data.Entities.Gebruikersgroep", "Gebruikersgroep")
                        .WithMany()
                        .HasForeignKey("GebruikersgroepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gebruikersgroep");
                });
#pragma warning restore 612, 618
        }
    }
}