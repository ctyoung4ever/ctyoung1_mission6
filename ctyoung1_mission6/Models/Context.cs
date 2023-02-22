using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctyoung1_mission6.Models
{
    public class Context : DbContext
    {
        //Constructor
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    movieId = 1,
                    Category = "Action",
                    Title = "Troy",
                    Year = 1990,
                    Director = "Steven Spielburg",
                    RatingID = 1,
                    Edited = false,
                    Lent = "", 
                    Notes = ""

                },
                new ApplicationResponse
                {
                    movieId = 2,
                    Category = "Comedy",
                    Title = "I am Legend",
                    Year = 2005,
                    Director = "Michael Bay",
                    RatingID = 2,
                    Edited = true,
                    Lent = "Bob",
                    Notes = ""

                },
                new ApplicationResponse
                {
                    movieId = 3,
                    Category = "Adventure",
                    Title = "Jumanji",
                    Year = 2015,
                    Director = "Jessie Pinkman",
                    RatingID = 3,
                    Edited = false,
                    Lent = "",
                    Notes = ""

                }

                );
        }
    }
}
