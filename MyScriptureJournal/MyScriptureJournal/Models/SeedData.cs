using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Intialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(serviceProvider.GetRequiredService<DbContextOptions<MyScriptureJournalContext>>()))
            {
                //Look for Scriptures
                if (context.JournalEntry.Any())
                {
                    return; // DBNull has been seeded
                }

                context.JournalEntry.AddRange(

                    new JournalEntry
                    {
                        DatePosted = DateTime.Parse("07/04/1997"),
                        Book = "Mathew",
                        Chapter = 28,
                        Verse = "19-20",
                        Note = "Go and Teach all Nations and Baptize them"
                    },
                     new JournalEntry
                     {
                         DatePosted = DateTime.Parse("03/15/1990"),
                         Book = "Moroni",
                         Chapter = 10,
                         Verse = "3-10",
                         Note = "Promise of Book of Mormon, if it is true."
                     },

                      new JournalEntry
                      {
                          DatePosted = DateTime.Parse("08/15/1986"),
                          Book = "1 Nephi",
                          Chapter = 1,
                          Verse = "1",
                          Note = "Born of Goodly Parents"
                      },

                      new JournalEntry
                      {
                          DatePosted = DateTime.Parse("02/22/2001"),
                          Book = "Genesis",
                          Chapter = 1,
                          Verse = "1",
                          Note = "Creation of Earth and Man"
                      }
                    );
                context.SaveChanges();

            }
        }
    }
}
    