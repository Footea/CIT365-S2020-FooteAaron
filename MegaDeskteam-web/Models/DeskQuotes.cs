using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskteam_web.Models
{
    public class DeskQuotes
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }

       // [DataType(DataType.Date)]
        //[Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }
        //[Display(Name = "Rush Order")]
        public string RushDays { get; set; }
        public string Material { get; set; }
        public int Drawers { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        //[Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
