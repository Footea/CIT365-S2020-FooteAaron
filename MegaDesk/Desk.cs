using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
   public class Enum
    {
        public enum DesktopMaterial
        {
            Oak = 200,
            Lamintate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 150
        };
    }
  
    class Desk
    {

        // Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        int width;
        int depth;
        int numDrawers;
        string material;

        // width
        public int GetWidth()
        {
            return width;
        }
      public void SetWidth(int width)
        {
            this.width = width;
        }

        // Depth
        public int GetDepth()
        {
            return depth;
        }
        public void SetDepth(int depth)
        {
            this.depth = depth;
        }

        public int GetNumDrawers()
        {
            return numDrawers;
        }

        //number of drawers
        public void SetNumDrawers(int numDrawers)
        {
            this.numDrawers = numDrawers;
        }

        // material
        public string GetMaterial()
        {
            return material;
        }
        public void SetMaterial( string material)
        {
            this.material = material;
        }

        /*  public Desk(int width, int depth, int drawers, int rushday, int materialcost)
        {
            this.width = width;
            this.depth = depth;
            this.depth = drawers;
            this.materialcost = materialcost;
        }


        //Desk properties
        public int materialcost { get; set; }
      //  public int numDrawers { get; set; }
      //   public int depth { get; set; }
      //  public int width { get; set; }     
        public int rushday { get; set; }
*/

    }
}
