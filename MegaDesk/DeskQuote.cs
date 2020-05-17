using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    class DeskQuote
    {
        //Desk Quote Contraints
        const int BASEPRICE = 200;
        const int DESKBASEAREA = 1000;
        const int DRAWERCOST = 50;
        
        public Desk desk { get; set; }
        public int quoteTotal { get; set; }
        public string customerName { get; set; }
        public int rushday { get; set; }
        public string quoteDate { get; set; }
       
        
        //Desk Quote Information
        
        
        
        
       
        

        public static int getQuotePrice(int width, int depth, int drawers, int materialcost, int rushday)
        {
            int quoteprice = BASEPRICE + deskAreaPrice(width, depth) + drawerPrice(drawers)  + rushOrderPrice(rushday, depth, width) + materialcost;
            return quoteprice; 
        }
       

       

        //public getMaterialType(int material)
       // {
        //   int material = 

         //       return material;
       // }

        public static int DeskSurface(int width, int depth)
        {
                return width * depth;
        } 

        public static int deskAreaPrice(int width, int depth)
        {
            int deskarea = DeskSurface(width, depth);

                if (deskarea - DESKBASEAREA > 0)
                    return deskarea - DESKBASEAREA;
                else
                    return 0;
        }

        public static int drawerPrice(int drawers)
        {
            return drawers * DRAWERCOST;
        }

        public static int rushOrderPrice(int rushday,int depth, int width)
        {
            int deskarea = width * depth;
            int rushprice = 0;
            switch (rushday)
            {
              
                case 1:
                    if (deskarea > 2000)
                        rushprice = 40;
                    else if (deskarea < 2000 && deskarea > 1000)
                        rushprice = 35;
                    else
                        rushprice = 30;
                    break;
     
                case 2:
                    if (deskarea > 2000)
                        rushprice = 60;
                    else if (deskarea < 2000 && deskarea > 1000)
                        rushprice = 50;
                    else
                        rushprice = 40;
                    break;

                case 3:
                    if (deskarea > 2000)
                        rushprice = 80;
                    else if (deskarea < 2000 && deskarea > 1000)
                        rushprice = 70;
                    else
                        rushprice = 60;
                    break;

                default:
                    rushprice = 0;
                    break;
            }
                return rushprice;
        }

        private static int materialCost(string material)
        {
            int materialcost;
            switch (material)
            {
                case "Rosewood":
                    materialcost = 300;
                    break;
                case "Oak":
                    materialcost = 200;
                    break;
                case "Veneer":
                    materialcost = 150;
                    break;
                case "Laminate":
                    materialcost = 100;
                    break;
                default:
                    materialcost = 50;
                    break;
            }
            return materialcost;
        }


    }

}

