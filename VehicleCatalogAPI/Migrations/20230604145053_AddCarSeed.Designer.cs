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
    [Migration("20230604145053_AddCarSeed")]
    partial class AddCarSeed
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

                    b.Property<decimal>("Day")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("Doors")
                        .HasColumnType("int");

                    b.Property<bool>("Electric")
                        .HasColumnType("bit");

                    b.Property<decimal>("Hour")
                        .HasColumnType("decimal(10, 2)");

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

                    b.Property<decimal>("Week")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "salmon",
                            Day = 42.7006802324006000m,
                            Doors = 2,
                            Electric = true,
                            Hour = 8.8118069377026430m,
                            Make = "Bentley",
                            Model = "Grand Caravan",
                            Power = 474.0,
                            Seats = 8,
                            Transmission = 2,
                            Type = 4,
                            Week = 250.089404194716000m,
                            Year = 2018
                        },
                        new
                        {
                            Id = 2,
                            Color = "plum",
                            Day = 13.69985788441360800m,
                            Doors = 2,
                            Electric = false,
                            Hour = 6.1611025245503650m,
                            Make = "Aston Martin",
                            Model = "2",
                            Power = 709.0,
                            Seats = 4,
                            Transmission = 1,
                            Type = 10,
                            Week = 232.9022431416184000m,
                            Year = 1993
                        },
                        new
                        {
                            Id = 3,
                            Color = "teal",
                            Day = 23.5287886505068400m,
                            Doors = 4,
                            Electric = false,
                            Hour = 1.071867549655902830m,
                            Make = "Chevrolet",
                            Model = "Silverado",
                            Power = 513.0,
                            Seats = 5,
                            Transmission = 1,
                            Type = 7,
                            Week = 139.7357092117654000m,
                            Year = 2018
                        },
                        new
                        {
                            Id = 4,
                            Color = "indigo",
                            Day = 36.2485069018643600m,
                            Doors = 4,
                            Electric = true,
                            Hour = 8.4796764905465440m,
                            Make = "Mazda",
                            Model = "Taurus",
                            Power = 479.0,
                            Seats = 7,
                            Transmission = 0,
                            Type = 2,
                            Week = 111.04557590078564000m,
                            Year = 1989
                        },
                        new
                        {
                            Id = 5,
                            Color = "lime",
                            Day = 45.9186868026987600m,
                            Doors = 4,
                            Electric = true,
                            Hour = 17.2014382396592790m,
                            Make = "Dodge",
                            Model = "2",
                            Power = 599.0,
                            Seats = 6,
                            Transmission = 0,
                            Type = 10,
                            Week = 139.6689453526222000m,
                            Year = 1984
                        },
                        new
                        {
                            Id = 6,
                            Color = "indigo",
                            Day = 48.4086622636228400m,
                            Doors = 4,
                            Electric = true,
                            Hour = 8.636457373703890m,
                            Make = "Nissan",
                            Model = "Corvette",
                            Power = 846.0,
                            Seats = 4,
                            Transmission = 0,
                            Type = 4,
                            Week = 104.85047556680816000m,
                            Year = 2005
                        },
                        new
                        {
                            Id = 7,
                            Color = "mint green",
                            Day = 27.553905014343200m,
                            Doors = 4,
                            Electric = false,
                            Hour = 2.9839265456086390m,
                            Make = "Smart",
                            Model = "Fiesta",
                            Power = 772.0,
                            Seats = 8,
                            Transmission = 2,
                            Type = 5,
                            Week = 152.8577630220628000m,
                            Year = 1992
                        },
                        new
                        {
                            Id = 8,
                            Color = "indigo",
                            Day = 44.7425216379386400m,
                            Doors = 2,
                            Electric = false,
                            Hour = 4.8979112041070290m,
                            Make = "Honda",
                            Model = "Impala",
                            Power = 192.0,
                            Seats = 2,
                            Transmission = 2,
                            Type = 3,
                            Week = 102.42944566558588000m,
                            Year = 2014
                        },
                        new
                        {
                            Id = 9,
                            Color = "purple",
                            Day = 21.2207036138469200m,
                            Doors = 2,
                            Electric = false,
                            Hour = 18.0109220002782490m,
                            Make = "Toyota",
                            Model = "Grand Caravan",
                            Power = 682.0,
                            Seats = 6,
                            Transmission = 1,
                            Type = 10,
                            Week = 277.2547378448376000m,
                            Year = 2018
                        },
                        new
                        {
                            Id = 10,
                            Color = "olive",
                            Day = 38.11946919920400m,
                            Doors = 4,
                            Electric = false,
                            Hour = 5.1360828441934560m,
                            Make = "Jeep",
                            Model = "Impala",
                            Power = 741.0,
                            Seats = 5,
                            Transmission = 0,
                            Type = 7,
                            Week = 212.969178266562000m,
                            Year = 2016
                        },
                        new
                        {
                            Id = 11,
                            Color = "gold",
                            Day = 36.803892653748800m,
                            Doors = 4,
                            Electric = true,
                            Hour = 14.148778880264470m,
                            Make = "Mercedes Benz",
                            Model = "Aventador",
                            Power = 956.0,
                            Seats = 8,
                            Transmission = 1,
                            Type = 4,
                            Week = 272.7073662661894000m,
                            Year = 1996
                        },
                        new
                        {
                            Id = 12,
                            Color = "ivory",
                            Day = 48.0146453228074000m,
                            Doors = 2,
                            Electric = true,
                            Hour = 7.5963948185422610m,
                            Make = "Mercedes Benz",
                            Model = "Countach",
                            Power = 787.0,
                            Seats = 6,
                            Transmission = 2,
                            Type = 1,
                            Week = 209.2282394003192000m,
                            Year = 2001
                        },
                        new
                        {
                            Id = 13,
                            Color = "grey",
                            Day = 45.7996069646996400m,
                            Doors = 2,
                            Electric = true,
                            Hour = 5.8720816938027140m,
                            Make = "Cadillac",
                            Model = "Explorer",
                            Power = 300.0,
                            Seats = 7,
                            Transmission = 1,
                            Type = 4,
                            Week = 154.6057824703814000m,
                            Year = 2001
                        },
                        new
                        {
                            Id = 14,
                            Color = "fuchsia",
                            Day = 21.0805627018864400m,
                            Doors = 2,
                            Electric = true,
                            Hour = 6.5196734302030180m,
                            Make = "Toyota",
                            Model = "911",
                            Power = 138.0,
                            Seats = 6,
                            Transmission = 0,
                            Type = 1,
                            Week = 175.9205635289690000m,
                            Year = 2012
                        },
                        new
                        {
                            Id = 15,
                            Color = "turquoise",
                            Day = 43.0005759531191200m,
                            Doors = 2,
                            Electric = true,
                            Hour = 14.1909534121338390m,
                            Make = "Cadillac",
                            Model = "Aventador",
                            Power = 217.0,
                            Seats = 8,
                            Transmission = 1,
                            Type = 2,
                            Week = 242.986977131892000m,
                            Year = 2003
                        },
                        new
                        {
                            Id = 16,
                            Color = "indigo",
                            Day = 19.234250071116800m,
                            Doors = 4,
                            Electric = true,
                            Hour = 16.3413806243659170m,
                            Make = "Fiat",
                            Model = "CTS",
                            Power = 639.0,
                            Seats = 6,
                            Transmission = 2,
                            Type = 2,
                            Week = 235.2351896922206000m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 17,
                            Color = "cyan",
                            Day = 38.6742747522510000m,
                            Doors = 4,
                            Electric = true,
                            Hour = 2.22448380816379680m,
                            Make = "Dodge",
                            Model = "Model S",
                            Power = 316.0,
                            Seats = 4,
                            Transmission = 0,
                            Type = 8,
                            Week = 276.7346257374704000m,
                            Year = 1988
                        },
                        new
                        {
                            Id = 18,
                            Color = "gold",
                            Day = 12.82975639855881200m,
                            Doors = 2,
                            Electric = false,
                            Hour = 3.5414989740980430m,
                            Make = "Volkswagen",
                            Model = "Wrangler",
                            Power = 445.0,
                            Seats = 6,
                            Transmission = 2,
                            Type = 6,
                            Week = 259.4602682844632000m,
                            Year = 1995
                        },
                        new
                        {
                            Id = 19,
                            Color = "mint green",
                            Day = 42.2887255466635200m,
                            Doors = 2,
                            Electric = true,
                            Hour = 13.6860741534920340m,
                            Make = "Bugatti",
                            Model = "Spyder",
                            Power = 604.0,
                            Seats = 8,
                            Transmission = 2,
                            Type = 3,
                            Week = 170.1358709170426000m,
                            Year = 1991
                        },
                        new
                        {
                            Id = 20,
                            Color = "black",
                            Day = 14.3100753607995200m,
                            Doors = 2,
                            Electric = true,
                            Hour = 2.9269693018908940m,
                            Make = "Ferrari",
                            Model = "Mustang",
                            Power = 877.0,
                            Seats = 4,
                            Transmission = 0,
                            Type = 1,
                            Week = 160.385554940870000m,
                            Year = 1994
                        });
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

            modelBuilder.Entity("VehicleCatalogAPI.Models.Car", b =>
                {
                    b.Navigation("CarExtras");
                });

            modelBuilder.Entity("VehicleCatalogAPI.Models.Extra", b =>
                {
                    b.Navigation("CarExtras");
                });
#pragma warning restore 612, 618
        }
    }
}
