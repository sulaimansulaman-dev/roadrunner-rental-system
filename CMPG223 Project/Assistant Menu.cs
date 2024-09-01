using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

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

        private void populateComboBox(ComboBox comboBox)
        {
            try
            {   
                SqlConnection con = new SqlConnection("Data Source=MOMO;Initial Catalog=\\\"Roadrunner Rentals\\\";Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
                con.Open();
                string comboBoxSelect = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(comboBoxSelect, con);
                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);
                comboBox.ValueMember = "User_ID";
                comboBox.DisplayMember = "Username";
                comboBox.SelectedIndex = -1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Assistant_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            form1.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
