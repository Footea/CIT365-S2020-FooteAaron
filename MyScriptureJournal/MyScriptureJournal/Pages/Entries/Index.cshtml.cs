using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Entries
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.MyScriptureJournalContext context)
        {
            _context = context;
        }
        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<JournalEntry> JournalEntries { get; set; }


        public async Task OnGetAsync(string sortOrder, string searchString)
        {

            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            CurrentFilter = searchString;

            IQueryable<JournalEntry> journalEntriesIQ = from e in _context.JournalEntry
                                                     select e;

            if (!String.IsNullOrEmpty(searchString))
            {
                journalEntriesIQ = journalEntriesIQ.Where(e => e.Note.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "book_desc":
                    journalEntriesIQ = journalEntriesIQ.OrderByDescending(e => e.Book);
                    break;

                case "Date":
                    journalEntriesIQ = journalEntriesIQ.OrderByDescending(e => e.DatePosted);
                    break;

                default:
                    journalEntriesIQ = journalEntriesIQ.OrderBy(e => e.ID);
                    break;
                    
            }

            JournalEntries = await journalEntriesIQ.AsNoTracking().ToListAsync();

       
        }
    }
}
