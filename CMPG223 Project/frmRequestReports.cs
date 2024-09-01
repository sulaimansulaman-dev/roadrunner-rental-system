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

namespace CMPG223_Project
{
    public partial class frmRequestReports : Form
    {
        String connectionString = @"Data Source=MOMO;Initial Catalog=""Roadrunner Rentals"";Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public frmRequestReports()
        {
            InitializeComponent();
        }


        private void frmRequestReports_Load(object sender, EventArgs e)
        {
            pbRequestReports.BringToFront();
            dtpStartDate_RequestReports.Value = DateTime.Today;
            dtpEndDate_RequestReports.Value = DateTime.Today.AddDays(1);


        }


        private ErrorProvider errorProvider = new ErrorProvider();

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

            // Clear DataGridView rows and columns
            dgvRequestReports.Rows.Clear();
            dgvRequestReports.Columns.Clear();

            // Initialize Variables
            DateTime startDate = dtpStartDate_RequestReports.Value;
            DateTime endDate = dtpEndDate_RequestReports.Value;
            lblTodaysDate_RequestReport.Text = DateTime.Today.Date.ToString("yyyy/MM/dd");
            string Order_By = null;

            // Perform validation
            bool isDateValid = ValidateDateTimePickers(startDate, endDate);
            bool isComboBoxValid = ValidateComboBox();

            if (!isDateValid || !isComboBoxValid)
                return;

            // Display Dates in labels
            lblStartDate_RequestReports.Text = startDate.Date.ToString("yyyy/MM/dd");
            lblEndDate_RequestReports.Text = endDate.Date.ToString("yyyy/MM/dd");

            // Assign ASC or DESC to Order_By based on ComboBox selection
            Order_By = cbOrderBy_RequestReports.SelectedIndex == 0 ? "ASC" : "DESC";

            // Generate report based on selected report type
            if (cbReportType_RequestReports.SelectedIndex == 0)
            {
                GenerateTop10VehiclesReport(startDate, endDate, Order_By);
            }
            else if (cbReportType_RequestReports.SelectedIndex == 1)
            {
                GenerateIncomeReceivedReport(startDate, endDate, Order_By);
            }



