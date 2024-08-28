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
        SqlConnection cnn;
        public frmVehicles()
        {
            InitializeComponent();
        }

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-20CLHAU;Initial Catalog=""Roadrunner Rentals"";Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            cnn = new SqlConnection(connectionstring);

            //Display Data
            try
            {

                //Opening Connection to the database
                cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                string sql = "SELECT * FROM Vehicle"; // <- SELECT statement
                SqlCommand command = new SqlCommand(sql, cnn); // <-Execute an SQL statement against a given datasource

                //Filling the dataset 
                adapter.SelectCommand = command; // <- Set the command for the adpater
                adapter.Fill(ds, "Vehicle"); // <- Fill the DataSet with the results of the SQL command

                //Adding the data into the Data Grid 
                dgvVehicles_Add.DataSource = ds;
                dgvVehicles_Add.DataMember = "Vehicle";

                cnn.Close();
            }

            //try catch for error handling
            catch
            {
                MessageBox.Show("Please connect to the database first");
            }

            hsbCostPerDay.Value = 0;
            hsbCostPerDay.Minimum = 0;
            hsbCostPerDay.Maximum = 10000;
            label4.Text = hsbCostPerDay.Value.ToString();

            LoadComboBox();

        }

        private void btnAdd_Add_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txtYear.Text);
            int noOfSeats = int.Parse(cmbNoOfSeats.Text);
            string licenceNo = txtLicenseNo.Text;
            

            /*//Validation 

                 if (int.(year))
                     MessageBox.Show("Year Required");

                 else if (String.IsNullOrWhiteSpace(description))
                     MessageBox.Show("Description is Required");


                 using (cnn)
                 {
                     string query = "INSERT INTO Vehicle_Class (ClassName, Description) VALUES(@ClassName, @Description)";
                     SqlCommand cmd = new SqlCommand(query, conn);
                     //Prevents SQL Injection and Ensures secure code practices
                     cmd.Parameters.AddWithValue("@ClassName", className);
                     cmd.Parameters.AddWithValue("@Description", description);

                     try
                     {
                         conn.Open();
                         cmd.ExecuteNonQuery();
                         MessageBox.Show("Vehicle class added successfully");
                         LoadData();
                         LoadComboBoxClassID(); 

                     }
                     catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
                 }
             }*/

        }

        

        private void frmVehicles_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Add_Click(object sender, EventArgs e)
        {

        }

        private void cmbClassSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBox()
        {
            string sql = "SELECT ClassName FROM Vehicle_Class";

            try
            {
                using (cnn)
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            cmbClassSelect.Items.Clear(); // Clear existing items
                            cmbVehicleID_Update.Items.Clear();

                            while (dataReader.Read())
                            {
                                var id = dataReader.GetValue(0).ToString();
                                if (!cmbClassSelect.Items.Contains(id))
                                {
                                    cmbClassSelect.Items.Add(id);
                                    cmbVehicleID_Update.Items.Add(id);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void hsbCostPerDay_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = hsbCostPerDay.Value.ToString();
        }
    }
}
