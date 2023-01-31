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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Omschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBand");

                    b.ToTable("bands");
                });

            modelBuilder.Entity("Gebruiker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotaleDonatie")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Gebruiker");

                    b.UseTphMappingStrategy();
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RuimteNr")
                        .HasColumnType("int");

                    b.Property<int>("VerhuurdeId")
                        .HasColumnType("int");

                    b.Property<int?>("Zaalnr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("reserveringen");
                });

            modelBuilder.Entity("Leden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Review", b =>
                {
                    b.Property<int>("reviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reviewId"));

                    b.Property<int>("Show")
                        .HasColumnType("int");

                    b.Property<string>("reviewtekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("reviewId");

                    b.ToTable("Review");
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

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expiration")
                        .HasColumnType("datetime2");

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
                            BeginTijd = new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4615),
                            EindTijd = new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4656),
                            Genre = 1,
                            Leeftijdsgroep = 1,
                            Naam = "Show 1",
                            Zaal = 1
                        },
                        new
                        {
                            Shownr = 2,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4661),
                            EindTijd = new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4662),
                            Genre = 2,
                            Leeftijdsgroep = 2,
                            Naam = "Show 2",
                            Zaal = 2
                        },
                        new
                        {
                            Shownr = 3,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4666),
                            EindTijd = new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4668),
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

                    b.Property<int>("Rang")
                        .HasColumnType("int");

                    b.Property<int>("Shownr")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stoelNr")
                        .HasColumnType("int");

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

                    b.Property<int?>("LedenId")
                        .HasColumnType("int");

                    b.Property<string>("artiest_naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("LedenId");

                    b.HasDiscriminator().HasValue("Artiest");
                });

            modelBuilder.Entity("Donateur", b =>
                {
                    b.HasBaseType("Gebruiker");

                    b.HasDiscriminator().HasValue("Donateur");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
