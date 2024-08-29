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
        public frmRequestReports()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string selectedReport = cbReportType_RequestReports.SelectedItem.ToString();

            // Ensure a report type is selected
            if (string.IsNullOrEmpty(selectedReport))
            {
                MessageBox.Show("Please select a report type.");
                return;
            }

            // Retrieve the selected date range
            DateTime startDate = dtpStartDate_RequestReports.Value;
            DateTime endDate = dtpEndDate_RequestReports.Value;

            if (selectedReport == "Top 10 Vehicles Per Time Period")
            {
                GenerateTop10VehiclesReport(startDate, endDate);
            }
            else if (selectedReport == "Income Received Per Time Period")
            {
                GenerateIncomeReceivedReport(startDate, endDate);
            }
            else
            {
                MessageBox.Show("Unknown report type selected.");
            }
        }

        private void GenerateTop10VehiclesReport(DateTime startDate, DateTime endDate)
        {

        }

        private void GenerateIncomeReceivedReport(DateTime startDate, DateTime endDate)
        {

        }

        private void frmRequestReports_Load(object sender, EventArgs e)
        {

            {
                // Configure DataGridView columns
                dgvVehicleClasses_Add.ColumnCount = 4;
                dgvVehicleClasses_Add.Columns[0].Name = "Vehicle_ID";
                dgvVehicleClasses_Add.Columns[1].Name = "Vehicle Name";
                dgvVehicleClasses_Add.Columns[2].Name = "Vehicle Class";
                dgvVehicleClasses_Add.Columns[3].Name = "Rental Count";

                // Example Data

                string[] row1 = { "2", "Polo", "Economy", "80" };
                string[] row2 = { "3", "Fortuner", "SUV", "60" };
                string[] row3 = { "1", "C200", "Sedan", "27" };

                dgvVehicleClasses_Add.Rows.Add(row1);
                dgvVehicleClasses_Add.Rows.Add(row2);
                dgvVehicleClasses_Add.Rows.Add(row3);

                // Adding the Total row
                string[] totalRow = { "Total:", "", "", "167" };
                dgvVehicleClasses_Add.Rows.Add(totalRow);

                // Add footer information as additional rows


                // Set header styling the Column Names
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Font = new Font("Arial", 12F, FontStyle.Bold);
                headerStyle.BackColor = Color.Black;
                headerStyle.ForeColor = Color.White;
                headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvVehicleClasses_Add.ColumnHeadersDefaultCellStyle = headerStyle;

                // Adjust DataGridView Styling Cell style inside the DataGridView
                dgvVehicleClasses_Add.DefaultCellStyle.Font = new Font("Arial", 10F);
                dgvVehicleClasses_Add.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvVehicleClasses_Add.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataGridViewCellStyle boldStyle = new DataGridViewCellStyle();
                boldStyle.Font = new Font("Arial", 10F, FontStyle.Bold);

                // Apply the bold style to specific rows
                foreach (DataGridViewRow row in dgvVehicleClasses_Add.Rows)
                {
                    // Apply bold style to the 'Total:' row
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().StartsWith("Total:"))
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
    }
}
