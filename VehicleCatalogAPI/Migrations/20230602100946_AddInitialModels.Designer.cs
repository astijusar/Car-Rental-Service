﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleCatalogAPI.Models;

#nullable disable

namespace VehicleCatalogAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230602100946_AddInitialModels")]
    partial class AddInitialModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VehicleCatalogAPI.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Doors")
                        .HasColumnType("int");

                    b.Property<bool>("Electric")
                        .HasColumnType("bit");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Power")
                        .HasColumnType("float");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<int>("Transmission")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("VehicleCatalogAPI.Models.CarExtra", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("ExtraId")
                        .HasColumnType("int");

                    b.HasKey("CarId", "ExtraId");

                    b.HasIndex("ExtraId");

                    b.ToTable("CarExtras");
                });

            modelBuilder.Entity("VehicleCatalogAPI.Models.Extra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Extras");
                });

            modelBuilder.Entity("VehicleCatalogAPI.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<decimal>("Day")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("Hour")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("Week")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("VehicleCatalogAPI.Models.CarExtra", b =>
                {
                    b.HasOne("VehicleCatalogAPI.Models.Car", "Car")
                        .WithMany("CarExtras")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleCatalogAPI.Models.Extra", "Extra")
                        .WithMany("CarExtras")
                        .HasForeignKey("ExtraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Extra");
                });

            modelBuilder.Entity("VehicleCatalogAPI.Models.Price", b =>
                {
                    b.HasOne("VehicleCatalogAPI.Models.Car", "Car")
                        .WithOne("Price")
                        .HasForeignKey("VehicleCatalogAPI.Models.Price", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("VehicleCatalogAPI.Models.Car", b =>
                {
                    b.Navigation("CarExtras");

                    b.Navigation("Price")
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleCatalogAPI.Models.Extra", b =>
                {
                    b.Navigation("CarExtras");
                });
#pragma warning restore 612, 618
        }
    }
}
