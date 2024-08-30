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

    }

}
