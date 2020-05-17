using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuotes : Form
    {
        public DisplayQuotes()
        {
            InitializeComponent();
        }

        //reference for sending data from addQuote - https://www.codeproject.com/Articles/14122/Passing-Data-Between-Forms
        public DisplayQuotes(string quote)
        {
            InitializeComponent();
            lbldisplayQuote.Text = quote;
        }

      



        private void button1_Click_1(object sender, EventArgs e)
        {
         //   MainMenu MM = new MainMenu();
         //   MM.Show();
        //    Close();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote AQ = new AddQuote();
            AQ.Show();
            Close();
        }
    }
}

