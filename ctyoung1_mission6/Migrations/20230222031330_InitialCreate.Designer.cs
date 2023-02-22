﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ctyoung1_mission6.Models;

namespace ctyoung1_mission6.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230222031330_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("ctyoung1_mission6.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("movieId")
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

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("RatingID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("movieId");

                    b.HasIndex("RatingID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            Category = "Action",
                            Director = "Steven Spielburg",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            RatingID = 1,
                            Title = "Troy",
                            Year = 1990
                        },
                        new
                        {
                            movieId = 2,
                            Category = "Comedy",
                            Director = "Michael Bay",
                            Edited = true,
                            Lent = "Bob",
                            Notes = "",
                            RatingID = 2,
                            Title = "I am Legend",
                            Year = 2005
                        },
                        new
                        {
                            movieId = 3,
                            Category = "Adventure",
                            Director = "Jessie Pinkman",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            RatingID = 3,
                            Title = "Jumanji",
                            Year = 2015
                        });
                });

            modelBuilder.Entity("ctyoung1_mission6.Models.Rating", b =>
                {
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("rating")
                        .HasColumnType("TEXT");

                    b.HasKey("RatingID");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("ctyoung1_mission6.Models.ApplicationResponse", b =>
                {
                    b.HasOne("ctyoung1_mission6.Models.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
