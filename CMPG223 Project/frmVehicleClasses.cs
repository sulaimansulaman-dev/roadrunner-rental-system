using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CMPG223_Project
{

    public partial class frmVehicleClasses : Form
    {
        string connectionString = @"Data Source=MOMO;Initial Catalog=Roadrunner Rentals;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";




        public frmVehicleClasses()
        {
            InitializeComponent();
        }

        private void frmVehicleClasses_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnAdd_Add_Click(object sender, EventArgs e)
        {
            //Variables 

            //VALIDATION BEGIN
            string className = txtClassName_Add.Text.Trim();
            string description = txtDescription_Add.Text.Trim();


            bool isValid = true;

            // Regular expression patterns for validation
            string alphaPattern = @"^[a-zA-Z\s.,'-]*$";  // Allows letters, spaces, and some punctuation

            // Validation using ErrorProvider
            if (string.IsNullOrWhiteSpace(className))
            {
                errorProvider1.SetError(txtClassName_Add, "Class Name is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(className, alphaPattern))
            {
                errorProvider1.SetError(txtClassName_Add, "Class Name must contain only letters and allowed punctuation.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtClassName_Add, "");
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                errorProvider1.SetError(txtDescription_Add, "Description is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(description, alphaPattern))
            {
                errorProvider1.SetError(txtDescription_Add, "Description must contain only letters and allowed punctuation.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtDescription_Add, "");
            }

            if (!isValid)
            {
                
                return;
            }

            
            

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Check for duplicates
                string checkQuery = "SELECT COUNT(*) FROM Vehicle_Class WHERE ClassName = @ClassName";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@ClassName", className);

                try
                {
                    conn.Open();

                    // Check whether ClassName already Exists in SQL Server
                    //Executes the query and returns the first column of the first row in the result set returned by the query, ignores any additional column or rows. 
                    //Cast to int because of COUNT(*) which returns a numerical value, the number of rows which match
                    //Used to Check For Duplicates
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        errorProvider1.SetError(txtClassName_Add, "Class Name already exists.");
                        
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtClassName_Add, "");
                    }

                    //VALIDATION END

                    //LOGIC BEGIN

                    string query = "INSERT INTO Vehicle_Class (ClassName, Description) VALUES(@ClassName, @Description)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ClassName", className);
                    cmd.Parameters.AddWithValue("@Description", description);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle class added successfully");

                    LoadData();
                    btnClear_Add_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                //LOGIC END
            }
        }




        private void btnBack_Add_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Add_Click(object sender, EventArgs e)
        {
            txtClassName_Add.Clear();
            txtDescription_Add.Clear();
        }

        private void btnClear_Update_Click(object sender, EventArgs e)
        {
            txtClassID_Update.Clear();
            txtClassName_Update.Clear();
            txtDescription_Update.Clear();
        }

        private void btnDelete_Delete_Click(object sender, EventArgs e)
        {
            //Validation
            string className = txtClassName_Delete.Text.Trim();

            //VALIDATION BEGIN

            // Initialize ErrorProvider component 
            bool isValid = true;

            // Regular expression pattern for validation
            string alphaPattern = @"^[a-zA-Z\s.,'-]*$";  // Allows letters, spaces, and some punctuation

            // Check if all fields are empty
            if (string.IsNullOrWhiteSpace(className))
            {
                MessageBox.Show("Please click on the Data Grid View.");
                return;
            }
            // Validation using ErrorProvider
            if (string.IsNullOrWhiteSpace(className))
            {
                errorProvider1.SetError(txtClassName_Delete, "Class Name is required.");
                
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(className, alphaPattern))
            {
                errorProvider1.SetError(txtClassName_Delete, "Class Name must contain only letters and allowed punctuation.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtClassName_Delete, "");
            }

            if (!isValid)
            {
                //MessageBox.Show("Please correct the errors before deleting.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this vehicle class in the database?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            //VALIDATION END

            //LOGIC BEGIN

            string selectedClassName = className;

            string delete_query = "DELETE FROM Vehicle_Class WHERE Vehicle_Class_ID = (SELECT Vehicle_Class_ID FROM Vehicle_Class WHERE ClassName = @ClassName)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(delete_query, con))
                    {
                        cmd.Parameters.AddWithValue("@ClassName", selectedClassName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle class deleted successfully.");
                        }
                        else
                        {
                            //MessageBox.Show("No vehicle class found with the specified name.");
                        }

                        LoadData();
                        txtClassName_Delete.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            //LOGIC END
        }



        private void btnUpdate_Update_Click(object sender, EventArgs e)
        {
            //Variables


            string classID = txtClassID_Update.Text.Trim();
            string className = txtClassName_Update.Text.Trim();
            string description = txtDescription_Update.Text.Trim();

            //VALIDATION BEGIN

            // Initialize ErrorProvider component 
            bool isValid = true;

            // Regular expression pattern for validation
            string alphaPattern = @"^[a-zA-Z\s.,'-]*$";  // Allows letters, spaces, and some punctuation

            // Check if all fields are empty
            if (string.IsNullOrWhiteSpace(classID) &&
                string.IsNullOrWhiteSpace(className) &&
                string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please click on the Data Grid View.");
                return;
            }

            // Validation using ErrorProvider
            if (string.IsNullOrWhiteSpace(classID))
            {
                errorProvider1.SetError(txtClassID_Update, "Class ID is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtClassID_Update, "");
            }

            if (string.IsNullOrWhiteSpace(className))
            {
                errorProvider1.SetError(txtClassName_Update, "Class Name is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(className, alphaPattern))
            {
                errorProvider1.SetError(txtClassName_Update, "Class Name must contain only letters and allowed punctuation.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtClassName_Update, "");
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                errorProvider1.SetError(txtDescription_Update, "Description is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtDescription_Update, "");
            }

            if (!isValid)
            {
                //MessageBox.Show("Please correct the errors before updating.");
                return;
            }

            //VALIDATION END



            //Variables
            string vehicleClassID = classID;
            string newClassName = className;
            string newDescription = description;

            //LOGIC BEGIN

            string updateQuery = "UPDATE Vehicle_Class SET ClassName = @ClassName, Description = @Description WHERE Vehicle_Class_ID = @VehicleClassID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ClassName", newClassName);
                        cmd.Parameters.AddWithValue("@Description", newDescription);
                        cmd.Parameters.AddWithValue("@VehicleClassID", vehicleClassID);

                        // Debugging output
                        Console.WriteLine($"Executing Query: {updateQuery}");
                        Console.WriteLine($"ClassName: {newClassName}, Description: {newDescription}, VehicleClassID: {vehicleClassID}");

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle class updated successfully.");
                            LoadData();

                            txtClassID_Update.Clear();
                            txtClassName_Update.Clear();
                            txtDescription_Update.Clear();
                        }
                        else
                        {
                            //MessageBox.Show("No records were updated. Please check if the Vehicle Class ID exists.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //LOGIC END
        }



        //Load Data, Loades the Data into the Data Grid View
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Vehicle_Class";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvVehicleClasses_Add.DataSource = dt;
                    dgvVehicleClasses_Delete.DataSource = dt;
                    dgvVehicleClasses_Update.DataSource = dt;
                }
                con.Close();
            }
        }


        //Search Function for the Vehicle Class Field In The Data Grid View
        private void txtSearch_Update_TextChanged(object sender, EventArgs e)
        {


            string searchTerm = txtSearch_Update.Text.Trim();


            if (dgvVehicleClasses_Update.DataSource is DataTable dataTable)
            {

                dataTable.DefaultView.RowFilter = $"ClassName LIKE '%{searchTerm}%'";
            }
            else
            {

                foreach (DataGridViewRow row in dgvVehicleClasses_Update.Rows)
                {

                    if (row.Cells["ClassName"].Value != null &&
                        row.Cells["ClassName"].Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }



        }

        //Search Function for the Vehicle Class Field In The Data Grid View
        private void txtSearch_Add_TextChanged(object sender, EventArgs e)
        {

            string searchTerm = txtSearch_Add.Text.Trim();


            if (dgvVehicleClasses_Add.DataSource is DataTable dataTable)
            {

                dataTable.DefaultView.RowFilter = $"ClassName LIKE '%{searchTerm}%'";
            }
            else
            {

                foreach (DataGridViewRow row in dgvVehicleClasses_Add.Rows)
                {

                    if (row.Cells["ClassName"].Value != null &&
                        row.Cells["ClassName"].Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        //Search Function for the Vehicle Class Field In The Data Grid View
        private void txtSearch_Delete_TextChanged(object sender, EventArgs e)
        {

            string searchTerm = txtSearch_Delete.Text.Trim();


            if (dgvVehicleClasses_Delete.DataSource is DataTable dataTable)
            {

                dataTable.DefaultView.RowFilter = $"ClassName LIKE '%{searchTerm}%'";
            }
            else
            {

                foreach (DataGridViewRow row in dgvVehicleClasses_Delete.Rows)
                {

                    if (row.Cells["ClassName"].Value != null &&
                        row.Cells["ClassName"].Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        private void btnClear_Delete_Click(object sender, EventArgs e)
        {
            txtClassName_Delete.Clear();

        }




        private void btnBack_Update_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVehicleClasses_Update_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Adds the Data Grid View Components to the TextBoxes in Update
        private void dgvVehicleClasses_Update_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehicleClasses_Update.CurrentRow != null)
            {

                DataGridViewRow selectedRow = dgvVehicleClasses_Update.CurrentRow;


                string classID = selectedRow.Cells["Vehicle_Class_ID"].Value.ToString();
                string className = selectedRow.Cells["ClassName"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();


                txtClassID_Update.Text = classID;
                txtClassName_Update.Text = className;
                txtDescription_Update.Text = description;
            }

        }

        //Adds the Data Grid View Components to the TextBoxes in Update
        private void dgvVehicleClasses_Delete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehicleClasses_Delete.CurrentRow != null)
            {

                DataGridViewRow selectedRow = dgvVehicleClasses_Delete.CurrentRow;



                string className = selectedRow.Cells["ClassName"].Value.ToString();




                txtClassName_Delete.Text = className;

            }

        }




        private void lblClassName_Add_Click(object sender, EventArgs e)
        {

        }


        private void btnBack_Delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVehicleClasses_Add_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVehicleClasses_Delete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}