using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public class Desk
    {

        // Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;


        public Desk(int width, int depth, int drawers, int rushday, int materialcost)
        {
            this.width = width;
            this.depth = depth;
            this.depth = drawers;
            this.materialcost = materialcost;
        }


        //Desk properties
        public int materialcost { get; set; }
        public int drawers { get; set; }
        public int depth { get; set; }
        public int width { get; set; }     
        public int rushday { get; set; }


   

        // Surface Material
        public enum Material
        {
            Pine = 50,
            Laminate = 100,
            Veneer = 150,
            Oak = 200,
            Rosewood = 300
        }
    
    }
       


    
}
