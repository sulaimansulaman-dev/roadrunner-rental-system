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

namespace CMPG223_Project
{
    public partial class frmUsers : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet ds;

        //public string connectionString = @"Data Source=METAMIDNIGHT;Initial Catalog=Roadrunner Rentals;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public string connectionString = @"Data Source=METAMIDNIGHT;Initial Catalog=Roadrunner Rentals;Integrated Security=True;Connect Timeout=30";

        string userName_Add, firstName_Add, lastName_Add, cellNumber_Add;


        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnAdd_AddUsers_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            userName_Add = txtUsername_AddUsers.Text;
            firstName_Add = txtFirstName_AddUsers.Text;
            lastName_Add = txtLastName_AddUsers.Text;
            cellNumber_Add = txtCellNumber_AddUsers.Text;

            //adding a new user
            string sqlInsert = $"INSERT INTO Users(Username, Lastname, FirstName, Cellnumber) VALUES ('{userName_Add}', '{lastName_Add}', '{firstName_Add}', '{cellNumber_Add}')";

            conn.Open();

            adapter = new SqlDataAdapter();
            command = new SqlCommand(sqlInsert, conn);

            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            ds = new DataSet();
            string sqlDisplay = $"SELECT * FROM Users";
            command = new SqlCommand(sqlDisplay, conn);

            adapter.SelectCommand = command;
            adapter.Fill(ds, "Users");
            conn.Close();

            conn = new SqlConnection(connectionString);

            conn.Open();
            sqlDisplay = $"SELECT * FROM Users"; //display when form opens , formLoad event look it up
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

        private void AddUser_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlDisplay = $"SELECT * FROM Users"; //display when form opens , formLoad event look it up
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
            ///////////////////////////////////////////////////////////////////
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            txtUsername_AddUsers.Focus();

            conn = new SqlConnection(connectionString);

            conn.Open();
            string sqlDisplay = $"SELECT * FROM Users"; //display when form opens , formLoad event look it up
            command = new SqlCommand(sqlDisplay, conn);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Users");
            dgvAddUsers.DataSource = ds;
            dgvAddUsers.DataMember = "Users";
            dgvDelete_DeleteUsers.DataSource = ds;
            dgvDelete_DeleteUsers.DataMember = "Users";
            conn.Close();

            //fills combobox with the usernames
            conn.Open();
            string sqlSelect = $"SELECT Username FROM Users";
            command = new SqlCommand(sqlSelect, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbUsername_DeleteUsers.Items.Add(reader["Username"]);
            }
            reader.Close();
            conn.Close();


        }

        private void btnClear_AddUsers_Click(object sender, EventArgs e)
        {
            txtUsername_AddUsers.Clear();
            txtFirstName_AddUsers.Clear();
            txtLastName_AddUsers.Clear();
            txtCellNumber_AddUsers.Clear();
            txtUsername_AddUsers.Focus();
        }

        private void btnDelete_DeleteUsers_Click(object sender, EventArgs e)
        {
            //cmbUsername_DeleteUsers.Items.Clear();
            /*conn.Open();
            string sqlSelect = $"SELECT Username FROM Users";
            command = new SqlCommand(sqlSelect, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbUsername_DeleteUsers.Items.Add(reader["Username"]);
            }
            reader.Close();
            conn.Close();*/

            string sqlDelete = "DELETE FROM Users WHERE Username ='" + cmbUsername_DeleteUsers.Text + "'";

            conn.Open();
            command = new SqlCommand(sqlDelete, conn);
            adapter = new SqlDataAdapter();

            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();

            conn.Close();

            conn = new SqlConnection(connectionString);

            conn.Open();
            string sqlDisplay = $"SELECT * FROM Users"; //display when form opens , formLoad event look it up
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


            //string sqlDelete = "DELETE FROM Users WHERE ";
            /*conn.Open();
string sql = $"SELECT DISTINCT role FROM Staff";
adapter = new SqlDataAdapter(sql, conn);
DataSet ds = new DataSet();
adapter.Fill(ds, "staff_role");
comboBox1.DisplayMember = "role";
comboBox1.ValueMember = "role";
comboBox1.DataSource = ds.Tables["staff_role"];
conn.Close();*/

            /*
            adapter = new SqlDataAdapter(sqlSelect, conn);
            ds = new DataSet();
            adapter.Fill(ds, "Username");
            cmbUsername_DeleteUsers.DisplayMember = "Username";
            cmbUsername_DeleteUsers.ValueMember = "Username";
            cmbUsername_DeleteUsers.DataSource = ds.Tables["Users"];
            conn.Close();*/
        }

        private void DeleteUsers_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlDisplay = $"SELECT * FROM Users"; //display when form opens , formLoad event look it up
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

            //cmbUsername_DeleteUsers.Items.Clear();
            conn.Open();
            string sqlSelect = $"SELECT Username FROM Users";
            command = new SqlCommand(sqlSelect, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbUsername_DeleteUsers.Items.Add(reader["Username"]);
            }
            reader.Close();
            conn.Close();
        }

        private void cmbUsername_DeleteUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* conn.Open();
            string sqlSelect = $"SELECT Username FROM Users";
            command = new SqlCommand(sqlSelect, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbUsername_DeleteUsers.Items.Add(reader["Username"]);
            }
            reader.Close();
            conn.Close();*/
        }
    }
}
