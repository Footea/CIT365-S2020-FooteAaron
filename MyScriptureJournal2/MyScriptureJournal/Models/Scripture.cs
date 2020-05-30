using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [Display(Name = " Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [StringLength(12, MinimumLength = 5)]
        [Required]
        public string Book { get; set; }

      //  [Column(Int32)]
        public int Chapter { get; set; }

        [Column(TypeName = "varchar(30)")]
        public int Verse { get; set; }

        public string Notes { get; set; }
       
    }
}
