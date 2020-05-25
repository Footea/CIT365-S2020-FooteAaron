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


        public AddQuote()
        {
            InitializeComponent();

           //Populate enum on AddQuote Form using List and Cast
           List<Enum.DesktopMaterial> MaterialList = Enum.DesktopMaterial.GetValues(typeof(Enum.DesktopMaterial)).Cast<Enum.DesktopMaterial>().ToList();
           comboDeskType.DataSource = MaterialList;

            label4.Text = DateTime.Now.ToString("MM/dd/yyyy");
            dquote.SetQuoteDate(label14.Text);
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            rushOrder.Text = "Select Shipping";
        }

        readonly Desk desk = new Desk();
        readonly DeskQuote dquote = new DeskQuote();

        //input Name
        private void InputCustomerName_TextChanged(object sender, EventArgs e)
        {
            dquote.SetCustomerName(InputCustomerName.Text);
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

 



        //Desk Drawer input and validation of input
        private void inputDeskDrawers(object sender, CancelEventArgs e)
        {
            SetDrawerPrice();
            TotalCost();
        }
        private void SetDrawerPrice()
        {
            int drawers = Int32.Parse(deskDrawers.Text);
            label15.Text = Convert.ToString(drawers);
            dquote.DrawerCost(drawers);
            lblDrawerCost.Text = dquote.DrawerCost(desk.GetNumDrawers()).ToString() + ".00";

        }

        //Desk Width input and validation of input
        private void inputDeskWidth(object sender, CancelEventArgs e)
        {
            int width = Int32.Parse(deskWidth.Text);
            label8.Text = Convert.ToString(width);
            DeskTotalArea();
            TotalCost();

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
                int depth = Int32.Parse(deskDepth.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                MessageBox.Show("Please enter only numbers into the width field");
            }
            if (   < Desk.MINDEPTH|| depth > Desk.MAXDEPTH)
            {
                MessageBox.Show("Please enter numbers between 24 and 96");
            }
            
        }
        private void inputDeskDepth_Textchanged(object sender, CancelEventArgs e)
        {

        }

        private void inputDeskWidth_Textchanged(object sender, CancelEventArgs e)
        {

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

            label2.Text = DateTime.Now.ToString("MM/dd/yyyy"); ;
            label3.Text = Convert.ToString(InputCustomerName.Text);
            
            
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


         //   Desk newDesk = new Desk(width, depth, drawers, materialcost);
          //  DeskQuote newDeskQuote = new DeskQuote(newDesk, customerName, deskarea, rushday);
          //  quote = Convert.ToString(newDeskQuote.QuotePrice());
             DisplayQuotes displayQuote = new DisplayQuotes(quote);
             displayQuote.Show();
            // Close();
        }

        
    }

     
        
}

