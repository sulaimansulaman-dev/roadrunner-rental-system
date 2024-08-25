using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Project
{
    public partial class Assistant_Menu : Form
    {
        private Form form1;

        public Assistant_Menu(Form previous)
        {
            InitializeComponent();
            form1 = previous;
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Assistant_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            rentalOrder rentalOrder = new rentalOrder(this);
            rentalOrder.Show();

        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {

        }

        private void Assistant_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
