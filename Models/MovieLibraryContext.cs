using System;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class MovieLibraryContext: DbContext
    {
        //constructor
        public MovieLibraryContext (DbContextOptions<MovieLibraryContext> options) : base (options)
        {
            //leave blank
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Action/Adventure"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Action/Comedy"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Action/Thriller"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Action/Sci-fi"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Family/Adventure"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Family/Comedy"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Family/Drama"
                },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "Horror/Comedy"
                },
                new Category
                {
                    CategoryID = 9,
                    CategoryName = "Horror/Sci-fi"
                },
                new Category
                {
                    CategoryID = 10,
                    CategoryName = "Horror/Thriller"
                },
                new Category
                {
                    CategoryID = 11,
                    CategoryName = "Romance/Comedy"
                },
                new Category
                {
                    CategoryID = 12,
                    CategoryName = "Romance/Drama"
                }
            );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    CategoryID = 4,
                    Title = "Dark Knight Rises",
                    Year = 2012,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""

                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    CategoryID = 4,
                    Title = "Batman Begins",
                    Year = 2005,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""


                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    CategoryID = 4,
                    Title = "The Dark Knight",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""


                }
            );
        }
    }
}
