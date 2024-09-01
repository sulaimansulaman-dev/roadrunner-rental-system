using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CMPG223_Project
{


    public partial class frmVehicles : Form
    {
        int classId;
        SqlConnection cnn;
        public frmVehicles()
        {
            InitializeComponent();
        }



        public void displayData()
        {
            //Display Data
            try
            {

                //Opening Connection to the database
                cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                string sql = "SELECT Vehicle.Vehicle_ID, Vehicle.Vehicle_Name, Vehicle_Class.ClassName, Vehicle.Year, Vehicle.NumberOfSeats, Vehicle.CostPerDay, Vehicle.LicenseNumber FROM Vehicle INNER JOIN Vehicle_Class ON Vehicle.Vehicle_Class_ID = Vehicle_Class.Vehicle_Class_ID;"; // <- SELECT statement
                SqlCommand command = new SqlCommand(sql, cnn); // <-Execute an SQL statement against a given datasource

                //Filling the dataset 
                adapter.SelectCommand = command; // <- Set the command for the adpater
                adapter.Fill(ds, "Vehicle"); // <- Fill the DataSet with the results of the SQL command

                //Adding the data into the Data Grid 
                dgvVehicles_Add.DataSource = ds;
                dgvVehicles_Add.DataMember = "Vehicle";

                dgvVehicles_Update.DataSource = ds;
                dgvVehicles_Update.DataMember = "Vehicle";

                dgvVehicles_Delete.DataSource = ds;
                dgvVehicles_Delete.DataMember = "Vehicle";

                cnn.Close();
            }

            //try catch for error handling
            catch
            {
                MessageBox.Show("Please connect to the database first");
                cnn.Close();
            }
        }

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-20CLHAU;Initial Catalog=Roadrunner Rentals;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            cnn = new SqlConnection(connectionstring);

            displayData();

            LoadComboBox();
            LoadComboBoxUpdateClass();
            LoadComboBox_VehicleName();
        }

        private void btnAdd_Add_Click(object sender, EventArgs e)
        {

            string vehicleName = txtName.Text.Trim();
            bool isValid = true;
            // Regular expression patterns for validation
            string alphaPattern = @"^[a-zA-Z\s.,'-]*$";  // Allows letters, spaces, and some punctuation



            //Validation Block
            if (string.IsNullOrWhiteSpace(vehicleName))
            {
                errorProvider1.SetError(txtName, "Please enter Vehicle Name.");
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(vehicleName, alphaPattern))
            {
                errorProvider1.SetError(txtName, "Class Name must contain only letters and allowed punctuation.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtName, "");
            }

            //cmb validation
            if (cmbClassSelect.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbClassSelect, "Please select a class.");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbClassSelect, "");
            }





            // Get values from the form

            if (cmbClassSelect.SelectedValue != null)
            {
                classId = (int)cmbClassSelect.SelectedValue;
            }
            string year1 = txtYear.Text;
            DateTime year = DateTime.ParseExact(year1, "yyyy", null);
            int numOfSeats = int.Parse(cmbNoOfSeats.Text);
            decimal costPerDay = decimal.Parse(txtCostPerDay.Text); // Assuming the TrackBar's Value property is used for the cost
            char[] licenseNo = txtLicenseNo.Text.ToCharArray();


            // Insert query
            string query = "INSERT INTO Vehicle (Vehicle_Class_ID, Year, NumberOfSeats, CostPerDay,LicenseNumber, Vehicle_Name) VALUES (@Vehicle_Class_ID, @Year, @NumberOfSeats, @CostperDay,@LicenseNumber, @Vehicle_Name)";


            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {

                cmd.Parameters.AddWithValue("@Vehicle_Class_ID", classId);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@NumberOfSeats", numOfSeats);
                cmd.Parameters.AddWithValue("@CostperDay", costPerDay);
                cmd.Parameters.AddWithValue("@LicenseNumber", licenseNo);
                cmd.Parameters.AddWithValue("@Vehicle_Name", vehicleName);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }

            MessageBox.Show("Vehicle added successfully!");
            displayData();
            LoadComboBox();
            LoadComboBoxUpdateClass();
            LoadComboBox_VehicleName();

        }



        private void frmVehicles_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Add_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            cmbClassSelect.SelectedIndex = -1;
            txtYear.Text = string.Empty;
            cmbNoOfSeats.SelectedIndex = -1;
            txtCostPerDay.Text = string.Empty;
            txtLicenseNo.Text = string.Empty;
        }

        private void cmbClassSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBox()
        {
            try
            {
                cnn.Open();
                string comboBoxSelect = "SELECT * FROM Vehicle_Class";
                SqlDataAdapter adapter = new SqlDataAdapter(comboBoxSelect, cnn);
                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);
                cmbClassSelect.DataSource = comboTable;
                cmbClassSelect.ValueMember = "Vehicle_Class_ID";
                cmbClassSelect.DisplayMember = "ClassName";
                cnn.Close();
                cmbClassSelect.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadComboBoxUpdateClass()
        {
            try
            {
                cnn.Open();
                string comboBoxSelect = "SELECT * FROM Vehicle_Class";
                SqlDataAdapter adapter = new SqlDataAdapter(comboBoxSelect, cnn);
                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);
                cmbClass_Update.DataSource = comboTable;
                cmbClass_Update.ValueMember = "Vehicle_Class_ID";
                cmbClass_Update.DisplayMember = "ClassName";
                cnn.Close();
                cmbClass_Update.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadComboBox_VehicleName()
        {
            try
            {
                cnn.Open();
                string comboBoxSelect = "SELECT * FROM Vehicle";
                SqlDataAdapter adapter = new SqlDataAdapter(comboBoxSelect, cnn);
                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);
                cmbVehicleID_Delete.DataSource = comboTable;
                cmbVehicleID_Delete.ValueMember = "Vehicle_ID";
                cmbVehicleID_Delete.DisplayMember = "Vehicle_Name";
                cnn.Close();
                cmbVehicleID_Delete.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBack_Add_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Update_Click(object sender, EventArgs e)
        {
            // Variables
            string vehicleID = txtVehicleID_Update.Text.Trim();
            string vehicleName = txtVehicleName_Update.Text.Trim();
            string class1 = cmbClass_Update.Text.Trim();

            string year = txtYear_Update.Text.Trim();
            DateTime year1 = DateTime.Parse(year);

            int numSeats = int.Parse(cmbNoOfSeats_Update.Text.Trim());
            decimal costPDay = decimal.Parse(txtCostPerDay_Update.Text.Trim());
            string license = txtLicenseNo_Update.Text.Trim();



            // Preparing the SQL update query
            string updateQuery = "UPDATE Vehicle SET Vehicle_Name = @VehicleName, Vehicle_Class_ID = @ClassName, Year = @Year, NumberOfSeats = @NumberOfSeats, CostPerDay = @CostPerDay, LicenseNumber = @License WHERE Vehicle_ID = @Vehicle_ID";

            try
            {
                // Open the connection if it's not already open
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                // Using the existing connection to execute the update command
                using (SqlCommand cmd = new SqlCommand(updateQuery, cnn))
                {
                    cmd.Parameters.AddWithValue("@VehicleName", vehicleName);
                    cmd.Parameters.AddWithValue("@ClassName", class1);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@NumberOfSeats", numSeats);
                    cmd.Parameters.AddWithValue("@CostPerDay", costPDay);
                    cmd.Parameters.AddWithValue("@License", license);
                    cmd.Parameters.AddWithValue("@Vehicle_ID", vehicleID);

                    // Debugging output
                    Console.WriteLine($"Executing Query: {updateQuery}");
                    Console.WriteLine($"VehicleName: {vehicleName}, ClassName: {class1}, Year: {year}, NumberOfSeats: {numSeats}, CostPerDay: {costPDay}, License: {license}, Vehicle_ID: {vehicleID}");

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Vehicle updated successfully.");
                        displayData();
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check if the Vehicle ID exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection if it's still open
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        private void btnDelete_Delete_Click(object sender, EventArgs e)
        {
            if (cmbVehicleID_Delete.SelectedValue != null)
            {
                int vehicleId = (int)cmbVehicleID_Delete.SelectedValue;

                string query = "DELETE FROM Vehicle WHERE Vehicle_ID = @Vehicle_ID";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Vehicle_ID", vehicleId);

                    try
                    {
                        cnn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        cnn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle deleted successfully!");
                            displayData();
                            LoadComboBox();
                            LoadComboBoxUpdateClass();
                            LoadComboBox_VehicleName();
                        }
                        else
                        {
                            MessageBox.Show("No vehicle found with the selected ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete.");
            }
        }

        private void cmbVehicleID_Update_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtVehicleName_Update_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cmbClass_Update_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dgvVehicles_Update_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehicles_Update.CurrentRow != null)
            {

                DataGridViewRow selectedRow = dgvVehicles_Update.CurrentRow;


                string vehicleId = selectedRow.Cells["Vehicle_ID"].Value.ToString();
                string vehicleName = selectedRow.Cells["Vehicle_Name"].Value.ToString();
                string className = selectedRow.Cells["ClassName"].Value.ToString();
                string sYear = selectedRow.Cells["Year"].Value.ToString();
                string numOfSeats = selectedRow.Cells["NumberOfSeats"].Value.ToString();
                string cost = selectedRow.Cells["CostPerDay"].Value.ToString();
                string license = selectedRow.Cells["LicenseNumber"].Value.ToString();



                txtVehicleID_Update.Text = vehicleId;
                txtVehicleName_Update.Text = vehicleName;
                cmbClass_Update.Text = className;
                txtYear_Update.Text = sYear;
                cmbNoOfSeats_Update.Text = numOfSeats;
                txtCostPerDay_Update.Text = cost;
                txtLicenseNo_Update.Text = license;

            }
        }

        private void dgvVehicles_Delete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvVehicles_Update.CurrentRow;
            
            string vehicleName = selectedRow.Cells["Vehicle_Name"].Value.ToString();

            cmbVehicleID_Delete.Text = vehicleName;
        }
    }
}
