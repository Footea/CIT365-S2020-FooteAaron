using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MegaDesk
{
    class DeskQuote
    {
        //Desk Quote Contraints
        const int BASEPRICE = 200;
        const int DESKBASEAREA = 1000;
        const int DRAWERCOST = 50;

        public double price;
        public int osPrice;
        public int drawPrice;
        public string customerName;
        public int rushDays;
        public int shippingPrice;
        public string quoteDate;
        //Rush Order Prices file read and 2D Array created    
        public const string RUSHORDERPRICE = (@"C:\RushOrderPrices\rushOrderPrices.txt");  // @"file path"

        //customerName
        public string GetCustomerName()
        {
            return customerName;
        }
        public string SetCustomerName(string custname)
        {
            return this.customerName = custname;
        }

        //rushDays
        public int GetRushDays()
        {
            return rushDays;
        }
        public void SetRushDays(int rdays)
        {
            this.rushDays = rdays;            
        }

        //quoteDate
        public string GetQuoteDate()
        {
            return quoteDate;
        }
        public void SetQuoteDate (string qdate)
        {
            this.quoteDate = qdate;
        }

        //price
        public double GetPrice()
        {
            return price;
        }
        public void SetPrice(double dprice)
        {
            this.price = dprice;
        }
       
        
        // oversize cost
        public int GetOverSizeCost()
        {
            return osPrice;
        }
        public void setOverSizeCost(int oscost)
        {
            this.osPrice = oscost;
        }

        //drawers cost 
        public int DrawerCost( int drawers)
        {
            drawPrice = drawers * 50;
            return drawPrice;
        }

        //Reads text file and builds 2D Array roPrice   
        public int[,] GetRushOrder()
        {
            try
            {
                if (!File.Exists(@"C:\RushOrderPrices\rushOrderPrices.txt"))
                    throw new FileNotFoundException();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Oops somthing went wrong, no file exist!");

            }

            string[] prices = File.ReadAllLines(RUSHORDERPRICE);


            int[,] roPrice = new int[3, 3];
            for (int rop1 = 0; rop1 < 3; rop1++)
            {
                for (int rop2 = 0; rop2 < 3; rop2++)
                {
                    roPrice[rop1, rop2] = Int32.Parse(prices[(rop1 * 3) + rop2]);
                }
            }
            return roPrice;
        }

        //Calculate Rush Order
        public int ShippingCost(int sc)
        {
            switch (rushDays)
            {
                case 0://3 Day
                    if (sc < 1000)
                    {
                        shippingPrice = GetRushOrder()[0, 0];
                        // return 60;
                        return GetRushOrder()[0, 0];
                    }
                    else if (sc > 2000)
                    {
                        shippingPrice = GetRushOrder()[0, 2];
                        // return 80;
                        return GetRushOrder()[0, 2];
                    }
                    else
                    {
                        shippingPrice = GetRushOrder()[0, 1];
                        // return 70;
                        return GetRushOrder()[0, 1];
                    }
                case 1://5 Day
                    if (sc < 1000)
                    {
                        shippingPrice = GetRushOrder()[1, 0];
                        // return 40;
                        return GetRushOrder()[1, 0];
                    }

                    else if (sc > 2000)
                    {
                        shippingPrice = GetRushOrder()[1, 2];
                        //return 60;
                        return GetRushOrder()[1, 2];
                    }
                    else
                    {
                        shippingPrice = GetRushOrder()[1, 1];
                        //return 50;
                        return GetRushOrder()[1, 1];
                    }
                case 2://7 Day
                    if (sc < 1000)
                    {
                        shippingPrice = GetRushOrder()[2, 0];
                        //return 30;
                        return GetRushOrder()[2, 0];
                    }
                    else if (sc > 2000)
                    {
                        shippingPrice = GetRushOrder()[2, 2];
                        //return 40;
                        return GetRushOrder()[2, 2];
                    }
                    else
                    {
                        shippingPrice = GetRushOrder()[2, 1];
                        //return 35;
                        return GetRushOrder()[2, 1];
                    }
                case 3://Normal
                    shippingPrice = 0;
                    return 0;
                default:
                    return 0;
            }
        }

        // public int MaterialCost(int material)
        // {
        //   int material = 

        //       return material;
        // }

        //totalCost
        public void TotalCost()
        {
            double total = shippingPrice + drawPrice + osPrice + BASEPRICE;
            SetPrice(total);
        }


    }

}

