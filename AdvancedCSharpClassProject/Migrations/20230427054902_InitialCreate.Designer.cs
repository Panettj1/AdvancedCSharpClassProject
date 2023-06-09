﻿// <auto-generated />
using System;
using AdvancedCSharpClassProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdvancedCSharpClassProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230427054902_InitialCreate")]
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

            modelBuilder.Entity("AdvancedCSharpClassProject.Classes.BaseClasses.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Food")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotesToSitter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Animal");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("AdvancedCSharpClassProject.Classes.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "John"
                        });
                });

            modelBuilder.Entity("AdvancedCSharpClassProject.Classes.AquaticAnimal", b =>
                {
                    b.HasBaseType("AdvancedCSharpClassProject.Classes.BaseClasses.Animal");

                    b.Property<int?>("LightIntensity")
                        .HasColumnType("int");

                    b.Property<string>("Tank")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("AqauticAnimals", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Age = 5,
                            Color = "Blue",
                            Food = "Fish Filet",
                            Name = "TestAnimal",
                            NotesToSitter = "This is a test note, please take good care of my dog",
                            OwnerId = 1,
                            LightIntensity = 67,
                            Tank = "Large Tank"
                        });
                });

            modelBuilder.Entity("AdvancedCSharpClassProject.Classes.LandAnimals", b =>
                {
                    b.HasBaseType("AdvancedCSharpClassProject.Classes.BaseClasses.Animal");

                    b.Property<bool?>("Caged")
                        .HasColumnType("bit");

                    b.Property<int?>("WaterInterval")
                        .HasColumnType("int");

                    b.ToTable("LandAnimals", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -2,
                            Age = 7,
                            Color = "red",
                            Food = "Kibbles N' Bits",
                            Name = "TestAnimal2",
                            NotesToSitter = "This is the second test note, please also take care of my dog",
                            OwnerId = 1,
                            Caged = true,
                            WaterInterval = 3
                        });
                });

            modelBuilder.Entity("AdvancedCSharpClassProject.Classes.BaseClasses.Animal", b =>
                {
                    b.HasOne("AdvancedCSharpClassProject.Classes.Owner", "Owner")
                        .WithMany("Animals")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("AdvancedCSharpClassProject.Classes.AquaticAnimal", b =>
                {
                    b.HasOne("AdvancedCSharpClassProject.Classes.BaseClasses.Animal", null)
                        .WithOne()
                        .HasForeignKey("AdvancedCSharpClassProject.Classes.AquaticAnimal", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdvancedCSharpClassProject.Classes.LandAnimals", b =>
                {
                    b.HasOne("AdvancedCSharpClassProject.Classes.BaseClasses.Animal", null)
                        .WithOne()
                        .HasForeignKey("AdvancedCSharpClassProject.Classes.LandAnimals", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdvancedCSharpClassProject.Classes.Owner", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
