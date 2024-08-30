using Microsoft.Data.SqlClient;
using System.Data;

namespace CMPG223_Project
{
    public partial class rentalOrder : Form
    {
        Form form1;
        SqlConnection con = new SqlConnection("Data Source=MOMO;Initial Catalog=\"Roadrunner Rentals\";Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        decimal cost;
        int days;
        public rentalOrder(Form form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                int Client_ID = (int)comboBox1.SelectedValue;
            }
            if (textBox2.Text != null)
            {
                int Vehicle_Id = int.Parse(textBox2.Text);
            }
            if (checkBox1.Checked)
            {
                bool paid = true;
            }





            string insert = "INSERT INTO RentalOrder (Client_ID, User_ID, Vehicle_ID, Time, OrderCost, TimeRented, Paid, VehicleReturned, Date)";

        }

        private void rentalOrder_Load(object sender, EventArgs e)
        {
            populateClients();
            populateDataGridView();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
           
        }
        private void populateDataGridView()
        {
            try
            {

                string select = "SELECT Vehicle.Vehicle_ID, Vehicle.CostPerDay, Vehicle.NumberOfSeats, Vehicle.LicenseNumber, Vehicle_Class.ClassName, Vehicle.ImageOfVehicle FROM Vehicle INNER JOIN Vehicle_Class ON Vehicle.Vehicle_CLass_ID=Vehicle_Class.Vehicle_Class_ID WHERE Vehicle.InUse = 'False'";
                SqlDataAdapter adapter = new SqlDataAdapter(select, con);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void populateClients()
        {
            try
            {
                con.Open();
                string comboBoxSelect = "SELECT * FROM Client";
                SqlDataAdapter adapter = new SqlDataAdapter(comboBoxSelect, con);
                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);
                comboBox1.DataSource = comboTable;
                comboBox1.ValueMember = "Client_ID";
                comboBox1.DisplayMember = "FirstName";
                con.Close();
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                textBox2.Text = row.Cells[0].Value.ToString();
                cost = (decimal)row.Cells[1].Value;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DayCalculator();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DayCalculator();
        }

        private decimal DayCalculator()
        {
            decimal result = 0;
            DateTime date2 = dateTimePicker2.Value;
            DateTime date1 = dateTimePicker1.Value;
            textBox1.Clear();
            if ((date2.DayOfYear - date1.DayOfYear) >= 0 && cost != 0)
            {
                result = (date2.DayOfYear - date1.DayOfYear) * cost;
                days = (date2.DayOfYear - date1.DayOfYear);
                label7.Visible = false;
                textBox1.Text = result.ToString();
                return result;
            }
            else
            {
                label7.Visible = true;
                return result;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            dateTimePicker2.Value = dateTimePicker2.MinDate;
            checkBox1.Checked = false;
            textBox1.Clear();
            label7.Visible = false;
        }
    }
}
