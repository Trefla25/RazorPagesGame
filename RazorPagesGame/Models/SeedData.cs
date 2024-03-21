#define Rating
#if Rating
#region snippet_1 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesGame.Data;
using System;
using System.Linq;

namespace RazorPagesGame.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesGameContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesGameContext>>()))
        {
            if (context == null || context.Game == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Game.Any())
            {
                return;   // DB has been seeded
            }


            context.Game.AddRange(
                new Game
                {
                    Title = "Skul:The Hero Slayer",
                    ReleaseDate = DateTime.Parse("01-21-2021"),
                    Genre = "Rouguelike",
                    Price = 17,
                    Rating = "8/10"
                },

                new Game
                {
                    Title = "Forza Horizon 5",
                    ReleaseDate = DateTime.Parse("11-05-2021"),
                    Genre = "Racing",
                    Price = 60,
                    Rating = "10/10"
                },

                new Game
                {
                    Title = "Hearthstone",
                    ReleaseDate = DateTime.Parse("03-11-2014"),
                    Genre = "Card Game",
                    Price = 0,
                    Rating = "9/10"
                },

                new Game
                {
                    Title = "Slay the Spire",
                    ReleaseDate = DateTime.Parse("11-14-2017"),
                    Genre = "Rougulike Deck-building",
                    Price = 23,
                    Rating = "9/10"
                }
            );
            context.SaveChanges();
        }
        
    }
}
#endregion
#endif