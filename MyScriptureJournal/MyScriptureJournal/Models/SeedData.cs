using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(serviceProvider.GetRequiredService<
           DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any scriputres.
                if (context.Scriptures.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scriptures.AddRange(
                    new FavScripture
                    {
                        DateAdded = DateTime.Parse("02/24/2019"),
                        Book = "Luke",
                        Chapter = 6,
                        Verse = 23,
                        Notes = "Impression"

                       
                    },

                    new FavScripture
                    {
                        DateAdded = DateTime.Parse("02/12/2019"),
                        Book = "Ether",
                        Chapter = 3,
                        Verse = 20,
                        Notes = "Impression"

                    },

                    new FavScripture
                    {
                        DateAdded = DateTime.Parse("02/12/2019"),
                        Book = "Ether",
                        Chapter = 3,
                        Verse = 19,
                        Notes = "Impression"

                    },

                    new FavScripture
                    {
                        DateAdded = DateTime.Parse("02/12/2019"),
                        Book = "Mormon",
                        Chapter = 9,
                        Verse = 19,
                        Notes = "Impression"

                    },
                    
                    new FavScripture
                    {
                        DateAdded = DateTime.Parse("02/12/2019"),
                        Book = "Mormon",
                        Chapter = 8,
                        Verse = 39,
                        Notes = "Impression"

                    },

                    new FavScripture
                    {
                        DateAdded = DateTime.Parse("10/03/2018"),
                        Book = "3 Nephi",
                        Chapter = 17,
                        Verse = 4,
                        Notes = "Impression"
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}
