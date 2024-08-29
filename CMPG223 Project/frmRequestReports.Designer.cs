namespace CMPG223_Project
{
    partial class frmRequestReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            cbReportType_RequestReports = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpStartDate_RequestReports = new DateTimePicker();
            dtpEndDate_RequestReports = new DateTimePicker();
            btnGenerateReport = new Button();
            btnBack_RequestReport = new Button();
            dgvVehicleClasses_Add = new DataGridView();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label11 = new Label();
            label16 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            pictureBox1.Location = new Point(798, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cbReportType_RequestReports
            // 
            cbReportType_RequestReports.FormattingEnabled = true;
            cbReportType_RequestReports.Items.AddRange(new object[] { "Top 10 Vehicles Per Time Period ", "Income Recieved Per Time Period" });
            cbReportType_RequestReports.Location = new Point(217, 125);
            cbReportType_RequestReports.Name = "cbReportType_RequestReports";
            cbReportType_RequestReports.Size = new Size(248, 28);
            cbReportType_RequestReports.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(199, 41);
            label1.TabIndex = 2;
            label1.Text = "Report Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(12, 172);
            label2.Name = "label2";
            label2.Size = new Size(177, 41);
            label2.TabIndex = 3;
            label2.Text = "Start Date: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(12, 230);
            label3.Name = "label3";
            label3.Size = new Size(161, 41);
            label3.TabIndex = 4;
            label3.Text = "End Date: ";
            // 
            // dtpStartDate_RequestReports
            // 
            dtpStartDate_RequestReports.Location = new Point(217, 186);
            dtpStartDate_RequestReports.Name = "dtpStartDate_RequestReports";
            dtpStartDate_RequestReports.Size = new Size(250, 27);
            dtpStartDate_RequestReports.TabIndex = 5;
            // 
            // dtpEndDate_RequestReports
            // 
            dtpEndDate_RequestReports.Location = new Point(217, 244);
            dtpEndDate_RequestReports.Name = "dtpEndDate_RequestReports";
            dtpEndDate_RequestReports.Size = new Size(250, 27);
            dtpEndDate_RequestReports.TabIndex = 6;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(217, 323);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(104, 52);
            btnGenerateReport.TabIndex = 7;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnBack_RequestReport
            // 
            btnBack_RequestReport.Location = new Point(361, 323);
            btnBack_RequestReport.Name = "btnBack_RequestReport";
            btnBack_RequestReport.Size = new Size(104, 52);
            btnBack_RequestReport.TabIndex = 8;
            btnBack_RequestReport.Text = "Back";
            btnBack_RequestReport.UseVisualStyleBackColor = true;
            // 
            // dgvVehicleClasses_Add
            // 
            dgvVehicleClasses_Add.AllowUserToAddRows = false;
            dgvVehicleClasses_Add.AllowUserToDeleteRows = false;
            dgvVehicleClasses_Add.AllowUserToResizeColumns = false;
            dgvVehicleClasses_Add.AllowUserToResizeRows = false;
            dgvVehicleClasses_Add.BackgroundColor = SystemColors.ControlLightLight;
            dgvVehicleClasses_Add.BorderStyle = BorderStyle.None;
            dgvVehicleClasses_Add.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVehicleClasses_Add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVehicleClasses_Add.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVehicleClasses_Add.Enabled = false;
            dgvVehicleClasses_Add.Location = new Point(506, 230);
            dgvVehicleClasses_Add.Name = "dgvVehicleClasses_Add";
            dgvVehicleClasses_Add.ReadOnly = true;
            dgvVehicleClasses_Add.RowHeadersVisible = false;
            dgvVehicleClasses_Add.RowHeadersWidth = 51;
            dgvVehicleClasses_Add.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVehicleClasses_Add.Size = new Size(744, 396);
            dgvVehicleClasses_Add.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label4.Location = new Point(2, 9);
            label4.Name = "label4";
            label4.Size = new Size(280, 46);
            label4.TabIndex = 10;
            label4.Text = "Request Reports";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(506, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(744, 768);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(713, 118);
            label5.Name = "label5";
            label5.Size = new Size(352, 46);
            label5.TabIndex = 12;
            label5.Text = "Road Runner Rentals";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(525, 186);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 13;
            label6.Text = "Start Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(637, 186);
            label7.Name = "label7";
            label7.Size = new Size(116, 28);
            label7.TabIndex = 14;
            label7.Text = "28/07/2024";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(828, 186);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 15;
            label8.Text = "End Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(937, 185);
            label9.Name = "label9";
            label9.Size = new Size(116, 28);
            label9.TabIndex = 16;
            label9.Text = "28/08/2024";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(798, 650);
            label10.Name = "label10";
            label10.Size = new Size(135, 28);
            label10.TabIndex = 17;
            label10.Text = "Total Entries:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(798, 702);
            label12.Name = "label12";
            label12.Size = new Size(147, 28);
            label12.TabIndex = 19;
            label12.Text = "End Of Report";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(939, 650);
            label13.Name = "label13";
            label13.Size = new Size(24, 28);
            label13.TabIndex = 20;
            label13.Text = "3";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(674, 158);
            label14.Name = "label14";
            label14.Size = new Size(24, 28);
            label14.TabIndex = 21;
            label14.Text = "1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(713, 718);
            label15.Name = "label15";
            label15.Size = new Size(0, 28);
            label15.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(525, 158);
            label11.Name = "label11";
            label11.Size = new Size(147, 28);
            label11.TabIndex = 23;
            label11.Text = "Page Number:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label16.Location = new Point(819, 743);
            label16.Name = "label16";
            label16.Size = new Size(52, 23);
            label16.TabIndex = 24;
            label16.Text = "Page:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label17.Location = new Point(873, 743);
            label17.Name = "label17";
            label17.Size = new Size(38, 23);
            label17.TabIndex = 25;
            label17.Text = "1/2";
            // 
            // frmRequestReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 170, 146);
            ClientSize = new Size(1262, 803);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvVehicleClasses_Add);
            Controls.Add(btnBack_RequestReport);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtpEndDate_RequestReports);
            Controls.Add(dtpStartDate_RequestReports);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbReportType_RequestReports);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "frmRequestReports";
            Text = "frmRequestReports";
            Load += frmRequestReports_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Add).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cbReportType_RequestReports;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpStartDate_RequestReports;
        private DateTimePicker dtpEndDate_RequestReports;
        private Button btnGenerateReport;
        private Button btnBack_RequestReport;
        private DataGridView dgvVehicleClasses_Add;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label11;
        private Label label16;
        private Label label17;
    }
}