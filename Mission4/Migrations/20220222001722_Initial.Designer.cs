﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(FilmContext))]
    [Migration("20220222001722_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.Film", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            FilmID = 1,
                            Category = "Action",
                            Director = "James Mangold",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Ford vs Ferarri",
                            Year = 2019
                        },
                        new
                        {
                            FilmID = 2,
                            Category = "History",
                            Director = "Gavin O'Connor",
                            Edited = false,
                            Rating = "PG",
                            Title = "Miracle",
                            Year = 2004
                        },
                        new
                        {
                            FilmID = 3,
                            Category = "Action",
                            Director = "Christopher Nolan",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Dark Knight",
                            Year = 2008
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
