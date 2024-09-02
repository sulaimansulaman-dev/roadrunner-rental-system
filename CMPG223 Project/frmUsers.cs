
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace CMPG223_Project
{
    public partial class frmUsers : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet ds;

        // Connection string to connect to the database
        public string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        string userName_Add, firstName_Add, lastName_Add, cellNumber_Add;

        // Initialize ErrorProviders for validation feedback
        ErrorProvider usernameErrorProvider = new ErrorProvider();
        ErrorProvider firstNameErrorProvider = new ErrorProvider();
        ErrorProvider lastNameErrorProvider = new ErrorProvider();
        ErrorProvider cellNumberErrorProvider = new ErrorProvider();

        public frmUsers()
        {
            InitializeComponent();

            // Set up the DataGridView cell click event
            dgvUpdateUsers.CellClick += dgvUpdateUsers_CellClick;

            //disable multiple row selection
            dgvUpdateUsers.MultiSelect = false;

            // Set the TextBox to read-only
            txtUserID_UpdateUser.ReadOnly = true;
        }

        private void dgvUpdateUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvUpdateUsers.CurrentRow != null)
            {

                DataGridViewRow selectedRow = dgvUpdateUsers.CurrentRow;


                string userID = selectedRow.Cells["User_ID"].Value.ToString();
                string userName = selectedRow.Cells["Username"].Value.ToString();
                string FirstName = selectedRow.Cells["Firstname"].Value.ToString();
                string LastName = selectedRow.Cells["Lastname"].Value.ToString();
                string Cellnumber = selectedRow.Cells["Cellnumber"].Value.ToString();

                txtUserID_UpdateUser.Text = userID;
                txtUsername_UpdateUsers.Text = userName;
                txtFirstName_UpdateUsers.Text = FirstName;
                txtLastName_UpdateUsers.Text = LastName;
                txtCellNumber_UpdateUsers.Text = Cellnumber;

            }


        }

        private void PopulateComboBox()
        {
            cmbUsername_DeleteUsers.Items.Clear();

            conn.Open();
            string sqlSelect = "SELECT Username FROM Users";
            command = new SqlCommand(sqlSelect, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbUsername_DeleteUsers.Items.Add(reader["Username"]);
            }
            reader.Close();
            conn.Close();
        }

        private void RefreshDataGrids()
        {
            conn.Open();
            string sqlDisplay = "SELECT * FROM Users";
            command = new SqlCommand(sqlDisplay, conn);
            adapter = new SqlDataAdapter(command);
            ds = new DataSet();
            adapter.Fill(ds, "Users");

            // Repopulate all DataGridViews with the same DataSet
            dgvAddUsers.DataSource = ds.Tables["Users"];
            dgvDelete_DeleteUsers.DataSource = ds.Tables["Users"];
            dgvUpdateUsers.DataSource = ds.Tables["Users"];

            conn.Close();
        }

        private void btnAdd_AddUsers_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);

                bool isValid = true; // A flag to check if all validations pass

                // Clear previous error messages
                usernameErrorProvider.Clear();
                firstNameErrorProvider.Clear();
                lastNameErrorProvider.Clear();
                cellNumberErrorProvider.Clear();

                // Username validation
                string usernamePattern = @"^[a-zA-Z0-9]{1,25}$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtUsername_AddUsers.Text, usernamePattern))
                {
                    usernameErrorProvider.SetError(txtUsername_AddUsers, "Username must be 1-25 characters long and contain only letters and numbers.");
                    isValid = false;
                }

                // Check if username already exists
                conn.Open();
                string checkUsername = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand checkCmd = new SqlCommand(checkUsername, conn);
                checkCmd.Parameters.AddWithValue("@Username", txtUsername_AddUsers.Text);
                int userCount = (int)checkCmd.ExecuteScalar();
                conn.Close();

                if (userCount > 0)
                {
                    usernameErrorProvider.SetError(txtUsername_AddUsers, "This username already exists. Please choose a different one.");
                    isValid = false;
                }

                userName_Add = txtUsername_AddUsers.Text;

                // First name validation
                string namePattern = @"^[a-zA-Z]{1,25}$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirstName_AddUsers.Text, namePattern))
                {
                    firstNameErrorProvider.SetError(txtFirstName_AddUsers, "First name must be 1-25 characters long and contain only letters.");
                    isValid = false;
                }

                firstName_Add = txtFirstName_AddUsers.Text;


                // Last name validation: allow letters and spaces
                string lastNamePattern = @"^[a-zA-Z\s]{1,25}$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtLastName_AddUsers.Text.Trim(), lastNamePattern))
                {
                    lastNameErrorProvider.SetError(txtLastName_AddUsers, "Last name must be 1-25 characters long and contain only letters and spaces.");
                    isValid = false;
                }
                else
                {
                    lastName_Add = txtLastName_AddUsers.Text.Trim(); // Trim to remove any leading or trailing spaces
                }

                lastName_Add = txtLastName_AddUsers.Text;

                // Phone number validation using regex
                string phoneInput = txtCellNumber_AddUsers.Text;
                string pattern = @"^0\d{9}$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(phoneInput, pattern))
                {
                    cellNumberErrorProvider.SetError(txtCellNumber_AddUsers, "Invalid phone number. It must be 10 digits long and start with 0.");
                    txtCellNumber_AddUsers.Clear();
                    txtCellNumber_AddUsers.Focus();
                    isValid = false;
                }
                else
                {
                    cellNumber_Add = phoneInput.Replace(" ", ""); // Remove any spaces
                }

                // If any validation failed, return early
                if (!isValid)
                {
                    return;
                }

                // Insert the new user into the database
                string sqlInsert = "INSERT INTO Users(Username, Lastname, FirstName, Cellnumber) VALUES (@Username, @LastName, @FirstName, @CellNumber)";
                conn.Open();
                SqlCommand insertCommand = new SqlCommand(sqlInsert, conn);
                insertCommand.Parameters.AddWithValue("@Username", userName_Add);
                insertCommand.Parameters.AddWithValue("@LastName", lastName_Add);
                insertCommand.Parameters.AddWithValue("@FirstName", firstName_Add);
                insertCommand.Parameters.AddWithValue("@CellNumber", cellNumber_Add);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("User added successfully");
                conn.Close();

                // Refresh DataGridViews
                RefreshDataGrids();
                // Refresh ComboBox
                PopulateComboBox();



                // Clear textboxes for adding new users
                txtUsername_AddUsers.Clear();
                txtFirstName_AddUsers.Clear();
                txtLastName_AddUsers.Clear();
                txtCellNumber_AddUsers.Clear();
                txtUsername_AddUsers.Focus();
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL exceptions
                MessageBox.Show("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            // Display users in DataGridView when "Add User" button is clicked
            conn.Open();
            string sqlDisplay = $"SELECT * FROM Users";
            command = new SqlCommand(sqlDisplay, conn);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            ds = new DataSet();
            adapter.Fill(ds, "Users");
            dgvAddUsers.DataSource = ds;
            dgvAddUsers.DataMember = "Users";
            dgvDelete_DeleteUsers.DataSource = ds;
            dgvDelete_DeleteUsers.DataMember = "Users";
            conn.Close();

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            txtUsername_AddUsers.Focus();

            conn = new SqlConnection(connectionString);

            // Populate the DataGridViews with the list of users
            RefreshDataGrids();

            // Populate ComboBox with the list of usernames from the Users table
            PopulateComboBox();
        }

        private void dgvUpdateUsers_SelectionChanged(object sender, EventArgs e)
        {
            ///////////
        }


        private void btnClear_AddUsers_Click(object sender, EventArgs e)
        {
            // Clears all input fields for adding a new user
            txtUsername_AddUsers.Clear();
            txtFirstName_AddUsers.Clear();
            txtLastName_AddUsers.Clear();
            txtCellNumber_AddUsers.Clear();

            // Sets focus back to the username input field
            txtUsername_AddUsers.Focus();

            // Clears any error messages set by ErrorProviders
            usernameErrorProvider.Clear();
            firstNameErrorProvider.Clear();
            lastNameErrorProvider.Clear();
            cellNumberErrorProvider.Clear();
        }

        private void btnDelete_DeleteUsers_Click(object sender, EventArgs e)
        {
            {
                if (cmbUsername_DeleteUsers.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a user to delete on the datagridview!");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user in the database?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }


                // SQL statement to delete a user based on the selected username from the ComboBox
                string sqlDelete = "DELETE FROM Users WHERE Username ='" + cmbUsername_DeleteUsers.Text + "'";

                // Open database connection
                conn.Open();
                command = new SqlCommand(sqlDelete, conn);
                adapter = new SqlDataAdapter();

                // Execute the delete command
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                // Close the database connection
                conn.Close();

                // Refresh ComboBox and DataGridViews
                PopulateComboBox();
                RefreshDataGrids();

                // Clear the selected value in ComboBox
                cmbUsername_DeleteUsers.SelectedIndex = -1;
            }

        }

        private void DeleteUsers_Click(object sender, EventArgs e)
        {
            // Open the connection to display the list of users
            conn.Open();
            string sqlDisplay = $"SELECT * FROM Users";
            command = new SqlCommand(sqlDisplay, conn);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            ds = new DataSet();
            adapter.Fill(ds, "Users");

            // Set DataGridViews data source to show users
            dgvAddUsers.DataSource = ds;
            dgvAddUsers.DataMember = "Users";
            dgvDelete_DeleteUsers.DataSource = ds;
            dgvDelete_DeleteUsers.DataMember = "Users";
            conn.Close();
        }

        private void cmbUsername_DeleteUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///////
        }

        private void btnUpdateUsers_UpdateUsers_Click(object sender, EventArgs e)
        {
            // Check if a user is selected to update
            if (string.IsNullOrEmpty(txtUserID_UpdateUser.Text))
            {
                MessageBox.Show("Please select a user to update on the datagridview!");
                return;
            }

            string userID = txtUserID_UpdateUser.Text;

            // Clear previous error messages
            usernameErrorProvider.Clear();
            firstNameErrorProvider.Clear();
            lastNameErrorProvider.Clear();
            cellNumberErrorProvider.Clear();

            bool isValid = true; // Flag to check if all validations pass

            // Username validation
            string usernamePattern = @"^[a-zA-Z0-9]{1,25}$"; // Letters and numbers only, up to 25 characters
            if (!string.IsNullOrWhiteSpace(txtUsername_UpdateUsers.Text) && !Regex.IsMatch(txtUsername_UpdateUsers.Text, usernamePattern))
            {
                usernameErrorProvider.SetError(txtUsername_UpdateUsers, "Username must be 1-25 characters long and contain only letters and numbers.");
                isValid = false;
            }

            // First name validation
            string firstNamePattern = @"^[a-zA-Z]{1,25}$"; // Letters only, up to 25 characters
            if (!string.IsNullOrWhiteSpace(txtFirstName_UpdateUsers.Text) && !Regex.IsMatch(txtFirstName_UpdateUsers.Text, firstNamePattern))
            {
                firstNameErrorProvider.SetError(txtFirstName_UpdateUsers, "First name must be 1-25 characters long and contain only letters.");
                isValid = false;
            }

            // Last name validation: allow letters and spaces
            string lastNamePattern = @"^[a-zA-Z\s]{1,25}$";
            if (!string.IsNullOrWhiteSpace(txtLastName_UpdateUsers.Text) && !Regex.IsMatch(txtLastName_UpdateUsers.Text.Trim(), lastNamePattern))
            {
                lastNameErrorProvider.SetError(txtLastName_UpdateUsers, "Last name must be 1-25 characters long and contain only letters and spaces.");
                isValid = false;
            }

            // Phone number validation
            string phonePattern = @"^0\d{9}$"; // Must be a 10-digit number starting with 0
            if (!string.IsNullOrWhiteSpace(txtCellNumber_UpdateUsers.Text) && !Regex.IsMatch(txtCellNumber_UpdateUsers.Text, phonePattern))
            {
                cellNumberErrorProvider.SetError(txtCellNumber_UpdateUsers, "Invalid phone number. It must be 10 digits long and start with 0.");
                isValid = false;
            }

            // If validation failed, return early
            if (!isValid)
            {
                return;
            }

            // Proceed with the update if validations pass
            string updateQuery = "UPDATE Users SET ";

            List<string> updateFields = new List<string>();

            if (!string.IsNullOrWhiteSpace(txtUsername_UpdateUsers.Text))
            {
                updateFields.Add("Username = @Username");
            }

            if (!string.IsNullOrWhiteSpace(txtFirstName_UpdateUsers.Text))
            {
                updateFields.Add("FirstName = @FirstName");
            }

            if (!string.IsNullOrWhiteSpace(txtLastName_UpdateUsers.Text))
            {
                updateFields.Add("Lastname = @LastName");
            }

            if (!string.IsNullOrWhiteSpace(txtCellNumber_UpdateUsers.Text))
            {
                updateFields.Add("Cellnumber = @CellNumber");
            }

            if (updateFields.Count == 0)
            {
                MessageBox.Show("Please fill in at least one field to update.");
                return;
            }

            updateQuery += string.Join(", ", updateFields) + " WHERE User_ID = @UserID";

            // Open database connection and execute the update command
            conn.Open();
            SqlCommand command = new SqlCommand(updateQuery, conn);
            command.Parameters.AddWithValue("@UserID", userID);

            if (!string.IsNullOrWhiteSpace(txtUsername_UpdateUsers.Text))
            {
                command.Parameters.AddWithValue("@Username", txtUsername_UpdateUsers.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtFirstName_UpdateUsers.Text))
            {
                command.Parameters.AddWithValue("@FirstName", txtFirstName_UpdateUsers.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtLastName_UpdateUsers.Text))
            {
                command.Parameters.AddWithValue("@LastName", txtLastName_UpdateUsers.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtCellNumber_UpdateUsers.Text))
            {
                command.Parameters.AddWithValue("@CellNumber", txtCellNumber_UpdateUsers.Text);
            }

            command.ExecuteNonQuery();
            MessageBox.Show("Vehicle class updated successfully.");
            conn.Close();

            // Clear selection to avoid conflicts with the CurrencyManager
            dgvUpdateUsers.ClearSelection();

            // Refresh DataGridViews
            RefreshDataGrids();

            // Clear update input fields
            txtUsername_UpdateUsers.Clear();
            txtFirstName_UpdateUsers.Clear();
            txtLastName_UpdateUsers.Clear();
            txtCellNumber_UpdateUsers.Clear();
            txtUserID_UpdateUser.Clear();
        }


        private void btnClearUsers_UpdateUsers_Click(object sender, EventArgs e)
        {
            // Clears all input fields
            txtUsername_UpdateUsers.Clear();
            txtFirstName_UpdateUsers.Clear();
            txtLastName_UpdateUsers.Clear();
            txtCellNumber_UpdateUsers.Clear();
            dgvUpdateUsers.Focus();

            // Clears any error messages set by ErrorProviders
            usernameErrorProvider.Clear();
            firstNameErrorProvider.Clear();
            lastNameErrorProvider.Clear();
            cellNumberErrorProvider.Clear();
        }

        private void btnBack_DeleteUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_UpdateUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_AddUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void txtSearch_Update_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch_Update.Text.Trim().Replace("'", "''");
            string[] searchableColumns = { "User_ID", "Username", "Lastname", "Firstname", "Cellnumber" };
            SearchDataGridView(searchTerm, dgvUpdateUsers, searchableColumns);

        }

        private void txtSearch_Add_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch_Add.Text.Trim().Replace("'", "''");
            string[] searchableColumns = { "User_ID", "Username", "Lastname", "Firstname", "Cellnumber" };
            SearchDataGridView(searchTerm, dgvAddUsers, searchableColumns);

        }

        private void txtSearch_Delete_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch_Delete.Text.Trim().Replace("'", "''");
            string[] searchableColumns = { "User_ID", "Username", "Lastname", "Firstname", "Cellnumber" };
            SearchDataGridView(searchTerm, dgvDelete_DeleteUsers, searchableColumns);

        }

        public static void SearchDataGridView(string searchTerm, DataGridView dgv, params string[] searchableColumns)
        {
            searchTerm = searchTerm.ToLower();

            if (dgv.BindingContext != null && dgv.DataSource != null)
            {
                CurrencyManager currencyManager = (CurrencyManager)dgv.BindingContext[dgv.DataSource];
                currencyManager.SuspendBinding();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool rowVisible = false;

                    foreach (string columnName in searchableColumns)
                    {
                        if (dgv.Columns.Contains(columnName))
                        {
                            string cellValue = row.Cells[columnName].Value?.ToString().ToLower() ?? "";

                            if (cellValue.Contains(searchTerm))
                            {
                                rowVisible = true;
                                break;
                            }
                        }
                    }

                    if (rowVisible)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        if (currencyManager.Position != row.Index)
                        {
                            row.Visible = false;
                        }
                    }
                }

                currencyManager.ResumeBinding();
            }
        }

        private void dgvUpdateUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDelete_DeleteUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvDelete_DeleteUsers.CurrentRow != null)
            {

                DataGridViewRow selectedRow = dgvUpdateUsers.CurrentRow;


                string userID = selectedRow.Cells["Username"].Value.ToString();





                cmbUsername_DeleteUsers.Text = userID;


            }
        }

        private void btnBack_AddUsers_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_UpdateUsers_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_DeleteUsers_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_DeleteUsers_Click(object sender, EventArgs e)
        {
            cmbUsername_DeleteUsers.SelectedIndex = -1; 
        }
    }
}



