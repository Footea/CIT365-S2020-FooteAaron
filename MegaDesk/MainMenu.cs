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
    public partial class MegaDesk : Form
    {
        public MegaDesk()
        {
            InitializeComponent();
        }

        private void MegaDesk_Load(object sender, EventArgs e)
        {

        }

  
        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Tag = this;
            addQuoteForm.Show(this);
            Hide();
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewQuotes viewQuoteForm = new ViewQuotes();
            viewQuoteForm.Tag = this;
            viewQuoteForm.Show(this);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
