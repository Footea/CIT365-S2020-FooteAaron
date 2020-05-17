using MegaDesk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {

        Desk.Material material;
        public string customerName;
        public string quote;
        private int width = 0;
        private int depth = 0;
        private int drawers = 0;
        public int deskarea = 0;
        private int materialcost = 0;
        public int rushday = 0;
       // public string quote;
        
        
        
 
        DateTime date = new DateTime();



        public AddQuote()
        {
            InitializeComponent();

           //Populate enum on AddQuote Form using List and Cast
           List<Desk.Material> MaterialList = Enum.GetValues(typeof(Desk.Material)).Cast<Desk.Material>().ToList();
           comboDeskType.DataSource = MaterialList;
            

        }



        private void InputCustomerName_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void AddQuote_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            rushOrder.Text = "Select Shipping";
        }



        //Chosen desk surface and assigned to variable
        private void comboDeskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                material = (Desk.Material)comboDeskType.SelectedValue;
                materialCost(material.ToString());
            }
            catch (Exception)
            {
                throw;
            }

        }

        private int materialCost(string material)
        {
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

        private void inputCustomerName(object sender, CancelEventArgs e)
        {
            customerName = InputCustomerName.Text;
        }



        //Desk Drawer input and validation of input
        private void inputDeskDrawers(object sender, CancelEventArgs e)
        {
           
            try
            {
                drawers = Int32.Parse(deskDrawers.Text);
            }

            catch (Exception)
            {
                e.Cancel = true;
                MessageBox.Show("Please enter only numbers into the width field");
            }
            if (drawers < 0 || drawers > 8)
            { 
                    MessageBox.Show("Please enter numbers between 0 and 7");
            }   
        }

        //Desk Width input and validation of input
        private void inputDeskWidth(object sender, CancelEventArgs e)
        {
            
            try
            {
                width = Int32.Parse(deskWidth.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                MessageBox.Show("Please enter only numbers into the width field");
            }
            if (width < Desk.MINWIDTH || width > Desk.MAXWIDTH)
            {
                MessageBox.Show("Please enter numbers between 24 and 96");
            }
            
        }

        //Desk Depth input and validation of input
        private void inputDeskDepth(object sender, CancelEventArgs e)
        {
            
            try
            {
               depth = Int32.Parse(deskDepth.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                MessageBox.Show("Please enter only numbers into the width field");
            }
            if (depth < Desk.MINDEPTH|| depth > Desk.MAXDEPTH)
            {
                MessageBox.Show("Please enter numbers between 24 and 96");
            }
        }
        private void rushOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            rushOrder.Text = "Select Shipping";
            rushday = rushOrder.SelectedIndex;
          
           
        }

        //btn that shows summary of choice before submitting for price
        private void btnSummary_Click(object sender, EventArgs e)
        {
            string quote;
            int deskarea = width * depth;

            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = Convert.ToString(InputCustomerName.Text);
            label8.Text = Convert.ToString(width);
            label10.Text = Convert.ToString(depth);
            label15.Text = Convert.ToString(drawers);
            label14.Text = Convert.ToString(material);
            label17.Text = Convert.ToString(deskarea);
            label18.Text = Convert.ToString(materialcost);
            label19.Text = Convert.ToString(rushday);
           // label20.Text = quote;

            Desk desk = new Desk
            { 
                depth = depth,
                width = width,
                drawers = drawers,
                materialcost = materialcost,
                rushday = rushday,
            };

            DeskQuote deskquote = new DeskQuote();
            {
                deskquote.desk = desk;
                deskquote.customerName = InputCustomerName.Text;
                //  deskquote.quoteDate = DateTime.Now.ToLongDateString;
                deskquote.quoteTotal = DeskQuote.getQuotePrice(desk.depth, desk.width, desk.drawers, desk.rushday, desk.materialcost);
            }

            quote = Convert.ToString(deskquote.quoteTotal);




           // DeskQuote newDeskQuote = new DeskQuote(desk, customerName); //quoteDate ?
           // quotetotal = Convert.ToString(quote);


        }

        //Cancel of Adding Quote
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            var mainMenu = (MegaDesk)Tag;
            mainMenu.Show();
            Close();
        }


        //Submit Quote and goes to display form showing price.
        private void btnSubmit_Click(object sender, EventArgs e)
        {


            Desk newDesk = new Desk(width, depth, drawers, materialcost);
          //  DeskQuote newDeskQuote = new DeskQuote(newDesk, customerName, deskarea, rushday);
          //  quote = Convert.ToString(newDeskQuote.QuotePrice());
             DisplayQuotes displayQuote = new DisplayQuotes(quote);
             displayQuote.Show();
            // Close();
        }

        
    }

     
        
}

