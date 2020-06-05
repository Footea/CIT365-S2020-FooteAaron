using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class JournalEntry
    {
        public int ID { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public string Verse { get; set; }
        public string Note { get; set; }
    }
}
