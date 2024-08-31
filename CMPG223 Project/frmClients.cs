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

namespace CMPG223_Project
{
    public partial class frmClients : Form
    {

        public string connectionString = @"Data Source=LAPTOP-9FK1U57R;Initial Catalog=Roadrunner Rentals;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";


        public frmClients()
        {
            InitializeComponent();
        }

        private void btnAdd_AddClients_Click(object sender, EventArgs e)
        {
                string Client_ID_Number = txtClient_ID_Number_AddClient.Text;
                string firstName = txtFirstName_AddClient.Text;
                string lastName = txtLastName_AddClient.Text;
                string cellNumber = txtCellNumber_AddClient.Text;
                string email = txtEmail_AddClient.Text;
                string HasDriversLicense = cmbHasDriversLicense_AddClient.Text;

                bool isValid = true;

                // Regular expression patterns for validation
                string alphaPattern = @"^[a-zA-Z\s.,'-]*$";  // Allows letters, spaces, and some punctuation
                string numericPattern = @"^\d+$";  // Allows only numbers
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";  // Basic email validation pattern

                // Validation using ErrorProvider
                if (string.IsNullOrWhiteSpace(Client_ID_Number))
                {
                    errorProvider1.SetError(txtClient_ID_Number_AddClient, "Client ID Number is required.");
                    isValid = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(Client_ID_Number, numericPattern))
                {
                    errorProvider1.SetError(txtClient_ID_Number_AddClient, "Client ID Number must contain only numbers.");
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
                else if (!System.Text.RegularExpressions.Regex.IsMatch(cellNumber, numericPattern))
                {
                    errorProvider1.SetError(txtCellNumber_AddClient, "Cell Number must contain only numbers.");
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

                if (string.IsNullOrWhiteSpace(HasDriversLicense))
                {
                    errorProvider1.SetError(cmbHasDriversLicense_AddClient, "Yes or No is required.");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(cmbHasDriversLicense_AddClient, "");
                }

                if (!isValid)
                {
                    MessageBox.Show("Please correct the errors before adding.");
                    return;
                }

                // Confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to add this Client to the database?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Check for duplicates
                    string checkQuery = "SELECT COUNT(*) FROM Client WHERE Client_ID_Number = @ClientIDNumber";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@ClientIDNumber", Client_ID_Number);

                    try
                    {
                        conn.Open();
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            errorProvider1.SetError(txtClient_ID_Number_AddClient, "Client ID Number already exists.");
                            MessageBox.Show("Client ID Number already exists in the database. Please check if you are entering it correctly.");
                            return;
                        }
                        else
                        {
                            errorProvider1.SetError(txtClient_ID_Number_AddClient, "");
                        }

                        string query = "INSERT INTO Client (Client_ID_Number, FirstName, LastName, CellNumber, Email, HasDriversLicense) VALUES (@ClientIDNumber, @FirstName, @LastName, @CellNumber, @Email, @HasDriversLicense)";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ClientIDNumber", Client_ID_Number);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@CellNumber", cellNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@HasDriversLicense", HasDriversLicense);

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
            cmbHasDriversLicense_AddClient.SelectedIndex = -1; // Unselects any selected item
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
            cmbHasDriversLicense_UpdateClient.SelectedIndex = -1; // Unselects any selected item
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
                MessageBox.Show("Please correct the errors before deleting.");
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
                            MessageBox.Show("No Client found with the specified ID.");
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
            string Client_ID = txtClient_ID_UpdateClient.Text;
            string Client_ID_Number = txtClient_ID_Number_UpdateClient.Text;
            string firstName = txtFirstName_UpdateClient.Text;
            string lastName = txtLastName_UpdateClient.Text;
            string cellNumber = txtCellNumber_UpdateClient.Text;
            string email = txtEmail_UpdateClient.Text;
            string HasDriversLicense = cmbHasDriversLicense_UpdateClient.Text;

            bool isValid = true;

            string numericPattern = @"^\d+$";
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string alphaPattern = @"^[a-zA-Z\s.,'-]+$";

            if (string.IsNullOrWhiteSpace(Client_ID))
            {
                errorProvider1.SetError(txtClient_ID_UpdateClient, "Client ID is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtClient_ID_UpdateClient, "");
            }

            if (string.IsNullOrWhiteSpace(Client_ID_Number))
            {
                errorProvider1.SetError(txtClient_ID_Number_UpdateClient, "Client ID Number is required.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Client_ID_Number, numericPattern))
            {
                errorProvider1.SetError(txtClient_ID_Number_UpdateClient, "Client ID Number must contain only numbers.");
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
                errorProvider1.SetError(txtFirstName_UpdateClient, "First Name must contain only alphabets.");
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
                errorProvider1.SetError(txtLastName_UpdateClient, "Last Name must contain only alphabets.");
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
            else if (!System.Text.RegularExpressions.Regex.IsMatch(cellNumber, numericPattern))
            {
                errorProvider1.SetError(txtCellNumber_UpdateClient, "Cell Number must contain only numbers.");
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
                errorProvider1.SetError(txtEmail_UpdateClient, "Invalid email format.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail_UpdateClient, "");
            }

            if (string.IsNullOrWhiteSpace(HasDriversLicense))
            {
                errorProvider1.SetError(cmbHasDriversLicense_UpdateClient, "Yes or No required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(cmbHasDriversLicense_UpdateClient, "");
            }

            if (!isValid)
            {
                MessageBox.Show("Please correct the errors before updating.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this Client in the database?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
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
                        cmd.Parameters.AddWithValue("@ClientID", Client_ID);
                        cmd.Parameters.AddWithValue("@ClientIDNumber", Client_ID_Number);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@CellNumber", cellNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@HasDriversLicense", HasDriversLicense);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client updated successfully.");
                            LoadData();

                            txtClient_ID_UpdateClient.Clear();
                            txtClient_ID_Number_UpdateClient.Clear();
                            txtFirstName_UpdateClient.Clear();
                            txtLastName_UpdateClient.Clear();
                            txtCellNumber_UpdateClient.Clear();
                            txtEmail_UpdateClient.Clear();
                            cmbHasDriversLicense_UpdateClient.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. This could mean the Client_ID does not exist or the data is unchanged.");
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

                string Client_ID = selectedRow.Cells["ClientID"].Value.ToString();
                string Client_ID_Number = selectedRow.Cells["Client_ID_Number"].Value.ToString();
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                string cellNumber = selectedRow.Cells["CellNumber"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string HasDriversLicense = selectedRow.Cells["HasDriversLicense"].Value.ToString();

                txtClient_ID_UpdateClient.Text = Client_ID;
                txtClient_ID_Number_UpdateClient.Text = Client_ID_Number;
                txtFirstName_UpdateClient.Text = firstName;
                txtLastName_UpdateClient.Text = lastName;
                txtCellNumber_UpdateClient.Text = cellNumber;
                txtEmail_UpdateClient.Text = email;

                cmbHasDriversLicense_UpdateClient.Items.Clear();
                cmbHasDriversLicense_UpdateClient.Items.Add(HasDriversLicense);
                cmbHasDriversLicense_UpdateClient.SelectedIndex = 0;
            }
        }
    }
}
