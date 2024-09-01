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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CMPG223_Project
{
    public partial class frmClients : Form
    {

        //Mo Kalla: public string connectionString = @"Data Source=LAPTOP-9FK1U57R;Initial Catalog=Roadrunner Rentals;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private string connectionString = @"Data Source=MOMO;Initial Catalog=Roadrunner Rentals;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";


        public frmClients()
        {
            InitializeComponent();
        }

        private void btnAdd_AddClients_Click(object sender, EventArgs e)
        {
            // Validation
            string clientIDNumber = txtClient_ID_Number_AddClient.Text.Trim();
            string firstName = txtFirstName_AddClient.Text.Trim();
            string lastName = txtLastName_AddClient.Text.Trim();
            string cellNumber = txtCellNumber_AddClient.Text.Trim();
            string email = txtEmail_AddClient.Text.Trim();

            // Determine the value based on the checkbox
            bool hasDriversLicense = chkbYes_HasDriversLicense_AddClient.Checked;

            bool isValid = true;

            // Regular expression patterns for validation
            string alphaPattern = @"^[a-zA-Z\s.,'-]*$";  // Allows letters, spaces, and some punctuation
            string numericPattern = @"^\d+$";  // Allows only numbers
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";  // Basic email validation pattern

            // Validation using ErrorProvider
            if (string.IsNullOrWhiteSpace(clientIDNumber))
            {
                errorProvider1.SetError(txtClient_ID_Number_AddClient, "Client ID Number is required.");
                isValid = false;
            }
            else if (clientIDNumber.Length != 13 || !System.Text.RegularExpressions.Regex.IsMatch(clientIDNumber, numericPattern))
            {
                errorProvider1.SetError(txtClient_ID_Number_AddClient, "Client ID Number must be exactly 13 digits.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtClient_ID_Number_AddClient, "");
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                errorProvider1.SetError(txtFirstName_AddClient, "First Name is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(firstName, alphaPattern))
            {
                errorProvider1.SetError(txtFirstName_AddClient, "First Name must contain only letters and allowed punctuation.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtFirstName_AddClient, "");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                errorProvider1.SetError(txtLastName_AddClient, "Last Name is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(lastName, alphaPattern))
            {
                errorProvider1.SetError(txtLastName_AddClient, "Last Name must contain only letters and allowed punctuation.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtLastName_AddClient, "");
            }

            if (string.IsNullOrWhiteSpace(cellNumber))
            {
                errorProvider1.SetError(txtCellNumber_AddClient, "Cell Number is required.");
                isValid = false;
            }
            else if (cellNumber.Length != 10 || !System.Text.RegularExpressions.Regex.IsMatch(cellNumber, numericPattern))
            {
                errorProvider1.SetError(txtCellNumber_AddClient, "Cell Number must be exactly 10 digits.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtCellNumber_AddClient, "");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txtEmail_AddClient, "Email is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                errorProvider1.SetError(txtEmail_AddClient, "Email must be a valid email address.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail_AddClient, "");
            }

            // Check if the checkbox is checked
            if (!chkbYes_HasDriversLicense_AddClient.Checked)
            {
                errorProvider1.SetError(chkbYes_HasDriversLicense_AddClient, "Please check this box if the client has a driver's license.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(chkbYes_HasDriversLicense_AddClient, "");
            }

            if (!isValid)
            {
                //MessageBox.Show("Please correct the errors before adding.");
                return;
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Check for duplicates
                string checkQuery = "SELECT COUNT(*) FROM Client WHERE Client_ID_Number = @ClientIDNumber";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@ClientIDNumber", clientIDNumber);

                try
                {
                    conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        errorProvider1.SetError(txtClient_ID_Number_AddClient, "Client ID Number already exists.");
                        //MessageBox.Show("Client ID Number already exists in the database. Please check if you are entering it correctly.");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtClient_ID_Number_AddClient, "");
                    }

                    string query = "INSERT INTO Client (Client_ID_Number, FirstName, LastName, CellNumber, Email, HasDriversLicense) VALUES (@ClientIDNumber, @FirstName, @LastName, @CellNumber, @Email, @HasDriversLicense)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ClientIDNumber", clientIDNumber);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@CellNumber", cellNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@HasDriversLicense", hasDriversLicense);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client added successfully");

                    LoadData();
                    btnClear_AddClients_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnClear_AddClients_Click(object sender, EventArgs e)
        {
            txtClient_ID_Number_AddClient.Clear();
            txtFirstName_AddClient.Clear();
            txtLastName_AddClient.Clear();
            txtCellNumber_AddClient.Clear();
            txtEmail_AddClient.Clear();
            chkbYes_HasDriversLicense_AddClient.Checked = false;
            txtClient_ID_Number_AddClient.Focus();
        }

        private void btnClear_UpdateClient_Click(object sender, EventArgs e)
        {
            txtClient_ID_UpdateClient.Clear();
            txtClient_ID_Number_UpdateClient.Clear();
            txtFirstName_UpdateClient.Clear();
            txtLastName_UpdateClient.Clear();
            txtCellNumber_UpdateClient.Clear();
            txtEmail_UpdateClient.Clear();
            chkbYesHasDriversLicense_UpdateClient.Checked = false;
            txtClient_ID_UpdateClient.Focus();
        }

        private void btnClear_DeleteClient_Click(object sender, EventArgs e)
        {
            txtClient_ID_DeleteClient.Clear();
        }


        private void frmClients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_DeleteClient_Click(object sender, EventArgs e)
        {
            string Client_ID = txtClient_ID_DeleteClient.Text;

            // Initialize ErrorProvider component 
            bool isValid = true;

            // Regular expression pattern for validation
            string numericPattern = @"^\d+$";  // Allows only numbers

            // Check if all fields are empty
            if (string.IsNullOrWhiteSpace(Client_ID))

            {
                MessageBox.Show("Please click on the Data Grid View.");
                return;
            }

            // Validation using ErrorProvider
            if (string.IsNullOrWhiteSpace(Client_ID))
            {
                errorProvider1.SetError(txtClient_ID_DeleteClient, "Client_ID is required.");
                MessageBox.Show("Please click on a field in the data grid view!");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Client_ID, numericPattern))
            {
                errorProvider1.SetError(txtClient_ID_DeleteClient, "Client_ID must contain only numbers.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtClient_ID_DeleteClient, "");
            }

            if (!isValid)
            {
                // MessageBox.Show("Please correct the errors before deleting.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this Client in the database?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            string selectedClient_ID = Client_ID;

            string sqlDelete = "DELETE FROM Client WHERE Client_ID = @Client_ID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlDelete, con))
                    {
                        cmd.Parameters.AddWithValue("@Client_ID", selectedClient_ID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client deleted successfully.");
                            errorProvider1.SetError(txtClient_ID_DeleteClient, "");  // Clear any error message after successful deletion
                        }
                        else
                        {
                            // MessageBox.Show("No Client found with the specified ID.");
                        }

                        LoadData();
                        txtClient_ID_DeleteClient.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the client: " + ex.Message);
                }
            }
        }


        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Client";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        DataTable dtAddClient = dt.Copy();
                        DataTable dtDeleteClient = dt.Copy();
                        DataTable dtUpdateClient = dt.Copy();

                        dgvAddClient.DataSource = dtAddClient;
                        dgvDeleteClient.DataSource = dtDeleteClient;
                        dgvUpdateClient.DataSource = dtUpdateClient;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }


        private void btnUpdate_UpdateClient_Click(object sender, EventArgs e)
        {
            // Validation
            string clientID = txtClient_ID_UpdateClient.Text.Trim();
            string clientIDNumber = txtClient_ID_Number_UpdateClient.Text.Trim();
            string firstName = txtFirstName_UpdateClient.Text.Trim();
            string lastName = txtLastName_UpdateClient.Text.Trim();
            string cellNumber = txtCellNumber_UpdateClient.Text.Trim();
            string email = txtEmail_UpdateClient.Text.Trim();

            // Determine the value based on the checkbox
            bool hasDriversLicense = chkbYesHasDriversLicense_UpdateClient.Checked;

            bool isValid = true;

            // Regular expression patterns for validation
            string alphaPattern = @"^[a-zA-Z\s.,'-]*$";  // Allows letters, spaces, and some punctuation
            string numericPattern = @"^\d+$";  // Allows only numbers
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";  // Basic email validation pattern


            // Check if all fields are empty
            if (string.IsNullOrWhiteSpace(clientID) &&
                string.IsNullOrWhiteSpace(clientIDNumber) &&
                string.IsNullOrWhiteSpace(firstName) &&
                string.IsNullOrWhiteSpace(lastName) &&
                string.IsNullOrWhiteSpace(cellNumber) &&
                string.IsNullOrWhiteSpace(email) &&
                !hasDriversLicense)
            {
                MessageBox.Show("Please click on the Data Grid View.");
                return;
            }

            // Validation using ErrorProvider
            if (string.IsNullOrWhiteSpace(clientID))
            {
                errorProvider1.SetError(txtClient_ID_UpdateClient, "Client ID is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtClient_ID_UpdateClient, "");
            }

            if (string.IsNullOrWhiteSpace(clientIDNumber))
            {
                errorProvider1.SetError(txtClient_ID_Number_UpdateClient, "Client ID Number is required.");
                isValid = false;
            }
            else if (clientIDNumber.Length != 13 || !System.Text.RegularExpressions.Regex.IsMatch(clientIDNumber, numericPattern))
            {
                errorProvider1.SetError(txtClient_ID_Number_UpdateClient, "Client ID Number must be exactly 13 digits.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtClient_ID_Number_UpdateClient, "");
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                errorProvider1.SetError(txtFirstName_UpdateClient, "First Name is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(firstName, alphaPattern))
            {
                errorProvider1.SetError(txtFirstName_UpdateClient, "First Name must contain only letters and allowed punctuation.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtFirstName_UpdateClient, "");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                errorProvider1.SetError(txtLastName_UpdateClient, "Last Name is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(lastName, alphaPattern))
            {
                errorProvider1.SetError(txtLastName_UpdateClient, "Last Name must contain only letters and allowed punctuation.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtLastName_UpdateClient, "");
            }

            if (string.IsNullOrWhiteSpace(cellNumber))
            {
                errorProvider1.SetError(txtCellNumber_UpdateClient, "Cell Number is required.");
                isValid = false;
            }
            else if (cellNumber.Length != 10 || !System.Text.RegularExpressions.Regex.IsMatch(cellNumber, numericPattern))
            {
                errorProvider1.SetError(txtCellNumber_UpdateClient, "Cell Number must be exactly 10 digits.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtCellNumber_UpdateClient, "");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txtEmail_UpdateClient, "Email is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                errorProvider1.SetError(txtEmail_UpdateClient, "Email must be a valid email address.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail_UpdateClient, "");
            }

            // Check if the checkbox is checked
            if (!hasDriversLicense)
            {
                errorProvider1.SetError(chkbYesHasDriversLicense_UpdateClient, "Please check this box if the client has a driver's license.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(chkbYesHasDriversLicense_UpdateClient, "");
            }

            if (!isValid)
            {
                //MessageBox.Show("Please correct the errors before updating.");
                return;
            }


            string sqlupdate = "UPDATE Client SET Client_ID_Number = @ClientIDNumber, FirstName = @FirstName, LastName = @LastName, CellNumber = @CellNumber, Email = @Email, HasDriversLicense = @HasDriversLicense WHERE Client_ID = @ClientID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlupdate, con))
                    {
                        cmd.Parameters.AddWithValue("@ClientID", clientID);
                        cmd.Parameters.AddWithValue("@ClientIDNumber", clientIDNumber);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@CellNumber", cellNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@HasDriversLicense", hasDriversLicense);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client updated successfully.");
                            LoadData();

                            // Clear the form
                            txtClient_ID_UpdateClient.Clear();
                            txtClient_ID_Number_UpdateClient.Clear();
                            txtFirstName_UpdateClient.Clear();
                            txtLastName_UpdateClient.Clear();
                            txtCellNumber_UpdateClient.Clear();
                            txtEmail_UpdateClient.Clear();
                            chkbYesHasDriversLicense_UpdateClient.Checked = false;
                        }
                        else
                        {
                            //MessageBox.Show("No records were updated. This could mean the Client_ID does not exist or the data is unchanged.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error Stack Trace: " + ex.StackTrace);
            }
        }



        private void dgvDeleteClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvDeleteClient.CurrentRow != null)
                {
                    DataGridViewRow selectedRow = dgvDeleteClient.Rows[e.RowIndex];

                    if (selectedRow.Cells["Client_ID"].Value != null)
                    {
                        txtClient_ID_DeleteClient.Text = selectedRow.Cells["Client_ID"].Value.ToString();
                    }
                    else
                    {
                        txtClient_ID_DeleteClient.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error Stack Trace: " + ex.StackTrace);
            }
        }


        private void dgvUpdateClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUpdateClient.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvUpdateClient.CurrentRow;

                string clientID = selectedRow.Cells["Client_ID"].Value.ToString();
                string clientIDNumber = selectedRow.Cells["Client_ID_Number"].Value.ToString();
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                string cellNumber = selectedRow.Cells["CellNumber"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();

                // Convert the HasDriversLicense cell value to a boolean
                bool hasDriversLicense = bool.Parse(selectedRow.Cells["HasDriversLicense"].Value.ToString());

                // Populate the fields
                txtClient_ID_UpdateClient.Text = clientID;
                txtClient_ID_Number_UpdateClient.Text = clientIDNumber;
                txtFirstName_UpdateClient.Text = firstName;
                txtLastName_UpdateClient.Text = lastName;
                txtCellNumber_UpdateClient.Text = cellNumber;
                txtEmail_UpdateClient.Text = email;

                // Set the checkbox based on the boolean value
                chkbYesHasDriversLicense_UpdateClient.Checked = hasDriversLicense;
            }
        }


        private void txtSearch_UpdateClient_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch_UpdateClient.Text;

            if (dgvUpdateClient.DataSource is DataTable dataTable)
            {
                // Filter the DataTable based on the search term
                if (string.IsNullOrEmpty(searchTerm))
                {
                    dataTable.DefaultView.RowFilter = string.Empty; // Show all rows if the search term is empty
                }
                else
                {
                    // Use parameterized filtering to prevent issues with special characters
                    dataTable.DefaultView.RowFilter = $"LastName LIKE '%{searchTerm}%'";
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvUpdateClient.Rows)
                {
                    if (row.Cells["LastName"].Value != null &&
                        row.Cells["LastName"].Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
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


        private void txtSearch_DeleteClient_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch_DeleteClient.Text;

            if (dgvDeleteClient.DataSource is DataTable dataTable)
            {
                // Handle empty search term to show all rows
                if (string.IsNullOrEmpty(searchTerm))
                {
                    dataTable.DefaultView.RowFilter = string.Empty; // Show all rows
                }
                else
                {
                    // Apply the filter with the search term
                    dataTable.DefaultView.RowFilter = $"LastName LIKE '%{searchTerm}%'";
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvDeleteClient.Rows)
                {
                    if (row.Cells["LastName"].Value != null &&
                        row.Cells["LastName"].Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
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

        private void dgvAddClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_Add_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch_Add.Text;

            if (dgvAddClient.DataSource is DataTable dataTable)
            {
                // Handle empty search term to show all rows
                if (string.IsNullOrEmpty(searchTerm))
                {
                    dataTable.DefaultView.RowFilter = string.Empty; // Show all rows
                }
                else
                {
                    // Apply the filter with the search term
                    dataTable.DefaultView.RowFilter = $"LastName LIKE '%{searchTerm}%'";
                }
            }
            else
            {
                // Assuming the DataSource is not a DataTable, manually filter rows
                foreach (DataGridViewRow row in dgvAddClient.Rows)
                {
                    if (row.Cells["LastName"].Value != null &&
                        row.Cells["LastName"].Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
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

        private void btnBack_AddClients_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_UpdateClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_DeleteClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
