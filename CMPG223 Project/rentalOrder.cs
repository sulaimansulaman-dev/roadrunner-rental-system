using Microsoft.Data.SqlClient;
using System.CodeDom;
using System.Data;
using System.Windows.Forms;

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
        int Order_ID = 0;
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

                if (checkBoxAdd.Checked)
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
                    string insert = "INSERT INTO RentalOrder (Client_ID, User_ID, Vehicle_ID, Time, OrderCost, TimeRented, Paid, VehicleReturned, Date) VALUES(@Client_ID, @User_ID, @Vehicle_ID, @Time, @OrderCost, @DaysRented, @Paid, @VehicleReturned, @Date)";
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
                    string vehicleInUse = "UPDATE Vehicle SET InUse= @InUse WHERE Vehicle_ID = @ID";
                    SqlCommand command = new SqlCommand(vehicleInUse, con);
                    command.Parameters.AddWithValue("@InUse", true);
                    command.Parameters.AddWithValue("@ID", vehicleID);
                    command.ExecuteNonQuery();
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Added successfully");
                        populateDataGridView(dataGridViewAdd, "SELECT Vehicle.Vehicle_ID, Vehicle.Vehicle_Name, Vehicle.CostPerDay, Vehicle.NumberOfSeats, Vehicle_Class.ClassName FROM Vehicle INNER JOIN Vehicle_Class ON Vehicle.Vehicle_CLass_ID=Vehicle_Class.Vehicle_Class_ID WHERE Vehicle.InUse = 'false'");
                        buttonClear_Click(sender, e);
                    }
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
            populateClients(comboBox1);
            populateDataGridView(dataGridViewAdd, "SELECT Vehicle.Vehicle_ID, Vehicle.Vehicle_Name, Vehicle.CostPerDay, Vehicle.NumberOfSeats, Vehicle_Class.ClassName FROM Vehicle INNER JOIN Vehicle_Class ON Vehicle.Vehicle_CLass_ID=Vehicle_Class.Vehicle_Class_ID WHERE Vehicle.InUse = 'false'");
            populateDataGridView(dataGridViewUpdate, "SELECT RentalOrder.Order_ID, Client.FirstName, Client.LastName, Client.Email, Client.CellNumber, Vehicle.Vehicle_Name, RentalOrder.Date, RentalOrder.Paid, RentalOrder.VehicleReturned FROM RentalOrder INNER JOIN Vehicle ON Vehicle.Vehicle_ID = RentalOrder.Vehicle_ID INNER JOIN Client ON Client.Client_ID = RentalOrder.Client_ID");
            populateDataGridView(dataGridViewReturn, "SELECT RentalOrder.Order_ID, Client.FirstName, Client.LastName, Client.Email, Client.CellNumber, Vehicle.Vehicle_Name, RentalOrder.Date, RentalOrder.Paid, RentalOrder.VehicleReturned FROM RentalOrder INNER JOIN Vehicle ON Vehicle.Vehicle_ID = RentalOrder.Vehicle_ID INNER JOIN Client ON Client.Client_ID = RentalOrder.Client_ID");
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
            label7.Visible = false;
            label10.Visible = false;
        }
        private void populateDataGridView(DataGridView dataGridView, string select)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(select, con);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView.ReadOnly = true;
                dataGridView.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void populateClients(ComboBox comboBox)
        {
            try
            {
                con.Open();
                string comboBoxSelect = "SELECT * FROM Client";
                SqlDataAdapter adapter = new SqlDataAdapter(comboBoxSelect, con);
                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);
                comboTable.Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
                comboBox.DataSource = comboTable;
                comboBox.ValueMember = "Client_ID";
                comboBox.DisplayMember = "FullName";
                comboBox.SelectedIndex = -1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                cost = (decimal)row.Cells[2].Value;
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
            checkBoxAdd.Checked = false;
            textBox1.Clear();
            label7.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            cost = 0;
            days = 0;
            vehicleID = 0;
            paid = false;
            isValid = true;
            Client_ID = 0;
        }

        private void dataGridViewUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                if (indexRow >= 0)
                {
                    con.Open();
                    DataGridViewRow row = dataGridViewUpdate.Rows[indexRow];
                    textBoxOrderUpdate.Text = row.Cells[0].Value.ToString();
                    Order_ID = (int)row.Cells[0].Value;
                    textBoxOrderUpdate.Text = Order_ID.ToString();
                    string query = "SELECT Paid FROM RentalOrder WHERE Order_ID = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    sqlCommand.Parameters.AddWithValue("@ID", Order_ID);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        if ((bool)reader["Paid"] == true)
                        {
                            checkBoxUpdate.Checked = true;
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            {

            }

        }

        private void button3_Click(object sender, EventArgs e) // Payment form update button
        {
            try
            {
                bool valid = true;
                if (Order_ID == 0)
                {
                    valid = false;
                    label17.Visible = true;
                }
                if (valid)
                {
                    con.Open();
                    label17.Visible = false;
                    string query = "UPDATE RentalOrder SET Paid = @Paid WHERE Order_ID = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    sqlCommand.Parameters.AddWithValue("@ID", Order_ID);
                    sqlCommand.Parameters.AddWithValue("@Paid", checkBoxUpdate.Checked);
                    int rowsaffected = sqlCommand.ExecuteNonQuery();
                    if (rowsaffected > 0)
                    {
                        MessageBox.Show("Succesfully Updated");
                        button2_Click(sender, e);
                    }
                    con.Close();
                    populateDataGridView(dataGridViewUpdate, "SELECT RentalOrder.Order_ID, Client.FirstName, Client.LastName, Client.Email, Client.CellNumber, Vehicle.Vehicle_Name, RentalOrder.Date, RentalOrder.Paid, RentalOrder.VehicleReturned FROM RentalOrder INNER JOIN Vehicle ON Vehicle.Vehicle_ID = RentalOrder.Vehicle_ID INNER JOIN Client ON Client.Client_ID = RentalOrder.Client_ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOrderUpdate.Text = string.Empty;
            checkBoxUpdate.Checked = false;
            textBoxSearchUpdate.Text = string.Empty;
            Order_ID = 0;
            label17.Visible = false;
            vehicleID = 0;
        }

        private void textBoxSearchUpdate_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchUpdate.Text.Trim();
            (dataGridViewUpdate.DataSource as DataTable).DefaultView.RowFilter = string.Format("LastName like '{0}%' OR Vehicle_Name like '{0}%' OR FirstName like '{0}%' OR Email like '{0}%' OR CellNumber like '{0}%'", searchTerm);
        }

        private void textBoxSearchAdd_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchAdd.Text.Trim();
            (dataGridViewAdd.DataSource as DataTable).DefaultView.RowFilter = string.Format("ClassName like '{0}%' OR Vehicle_Name like '{0}%'", searchTerm);

        }



        private void dataGridViewReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                if (indexRow >= 0)
                {
                    con.Open();
                    DataGridViewRow row = dataGridViewReturn.Rows[indexRow];
                    textBoxOrderUpdate.Text = row.Cells[0].Value.ToString();
                    Order_ID = (int)row.Cells[0].Value;
                    textBoxReturnOrder.Text = Order_ID.ToString();
                    string query = "SELECT * FROM RentalOrder WHERE Order_ID = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    sqlCommand.Parameters.AddWithValue("@ID", Order_ID);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        vehicleID = (int)reader["Vehicle_ID"];

                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            {

            }
        }

        private void textBoxReturnSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxReturnSearch.Text.Trim();
            (dataGridViewReturn.DataSource as DataTable).DefaultView.RowFilter = string.Format("LastName like '{0}%' OR Vehicle_Name like '{0}%' OR FirstName like '{0}%' OR Email like '{0}%' OR CellNumber like '{0}%'", searchTerm);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                buttonClear_Click(sender, e);
                populateDataGridView(dataGridViewAdd, "SELECT Vehicle.Vehicle_ID, Vehicle.Vehicle_Name, Vehicle.CostPerDay, Vehicle.NumberOfSeats, Vehicle_Class.ClassName FROM Vehicle INNER JOIN Vehicle_Class ON Vehicle.Vehicle_CLass_ID=Vehicle_Class.Vehicle_Class_ID WHERE Vehicle.InUse = 'false'");

            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                button2_Click(sender, e);
                populateDataGridView(dataGridViewUpdate, "SELECT RentalOrder.Order_ID, Client.FirstName, Client.LastName, Client.Email, Client.CellNumber, Vehicle.Vehicle_Name, RentalOrder.Date, RentalOrder.Paid, RentalOrder.VehicleReturned FROM RentalOrder INNER JOIN Vehicle ON Vehicle.Vehicle_ID = RentalOrder.Vehicle_ID INNER JOIN Client ON Client.Client_ID = RentalOrder.Client_ID");

            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                buttonClearReturn_Click(sender, e);
                populateDataGridView(dataGridViewReturn, "SELECT RentalOrder.Order_ID, Client.FirstName, Client.LastName, Client.Email, Client.CellNumber, Vehicle.Vehicle_Name, RentalOrder.Date, RentalOrder.Paid, RentalOrder.VehicleReturned FROM RentalOrder INNER JOIN Vehicle ON Vehicle.Vehicle_ID = RentalOrder.Vehicle_ID INNER JOIN Client ON Client.Client_ID = RentalOrder.Client_ID");

            }
        }

        private void buttonUpdateReturn_Click(object sender, EventArgs e)
        {
            try
            {
                bool valid = true;
                if (Order_ID == 0)
                {
                    valid = false;
                    label18.Visible = true;
                }
                if (valid)
                {
                    con.Open();
                    label18.Visible = false;
                    string query = "UPDATE RentalOrder SET VehicleReturned = @Returned WHERE Order_ID = @ID";
                    string queryVehicle = "UPDATE Vehicle SET InUse = @InUse WHERE Vehicle_ID = @ID";
                    SqlCommand vehiclecmd = new SqlCommand(queryVehicle, con);
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    sqlCommand.Parameters.AddWithValue("@ID", Order_ID);
                    sqlCommand.Parameters.AddWithValue("@Returned", true);
                    vehiclecmd.Parameters.AddWithValue("@ID", vehicleID);
                    vehiclecmd.Parameters.AddWithValue("@InUse", false);
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Vehicle Returned Succesfully");
                        vehiclecmd.ExecuteNonQuery();
                    }
                    populateDataGridView(dataGridViewReturn, "SELECT RentalOrder.Order_ID, Client.FirstName, Client.LastName, Client.Email, Client.CellNumber, Vehicle.Vehicle_Name, RentalOrder.Date, RentalOrder.Paid, RentalOrder.VehicleReturned FROM RentalOrder INNER JOIN Vehicle ON Vehicle.Vehicle_ID = RentalOrder.Vehicle_ID INNER JOIN Client ON Client.Client_ID = RentalOrder.Client_ID");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClearReturn_Click(object sender, EventArgs e)
        {
            Order_ID = 0;
            textBoxReturnOrder.Text = string.Empty;
            textBoxReturnSearch.Text = string.Empty;
            vehicleID = 0;
            label18.Visible = false;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
