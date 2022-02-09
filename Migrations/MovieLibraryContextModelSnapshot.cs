﻿// <auto-generated />
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateMe.Migrations
{
    [DbContext(typeof(MovieLibraryContext))]
    partial class MovieLibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
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

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryID = 4,
                            Director = "Christopher Nolan",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Dark Knight Rises",
                            Year = 2012
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryID = 4,
                            Director = "Christopher Nolan",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Batman Begins",
                            Year = 2005
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryID = 4,
                            Director = "Christopher Nolan",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "The Dark Knight",
                            Year = 2008
                        });
                });

            modelBuilder.Entity("DateMe.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Action/Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Action/Thriller"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Action/Sci-fi"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Family/Adventure"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Family/Comedy"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Family/Drama"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Horror/Comedy"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Horror/Sci-fi"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "Horror/Thriller"
                        },
                        new
                        {
                            CategoryID = 11,
                            CategoryName = "Romance/Comedy"
                        },
                        new
                        {
                            CategoryID = 12,
                            CategoryName = "Romance/Drama"
                        });
                });

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.HasOne("DateMe.Models.Category", "CategoryId")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
