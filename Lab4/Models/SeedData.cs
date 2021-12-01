using Lab4.Data;
using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Lab4Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Lab4Context>>()))
            {
                // Look for any movies.
                if (context.Playlist.Any())
                {
                    return;   // DB has been seeded
                }

                context.Playlist.AddRange(
                    new Playlist
                    {
                        addDate = DateTime.Parse("1984-3-13"),
                        Author = "Franek Kimono",
                        Kind = "Dance",
                        Title = "King Bruce Lee - Karate mistrz"
                    },

                    new Playlist
                    {
                        addDate = DateTime.Parse("2008-3-13"),
                        Author = "Green Day",
                        Kind = "Rock",
                        Title = "American Idiot"
                    },

                    new Playlist
                    {
                        addDate = DateTime.Parse("1999-12-17"),
                        Author = "Metallica",
                        Kind = "Dance",
                        Title = "Nothing else mathers"
                    },

                    new Playlist
                    {
                        addDate = DateTime.Parse("2006-7-22"),
                        Author = "Dzem",
                        Kind = "Ballada",
                        Title = "Wisky moja zono"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}