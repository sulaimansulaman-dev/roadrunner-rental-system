using Microsoft.Data.SqlClient;
using System.Data;

namespace CMPG223_Project
{
    public partial class rentalOrder : Form
    {
        Form form1;
        SqlConnection con = new SqlConnection("Data Source=MOMO;Initial Catalog=\"Roadrunner Rentals\";Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        decimal cost = 0;
        int days = 0;
        int vehicleID = 0;
        int userID = 0;
        bool paid = false;
        bool isValid = true;
        int Client_ID = 0;
        public rentalOrder(Form form1, int userID)
        {
            InitializeComponent();
            this.form1 = form1;
            this.userID = userID;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    Client_ID = (int)comboBox1.SelectedValue;
                    label9.Visible = false;
                }
                else
                {
                    label9.Visible = true;
                    isValid = false;
                }

                if (checkBox1.Checked)
                {
                    paid = true;
                }

                if (vehicleID == 0)
                {
                    label10.Visible = true;
                    isValid = false;
                }
                if (days == 0)
                {
                    isValid = false;
                }
                if (cost == 0)
                {
                    isValid = false;
                }
                DayCalculator();
                TimeSpan time = DateTime.Now.TimeOfDay;
                DateTime date = DateTime.Now.Date;
                bool vehicleReturned = false;
                if (isValid == true)
                {
                    con.Open();
                    string insert = "INSERT INTO RentalOrder (Client_ID, User_ID, Vehicle_ID, Time, OrderCost, DaysRented, Paid, VehicleReturned, Date) VALUES(@Client_ID, @User_ID, @Vehicle_ID, @Time, @OrderCost, @DaysRented, @Paid, @VehicleReturned, @Date)";
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Client_ID", Client_ID);
                    cmd.Parameters.AddWithValue("@Paid", paid);
                    cmd.Parameters.AddWithValue("@User_ID", userID);
                    cmd.Parameters.AddWithValue("@Vehicle_ID", vehicleID);
                    cmd.Parameters.AddWithValue("@Time", time);
                    cmd.Parameters.AddWithValue("@OrderCost", cost);
                    cmd.Parameters.AddWithValue("@DaysRented", days);
                    cmd.Parameters.AddWithValue("@VehicleReturned", vehicleReturned);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully");
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }




        }

        private void rentalOrder_Load(object sender, EventArgs e)
        {
            populateClients();
            populateDataGridView();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
            label7.Visible = false;
            label10.Visible = false;

        }
        private void populateDataGridView()
        {
            try
            {

                string select = "SELECT Vehicle.Vehicle_ID, Vehicle.CostPerDay, Vehicle.NumberOfSeats, Vehicle_Class.ClassName FROM Vehicle INNER JOIN Vehicle_Class ON Vehicle.Vehicle_CLass_ID=Vehicle_Class.Vehicle_Class_ID WHERE Vehicle.InUse = 'False'";
                SqlDataAdapter adapter = new SqlDataAdapter(select, con);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridViewAdd.ReadOnly = true;
                dataGridViewAdd.DataSource = dataSet.Tables[0];

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
                DataGridViewRow row = dataGridViewAdd.Rows[indexRow];
                textBox2.Text = row.Cells[0].Value.ToString();
                vehicleID = (int)row.Cells[0].Value;
                label10.Visible = false;
                cost = (decimal)row.Cells[1].Value;
                DayCalculator();
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
            if ((date2.DayOfYear - date1.DayOfYear) >= 0 && cost != 0 && vehicleID != 0)
            {
                result = (date2.DayOfYear - date1.DayOfYear) * cost;
                days = (date2.DayOfYear - date1.DayOfYear);
                label7.Visible = false;
                isValid = true;
                textBox1.Text = result.ToString();
                return result;
            }
            else
            {
                if (vehicleID == 0)
                {
                    label10.Visible = true;

                }
                if ((date2.DayOfYear - date1.DayOfYear) <= 0)
                {
                    label7.Visible = true;

                }
                isValid = false;
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
            label10.Visible = false;
            label9.Visible = false;
            cost = 0;
            days = 0;
            vehicleID = 0;
            userID = 0;
            paid = false;
            isValid = true;
            Client_ID = 0;
        }

        private void dataGridViewUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                DataGridViewRow row = dataGridViewAdd.Rows[indexRow];
                textBox2.Text = row.Cells[0].Value.ToString();
                vehicleID = (int)row.Cells[0].Value;
                label10.Visible = false;
                cost = (decimal)row.Cells[1].Value;
            }
        }
    }
}
