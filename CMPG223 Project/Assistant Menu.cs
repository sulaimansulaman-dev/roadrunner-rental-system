using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Diagnostics;

namespace CMPG223_Project
{
    public partial class Assistant_Menu : Form
    {
        private Form form1;
        int userID = 1;
        public Assistant_Menu(Form previous)
        {
            InitializeComponent();
            form1 = previous;
        }

        private void populateComboBox()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString);
                con.Open();
                string comboBoxSelect = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(comboBoxSelect, con);
                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);
                comboBoxUsers.DataSource = comboTable;
                comboBoxUsers.ValueMember = "User_ID";
                comboBoxUsers.DisplayMember = "Username";
                comboBoxUsers.SelectedIndex = -1;
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
            this.Hide();
            frmClients frmClients = new frmClients();
            frmClients.Closed += (s, args) => this.Show();
            frmClients.ShowDialog();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentalOrder rentalOrder = new rentalOrder(this, userID);
            rentalOrder.Closed += (s, args) => this.Show();
            rentalOrder.ShowDialog();
        }

        private void Assistant_Menu_Load(object sender, EventArgs e)
        {
            populateComboBox();
        }

        private void comboBoxUsers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedIndex > -1)
            {
                buttonClient.Visible = true;
                buttonOrder.Visible = true;
                label1.Visible = false;
                label2.Visible = true;
                userID = (int)comboBoxUsers.SelectedValue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path2 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Resources\\Help Functionality.pdf");
                var psi = new ProcessStartInfo(path2)
                {
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