            pbRequestReports.SendToBack();
        }
        private void GenerateTop10VehiclesReport(DateTime startDate, DateTime endDate, string Order_By)
        {
            //Validation
            int total_Entries = 0;
            lblReportTypeName.Text = "Top 10 Vehicles Per Time Period";

            //Resets the Data Grid View
            dgvRequestReports.Rows.Clear();
            dgvRequestReports.Columns.Clear();


            // Add to Data Grid View Columns 
            dgvRequestReports.ColumnCount = 4;
            dgvRequestReports.Columns[0].Name = "Vehicle_ID";
            dgvRequestReports.Columns[1].Name = "Vehicle Name";
            dgvRequestReports.Columns[2].Name = "Vehicle Class";
            dgvRequestReports.Columns[3].Name = "Rental Count";

            // SQL query to get the top 10 vehicles
            string query = @"
        SELECT TOP 10 
            V.Vehicle_ID, 
            V.Vehicle_Name, 
            VC.ClassName AS Vehicle_Class, 
            COUNT(RO.Order_ID) AS Rental_Count
        FROM 
            RentalOrder RO
        JOIN 
            Vehicle V ON RO.Vehicle_ID = V.Vehicle_ID
        JOIN 
            Vehicle_Class VC ON V.Vehicle_Class_ID = VC.Vehicle_Class_ID
        WHERE 
            RO.Date BETWEEN @StartDate AND @EndDate
        GROUP BY 
            V.Vehicle_ID, V.Vehicle_Name, VC.ClassName
        ORDER BY 
            Rental_Count " + Order_By + ";";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);


                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] row = {
                reader["Vehicle_ID"].ToString(),
                reader["Vehicle_Name"].ToString(),
                reader["Vehicle_Class"].ToString(),
                reader["Rental_Count"].ToString()
            };
                    dgvRequestReports.Rows.Add(row);
                }

                reader.Close();
            }

            // Calculate and add the total row
            int totalRentals = dgvRequestReports.Rows.Cast<DataGridViewRow>().Sum(r => Convert.ToInt32(r.Cells["Rental Count"].Value));

            string[] totalRow = { "Total:", "", "", totalRentals.ToString() };
            dgvRequestReports.Rows.Add(totalRow);

            // Apply styles as in your original code
            ApplyDataGridViewStyles();

            total_Entries = dgvRequestReports.Rows.Count - 1;
            lblTotalEntries_RequestReports.Text = total_Entries.ToString();
        }

        private void GenerateIncomeReceivedReport(DateTime startDate, DateTime endDate, string Order_By)
        {
            //Validation 
            lblReportTypeName.Text = "Income Recieved Per Time Period";

            //Resets the Data Grid View
            dgvRequestReports.Rows.Clear();
            dgvRequestReports.Columns.Clear();


            dgvRequestReports.ColumnCount = 3;

            dgvRequestReports.Columns[0].Name = "Date";
            dgvRequestReports.Columns[1].Name = "Vehicle Class";
            dgvRequestReports.Columns[2].Name = "Income";


            decimal grandTotal = 0;
            int total_Entries = 0;

            // SQL query to get the data
            string query = @"
    SELECT 
        FORMAT(Date, 'yyyy MMMM') AS Month,
        Vehicle_Class.ClassName,
        SUM(OrderCost) AS Income,
        DATEPART(MONTH, Date) AS MonthNumber,
        DATEPART(YEAR, Date) AS YearNumber
    FROM 
        RentalOrder 
    INNER JOIN 
        Vehicle ON RentalOrder.Vehicle_ID = Vehicle.Vehicle_ID
    INNER JOIN 
        Vehicle_Class ON Vehicle.Vehicle_Class_ID = Vehicle_Class.Vehicle_Class_ID
    WHERE 
        Date >= @startDate AND Date <= @endDate
    GROUP BY 
        FORMAT(Date, 'yyyy MMMM'), Vehicle_Class.ClassName, DATEPART(MONTH, Date), DATEPART(YEAR, Date)
    ORDER BY 
        YearNumber, MonthNumber , Income " + Order_By + ", Vehicle_Class.ClassName";

            // Connect to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string currentMonth = null;
                        decimal monthlyTotal = 0;

                        while (reader.Read())
                        {
                            string month = reader["Month"].ToString();
                            string vehicleClass = reader["ClassName"].ToString();
                            decimal income = Convert.ToDecimal(reader["Income"]);

                            // New month, add the total row for the previous month
                            if (currentMonth != null && month != currentMonth)
                            {
                                dgvRequestReports.Rows.Add("", "Total:", "R " + monthlyTotal.ToString("N2"));
                                dgvRequestReports.Rows.Add("");
                                monthlyTotal = 0; // Reset monthly total
                            }

                            // Add month header
                            if (month != currentMonth)
                            {
                                dgvRequestReports.Rows.Add(month, "", "");
                                currentMonth = month;
                            }

                            // Add vehicle class and income
                            dgvRequestReports.Rows.Add("", vehicleClass, "R " + income.ToString("N2"));
                            monthlyTotal += income;
                            grandTotal += income;

                            if (!string.IsNullOrWhiteSpace(vehicleClass))
                            {
                                total_Entries++;
                            }

                        }

                        // Add the last month's total row
                        if (currentMonth != null)
                        {
                            dgvRequestReports.Rows.Add("", "Total:", "R " + monthlyTotal.ToString("N2"));
                        }
                    }
                }
            }

            // Add the grand total row
            dgvRequestReports.Rows.Add("");
            dgvRequestReports.Rows.Add("", "Grand Total:", "R " + grandTotal.ToString("N2"));
            lblTotalEntries_RequestReports.Text = total_Entries.ToString();


            ApplyDataGridViewStyles();
        }


        private void ApplyDataGridViewStyles()
        {
            // Set header styling for the Column Names
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Font = new Font("Arial", 12F, FontStyle.Bold);
            headerStyle.BackColor = Color.Black;
            headerStyle.ForeColor = Color.White;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRequestReports.ColumnHeadersDefaultCellStyle = headerStyle;

            // Adjust DataGridView Styling Cell style inside the DataGridView
            dgvRequestReports.DefaultCellStyle.Font = new Font("Arial", 10F);
            dgvRequestReports.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRequestReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle boldStyle = new DataGridViewCellStyle();
            boldStyle.Font = new Font("Arial", 10F, FontStyle.Bold);


            // Apply the bold style to specific rows
            foreach (DataGridViewRow row in dgvRequestReports.Rows)
            {

                if (row.Cells[1].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    if (cellValue.StartsWith("Total:") || cellValue.StartsWith("Grand Total:"))
                    {
                        row.DefaultCellStyle = boldStyle;
                    }
                }
            }

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateDateTimePickers(DateTime startDate, DateTime endDate)
        {
            bool isValid = true;
            errorProvider.SetError(dtpStartDate_RequestReports, "");
            errorProvider.SetError(dtpEndDate_RequestReports, "");

            if (startDate.Date == endDate.Date)
            {
                errorProvider.SetError(dtpStartDate_RequestReports, "Start Date cannot be the same as End Date.");
                errorProvider.SetError(dtpEndDate_RequestReports, "Start Date cannot be the same as End Date.");
                isValid = false;
            }
            else if (startDate.Date > endDate.Date)
            {
                errorProvider.SetError(dtpEndDate_RequestReports, "End Date cannot be earlier than Start Date.");
                errorProvider.SetError(dtpStartDate_RequestReports, "");
                MessageBox.Show("Start Date cannot be later than End Date.");
                isValid = false;
            }

            return isValid;
        }

        private bool ValidateComboBox()
        {
            bool isValid = true;
            errorProvider.SetError(cbOrderBy_RequestReports, "");
            errorProvider.SetError(cbReportType_RequestReports, "");

            if (cbOrderBy_RequestReports.SelectedIndex == -1 && cbReportType_RequestReports.SelectedIndex == -1)
            {
                errorProvider.SetError(cbOrderBy_RequestReports, "Please select an Order By option.");
                errorProvider.SetError(cbReportType_RequestReports, "Please select a Report Type.");
                isValid = false;
            }
            else if (cbReportType_RequestReports.SelectedIndex == -1)
            {
                errorProvider.SetError(cbReportType_RequestReports, "Please select a Report Type.");
                isValid = false;
            }
            else if (cbOrderBy_RequestReports.SelectedIndex == -1)
            {
                errorProvider.SetError(cbOrderBy_RequestReports, "Please select an Order By option.");
                isValid = false;
            }

            return isValid;
        }

        private void btnClear_RequestReports_Click(object sender, EventArgs e)
        {
            dgvRequestReports.Rows.Clear();
            dgvRequestReports.Columns.Clear();

            cbReportType_RequestReports.SelectedIndex = -1;
            cbOrderBy_RequestReports.SelectedIndex = -1;

            dtpStartDate_RequestReports.Value = DateTime.Today;
            dtpEndDate_RequestReports.Value = DateTime.Today.AddDays(1);


            lblStartDate_RequestReports.Text = ".....";
            lblEndDate_RequestReports.Text = ".....";

            pbRequestReports.BringToFront();

        }

        private void btnBack_RequestReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}