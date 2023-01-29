﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230129104730_0")]
    partial class _0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

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

                    b.HasData(
                        new
                        {
                            Id = "c24d7dee-d214-4a07-bc18-ee175301c0e9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "97a6d0d1-885c-4aec-8b07-1353d9ee77bd",
                            Email = "test2@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Naam = "Jan2",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "17ffcf4c-dcdf-49ab-928c-5ee98875b9ae",
                            TwoFactorEnabled = false,
                            UserID = 2,
                            Wachtwoord = "Test2"
                        },
                        new
                        {
                            Id = "72460b90-c1e7-4033-880e-213709b26f20",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "58765d9a-4371-4ff8-9401-84532d74dad2",
                            Email = "test3@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Naam = "Jan3",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b02995b7-20ee-4480-bd6a-c63bfddc6065",
                            TwoFactorEnabled = false,
                            UserID = 3,
                            Wachtwoord = "Test3"
                        },
                        new
                        {
                            Id = "a244c26a-ee98-4fd7-af12-6207e8b54b6a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "79871082-cbee-4eaf-b278-a4348e237750",
                            Email = "test4@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Naam = "Jan4",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c3e6d05c-2618-47dc-a528-2effa1a3e9ab",
                            TwoFactorEnabled = false,
                            UserID = 4,
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
                            BeginTijd = new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7209),
                            EindTijd = new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7242),
                            Genre = 1,
                            Leeftijdsgroep = 1,
                            Naam = "Show 1",
                            Zaal = 1
                        },
                        new
                        {
                            Shownr = 2,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7245),
                            EindTijd = new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7247),
                            Genre = 2,
                            Leeftijdsgroep = 2,
                            Naam = "Show 2",
                            Zaal = 2
                        },
                        new
                        {
                            Shownr = 3,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7249),
                            EindTijd = new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7250),
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
                            Id = "417ca7f8-f0e3-4680-bc19-9213521a8f6e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "41eafd92-a97c-4ffe-9154-a99182e09471",
                            Email = "artiestmail1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Naam = "Artiest1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f219d035-0732-4176-9c6b-cca6b075136f",
                            TwoFactorEnabled = false,
                            UserID = 5,
                            Wachtwoord = "Test1",
                            artiestnaam = "Artiest1"
                        },
                        new
                        {
                            Id = "356ff5b6-4d93-4a39-b896-f984760effc7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "17585997-1872-4180-9fb7-538e0a8fb187",
                            Email = "artiestmail2@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Naam = "Artiest2",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6539edf2-592f-4501-b97d-bdee077f53dc",
                            TwoFactorEnabled = false,
                            UserID = 6,
                            Wachtwoord = "Test2",
                            artiestnaam = "Artiest2"
                        },
                        new
                        {
                            Id = "f82dbf8d-cf99-44c1-b4c3-2be386aa482d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "110e537c-feca-42cb-903c-bfb4fbffc2b1",
                            Email = "artiestmail3@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Naam = "Artiest3",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d8a30b10-ef88-4f15-adc2-70b0f8536b41",
                            TwoFactorEnabled = false,
                            UserID = 7,
                            Wachtwoord = "Test3",
                            artiestnaam = "Artiest3"
                        },
                        new
                        {
                            Id = "35d873e1-729b-4f4c-8153-7c246b17dc38",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "90dc1fa9-0afa-4b65-b8fe-0e712d202bdc",
                            Email = "artiestmail4@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Naam = "Artiest4",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd99516a-4dee-4e3c-a789-7ebd7afa3bc6",
                            TwoFactorEnabled = false,
                            UserID = 8,
                            Wachtwoord = "Test4",
                            artiestnaam = "Artiest4"
                        },
                        new
                        {
                            Id = "6b3d21ac-5292-4dee-b4cb-9edb67b38e88",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5942b8ab-96c9-4864-89e5-c30af260965f",
                            Email = "artiestmail5@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Naam = "Artiest5",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9aeaaaa-4361-4a16-ad08-8382fa17ccc7",
                            TwoFactorEnabled = false,
                            UserID = 9,
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
                            Id = "0a2fc4df-4156-4746-a5c9-f4d91cd7c503",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c044d82f-8f8a-4c6d-9bcd-77f259758e70",
                            Email = "test1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Naam = "Jan1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1e68f8c0-77ca-4cdb-87e6-86b73c2ad9b0",
                            TwoFactorEnabled = false,
                            UserID = 1,
                            Wachtwoord = "Test1",
                            TotaleDonatie = 1000
                        });
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
