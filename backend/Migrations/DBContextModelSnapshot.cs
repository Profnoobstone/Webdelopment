﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Band", b =>
                {
                    b.Property<int>("IdBand")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBand"));

                    b.Property<string>("Afbeelding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Omschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBand");

                    b.ToTable("bands");
                });

            modelBuilder.Entity("Gebruiker", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("gebruikers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Gebruiker");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            UserID = 2,
                            Email = "test2@email.com",
                            Naam = "Jan2",
                            Username = "Jan2",
                            Wachtwoord = "Test2"
                        },
                        new
                        {
                            UserID = 3,
                            Email = "test3@email.com",
                            Naam = "Jan3",
                            Username = "Jan3",
                            Wachtwoord = "Test3"
                        },
                        new
                        {
                            UserID = 4,
                            Email = "test4@email.com",
                            Naam = "Jan4",
                            Username = "Jan4",
                            Wachtwoord = "Test4"
                        });
                });

            modelBuilder.Entity("Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreID"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("genres");

                    b.HasData(
                        new
                        {
                            GenreID = 1,
                            Naam = "Horror"
                        },
                        new
                        {
                            GenreID = 2,
                            Naam = "Comedy"
                        },
                        new
                        {
                            GenreID = 3,
                            Naam = "Drama"
                        },
                        new
                        {
                            GenreID = 4,
                            Naam = "Action"
                        },
                        new
                        {
                            GenreID = 5,
                            Naam = "Romance"
                        },
                        new
                        {
                            GenreID = 6,
                            Naam = "Adventure"
                        },
                        new
                        {
                            GenreID = 7,
                            Naam = "Mystery"
                        },
                        new
                        {
                            GenreID = 8,
                            Naam = "Family"
                        },
                        new
                        {
                            GenreID = 9,
                            Naam = "Music"
                        },
                        new
                        {
                            GenreID = 10,
                            Naam = "History"
                        },
                        new
                        {
                            GenreID = 11,
                            Naam = "War"
                        },
                        new
                        {
                            GenreID = 12,
                            Naam = "Western"
                        },
                        new
                        {
                            GenreID = 13,
                            Naam = "Sport"
                        });
                });

            modelBuilder.Entity("Huren", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RuimteNr")
                        .HasColumnType("int");

                    b.Property<string>("VerhuurdeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Zaalnr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("reserveringen");
                });

            modelBuilder.Entity("Leden", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BandId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("leden");
                });

            modelBuilder.Entity("Leeftijdsgroep", b =>
                {
                    b.Property<int>("LeeftijdsgroepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeeftijdsgroepID"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeeftijdsgroepID");

                    b.ToTable("leeftijdsgroepen");

                    b.HasData(
                        new
                        {
                            LeeftijdsgroepID = 1,
                            Naam = "Alle leeftijden"
                        },
                        new
                        {
                            LeeftijdsgroepID = 2,
                            Naam = "Onder de 18"
                        },
                        new
                        {
                            LeeftijdsgroepID = 3,
                            Naam = "18-65"
                        },
                        new
                        {
                            LeeftijdsgroepID = 4,
                            Naam = "65+"
                        });
                });

            modelBuilder.Entity("Ruimte", b =>
                {
                    b.Property<int>("RuimteNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RuimteNr"));

                    b.Property<int>("Capaciteit")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RuimteNr");

                    b.ToTable("ruimtes");

                    b.HasData(
                        new
                        {
                            RuimteNr = 1,
                            Capaciteit = 30,
                            Naam = "Ruimte 1"
                        },
                        new
                        {
                            RuimteNr = 2,
                            Capaciteit = 30,
                            Naam = "Ruimte 2"
                        },
                        new
                        {
                            RuimteNr = 3,
                            Capaciteit = 30,
                            Naam = "Ruimte 3"
                        },
                        new
                        {
                            RuimteNr = 4,
                            Capaciteit = 30,
                            Naam = "Ruimte 4"
                        },
                        new
                        {
                            RuimteNr = 5,
                            Capaciteit = 30,
                            Naam = "Ruimte 5"
                        },
                        new
                        {
                            RuimteNr = 6,
                            Capaciteit = 30,
                            Naam = "Ruimte 6"
                        },
                        new
                        {
                            RuimteNr = 7,
                            Capaciteit = 30,
                            Naam = "Ruimte 7"
                        },
                        new
                        {
                            RuimteNr = 8,
                            Capaciteit = 30,
                            Naam = "Ruimte 8"
                        },
                        new
                        {
                            RuimteNr = 9,
                            Capaciteit = 30,
                            Naam = "Ruimte 9"
                        },
                        new
                        {
                            RuimteNr = 10,
                            Capaciteit = 30,
                            Naam = "Ruimte 10"
                        });
                });

            modelBuilder.Entity("SessionId", b =>
                {
                    b.Property<string>("Session")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("ticketData")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Session");

                    b.ToTable("sessionIds");
                });

            modelBuilder.Entity("Show", b =>
                {
                    b.Property<int>("Shownr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shownr"));

                    b.Property<string>("Afbeelding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BeginTijd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EindTijd")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Genre")
                        .HasColumnType("int");

                    b.Property<int?>("Leeftijdsgroep")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Zaal")
                        .HasColumnType("int");

                    b.HasKey("Shownr");

                    b.ToTable("shows");

                    b.HasData(
                        new
                        {
                            Shownr = 1,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6910),
                            EindTijd = new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6947),
                            Genre = 1,
                            Leeftijdsgroep = 1,
                            Naam = "Show 1",
                            Zaal = 1
                        },
                        new
                        {
                            Shownr = 2,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6951),
                            EindTijd = new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6953),
                            Genre = 2,
                            Leeftijdsgroep = 2,
                            Naam = "Show 2",
                            Zaal = 2
                        },
                        new
                        {
                            Shownr = 3,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6956),
                            EindTijd = new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6958),
                            Genre = 3,
                            Leeftijdsgroep = 3,
                            Naam = "Show 3",
                            Zaal = 3
                        });
                });

            modelBuilder.Entity("Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketID"));

                    b.Property<int>("Shownr")
                        .HasColumnType("int");

                    b.Property<string>("stoelNr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketID");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("Zaal", b =>
                {
                    b.Property<int>("Zaalnr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Zaalnr"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rang1")
                        .HasColumnType("int");

                    b.Property<int?>("Rang2")
                        .HasColumnType("int");

                    b.Property<int?>("Rang3")
                        .HasColumnType("int");

                    b.Property<int?>("Rang4")
                        .HasColumnType("int");

                    b.Property<int?>("invalideplaatsen")
                        .HasColumnType("int");

                    b.HasKey("Zaalnr");

                    b.ToTable("zalen");

                    b.HasData(
                        new
                        {
                            Zaalnr = 1,
                            Naam = "Zaal 1",
                            Rang1 = 120,
                            Rang2 = 98,
                            Rang3 = 20,
                            invalideplaatsen = 2
                        },
                        new
                        {
                            Zaalnr = 2,
                            Naam = "Zaal 2",
                            Rang1 = 100,
                            Rang2 = 80
                        },
                        new
                        {
                            Zaalnr = 3,
                            Naam = "Zaal 3",
                            Rang1 = 30,
                            Rang2 = 30,
                            Rang3 = 20,
                            Rang4 = 10
                        },
                        new
                        {
                            Zaalnr = 4,
                            Naam = "Zaal 4",
                            Rang1 = 210,
                            Rang2 = 115,
                            Rang3 = 90,
                            Rang4 = 20,
                            invalideplaatsen = 5
                        });
                });

            modelBuilder.Entity("Artiest", b =>
                {
                    b.HasBaseType("Gebruiker");

                    b.Property<string>("LedenId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("artiest_naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("LedenId");

                    b.HasDiscriminator().HasValue("Artiest");

                    b.HasData(
                        new
                        {
                            UserID = 5,
                            Email = "artiestmail1@email.com",
                            Naam = "Artiest1",
                            Username = "Artiest1",
                            Wachtwoord = "Test1",
                            artiestnaam = "Artiest1"
                        },
                        new
                        {
                            UserID = 6,
                            Email = "artiestmail2@email.com",
                            Naam = "Artiest2",
                            Username = "Artiest2",
                            Wachtwoord = "Test2",
                            artiestnaam = "Artiest2"
                        },
                        new
                        {
                            UserID = 7,
                            Email = "artiestmail3@email.com",
                            Naam = "Artiest3",
                            Username = "Artiest3",
                            Wachtwoord = "Test3",
                            artiestnaam = "Artiest3"
                        },
                        new
                        {
                            UserID = 8,
                            Email = "artiestmail4@email.com",
                            Naam = "Artiest4",
                            Username = "Artiest4",
                            Wachtwoord = "Test4",
                            artiestnaam = "Artiest4"
                        },
                        new
                        {
                            UserID = 9,
                            Email = "artiestmail5@email.com",
                            Naam = "Artiest5",
                            Username = "Artiest5",
                            Wachtwoord = "Test5",
                            artiestnaam = "Artiest5"
                        });
                });

            modelBuilder.Entity("Donateur", b =>
                {
                    b.HasBaseType("Gebruiker");

                    b.Property<int>("TotaleDonatie")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Donateur");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Email = "test1@email.com",
                            Naam = "Jan1",
                            Username = "Jan1",
                            Wachtwoord = "Test1",
                            TotaleDonatie = 1000
                        });
                });

            modelBuilder.Entity("Artiest", b =>
                {
                    b.HasOne("Leden", null)
                        .WithMany("artiesten")
                        .HasForeignKey("LedenId");
                });

            modelBuilder.Entity("Leden", b =>
                {
                    b.Navigation("artiesten");
                });
#pragma warning restore 612, 618
        }
    }
}
