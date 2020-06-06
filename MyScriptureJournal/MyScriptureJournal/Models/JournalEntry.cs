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
        [Required]
        public DateTime DatePosted { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Book { get; set; }

        
        
        [Required]
        public int Chapter { get; set; }

        [StringLength(10, MinimumLength = 1)]
        [Required]
        public string Verse { get; set; }

        [StringLength(80, MinimumLength = 3)]
        [Required]
        public string Note { get; set; }
    }
}
