﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParksLocator.Models;

namespace NationalParksLocator.Migrations
{
    [DbContext(typeof(NationalParksLocatorContext))]
    partial class NationalParksLocatorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NationalParksLocator.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("YearFounded")
                        .HasColumnType("int");

                    b.Property<string>("YearlyVisitors")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Name = "Acadia",
                            State = "Maine",
                            YearFounded = 1919,
                            YearlyVisitors = "3,500,000"
                        },
                        new
                        {
                            ParkId = 2,
                            Name = "American Samoa",
                            State = "American Samoa",
                            YearFounded = 1988,
                            YearlyVisitors = "60,000"
                        },
                        new
                        {
                            ParkId = 3,
                            Name = "Arches",
                            State = "Utah",
                            YearFounded = 1971,
                            YearlyVisitors = "1,600,000"
                        },
                        new
                        {
                            ParkId = 4,
                            Name = "Badlands",
                            State = "South Dakota",
                            YearFounded = 1978,
                            YearlyVisitors = "970,000"
                        },
                        new
                        {
                            ParkId = 5,
                            Name = "Big Bend",
                            State = "Texas",
                            YearFounded = 1944,
                            YearlyVisitors = "460,000"
                        },
                        new
                        {
                            ParkId = 6,
                            Name = "Biscayne",
                            State = "Florida",
                            YearFounded = 1980,
                            YearlyVisitors = "700,000"
                        },
                        new
                        {
                            ParkId = 7,
                            Name = "Black Canyon of the Gunnison",
                            State = "Colorado",
                            YearFounded = 1999,
                            YearlyVisitors = "432,000"
                        },
                        new
                        {
                            ParkId = 8,
                            Name = "Bryce Canyon",
                            State = "Utah",
                            YearFounded = 1928,
                            YearlyVisitors = "2,500,000"
                        },
                        new
                        {
                            ParkId = 9,
                            Name = "Canyonlands",
                            State = "Utah",
                            YearFounded = 1964,
                            YearlyVisitors = "733,000"
                        },
                        new
                        {
                            ParkId = 10,
                            Name = "Capitol Reef",
                            State = "Utah",
                            YearFounded = 1930,
                            YearlyVisitors = "1,200,000"
                        },
                        new
                        {
                            ParkId = 11,
                            Name = "Carlsbad Caverns",
                            State = "New Mexico",
                            YearFounded = 1930,
                            YearlyVisitors = "440,000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
