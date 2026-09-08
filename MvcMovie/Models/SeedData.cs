using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"  
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "PG"
                },
new Movie
            {

            
                Title = "Batman Begins",
                ReleaseDate = DateTime.Parse("2010-07-16"),
                Genre = "SciFi",
                Price = 12.99M,
                Rating = "PG13"
            },
            new Movie
            {
                Title = "Black Panther",
                ReleaseDate = DateTime.Parse("2018-02-16"),
                Genre = "Action",
                Price = 14.99M,
                Rating = "PG13"
            },
            new Movie
            {
                Title = "Interstellar",
                ReleaseDate = DateTime.Parse("2014-11-07"),
                Genre = "SciFi",
                Price = 13.99M,
                Rating = "PG13"
            }
         
            );
            context.SaveChanges();
        }
    }
}