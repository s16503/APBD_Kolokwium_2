﻿// <auto-generated />
using System;
using APBD_Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APBD_Kolokwium_2.Migrations
{
    [DbContext(typeof(EventsDbContext))]
    [Migration("20200619121013_SeedBazy2Migration")]
    partial class SeedBazy2Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APBD_Kolokwium_2.Models.Artist", b =>
                {
                    b.Property<int>("IdArtist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("IdArtist");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            IdArtist = 1,
                            Nickname = "Kazik"
                        },
                        new
                        {
                            IdArtist = 2,
                            Nickname = "Madonna"
                        });
                });

            modelBuilder.Entity("APBD_Kolokwium_2.Models.Artist_Event", b =>
                {
                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.Property<int>("IdArtist")
                        .HasColumnType("int");

                    b.Property<DateTime>("PerformanceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdEvent", "IdArtist");

                    b.HasIndex("IdArtist");

                    b.ToTable("Artists_Events");

                    b.HasData(
                        new
                        {
                            IdEvent = 1,
                            IdArtist = 1,
                            PerformanceDate = new DateTime(2020, 6, 20, 14, 10, 12, 592, DateTimeKind.Local).AddTicks(3430)
                        },
                        new
                        {
                            IdEvent = 1,
                            IdArtist = 2,
                            PerformanceDate = new DateTime(2020, 6, 21, 14, 10, 12, 592, DateTimeKind.Local).AddTicks(4508)
                        },
                        new
                        {
                            IdEvent = 2,
                            IdArtist = 1,
                            PerformanceDate = new DateTime(2020, 7, 10, 14, 10, 12, 592, DateTimeKind.Local).AddTicks(4533)
                        });
                });

            modelBuilder.Entity("APBD_Kolokwium_2.Models.Event", b =>
                {
                    b.Property<int>("IdEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdEvent");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            IdEvent = 1,
                            EndDate = new DateTime(2020, 6, 24, 14, 10, 12, 587, DateTimeKind.Local).AddTicks(9136),
                            Name = "Opole 2020",
                            StartDate = new DateTime(2020, 6, 19, 14, 10, 12, 583, DateTimeKind.Local).AddTicks(7415)
                        },
                        new
                        {
                            IdEvent = 2,
                            EndDate = new DateTime(2020, 7, 19, 14, 10, 12, 587, DateTimeKind.Local).AddTicks(9938),
                            Name = "Festiwal muzyki Giżycko",
                            StartDate = new DateTime(2020, 7, 9, 14, 10, 12, 587, DateTimeKind.Local).AddTicks(9914)
                        });
                });

            modelBuilder.Entity("APBD_Kolokwium_2.Models.Event_Organiser", b =>
                {
                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.Property<int>("IdOrganiser")
                        .HasColumnType("int");

                    b.HasKey("IdEvent", "IdOrganiser");

                    b.HasIndex("IdOrganiser");

                    b.ToTable("Events_Organisers");

                    b.HasData(
                        new
                        {
                            IdEvent = 1,
                            IdOrganiser = 1
                        },
                        new
                        {
                            IdEvent = 2,
                            IdOrganiser = 1
                        });
                });

            modelBuilder.Entity("APBD_Kolokwium_2.Models.Organiser", b =>
                {
                    b.Property<int>("IdOrganiser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("IdOrganiser");

                    b.ToTable("Organisers");

                    b.HasData(
                        new
                        {
                            IdOrganiser = 1,
                            Name = "Orange"
                        });
                });

            modelBuilder.Entity("APBD_Kolokwium_2.Models.Artist_Event", b =>
                {
                    b.HasOne("APBD_Kolokwium_2.Models.Artist", "Artist")
                        .WithMany("Artist_Events")
                        .HasForeignKey("IdArtist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_Kolokwium_2.Models.Event", "Event")
                        .WithMany("Artists_Event")
                        .HasForeignKey("IdEvent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APBD_Kolokwium_2.Models.Event_Organiser", b =>
                {
                    b.HasOne("APBD_Kolokwium_2.Models.Event", "Event")
                        .WithMany("Event_Organisers")
                        .HasForeignKey("IdEvent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_Kolokwium_2.Models.Organiser", "Organiser")
                        .WithMany("Events_Organiser")
                        .HasForeignKey("IdOrganiser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
