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
    [Migration("20200619112250_InitialMigration")]
    partial class InitialMigration
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
                });
#pragma warning restore 612, 618
        }
    }
}
