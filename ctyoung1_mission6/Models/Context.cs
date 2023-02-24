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
        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categorys { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Adventure" },
                new Category { CategoryId = 3, CategoryName = "Drama" }
                );
            mb.Entity<ApplicationResponse>().HasData(
                 new ApplicationResponse
                 {
                     movieId = 1,

                     Title = "Troy",
                     Year = 1990,
                     Director = "Steven Spielburg",
                     Rating = "PG",
                     Edited = false,
                     Lent = "",
                     CategoryId = 1,
                     Notes = ""

                 },
                 new ApplicationResponse
                 {
                     movieId = 2,

                     Title = "I am Legend",
                     Year = 2005,
                     Director = "Michael Bay",
                     Rating = "PG-13",
                     Edited = true,
                     Lent = "Bob",
                     CategoryId = 2,
                     Notes = ""

                 },
                 new ApplicationResponse
                 {
                     movieId = 3,

                     Title = "Jumanji",
                     Year = 2015,
                     Director = "Jessie Pinkman",
                     Rating = "R",
                     Edited = false,
                     Lent = "",
                     CategoryId = 3,
                     Notes = ""

                 }

                 );


        }
    }
}

