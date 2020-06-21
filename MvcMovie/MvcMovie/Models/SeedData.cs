using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Adventure",
                        Rating = "PG",
                        Price = 9.99M,
                        Image =  "/images/heaven.jpg"
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers: Airborne Creed",
                        ReleaseDate = DateTime.Parse("2012-8-17"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 4.99M,
                        Image = "/images/saintsandsoldiers.jpg"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-2-1"),
                        Genre = "Romantic Comedy",
                        Rating = "PG",
                        Price = 4.99M,
                        Image = "/images/singlesward.jpg"
                    },

                    new Movie
                    {
                        Title = "The Home Teachers",
                        ReleaseDate = DateTime.Parse("2004-1-19"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 4.99M,
                        Image = "/images/hometeachers.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}