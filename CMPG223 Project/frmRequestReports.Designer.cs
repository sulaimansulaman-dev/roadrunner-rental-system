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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            cbReportType_RequestReports = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpStartDate_RequestReports = new DateTimePicker();
            dtpEndDate_RequestReports = new DateTimePicker();
            btnGenerateReport = new Button();
            btnBack_RequestReport = new Button();
            dgvRequestReports = new DataGridView();
            label4 = new Label();
            pbRequestReports = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            lblStartDate_RequestReports = new Label();
            label8 = new Label();
            lblEndDate_RequestReports = new Label();
            label10 = new Label();
            label12 = new Label();
            lblTotalEntries_RequestReports = new Label();
            lblPageNumber_RequestReports = new Label();
            label15 = new Label();
            label11 = new Label();
            label16 = new Label();
            lblPageNumberDual_RequestReports = new Label();
            btnClear_RequestReports = new Button();
            lblOrderBy_RequestReports = new Label();
            cbOrderBy_RequestReports = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            lblReportTypeName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequestReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRequestReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            pictureBox1.Location = new Point(786, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cbReportType_RequestReports
            // 
            cbReportType_RequestReports.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReportType_RequestReports.Items.AddRange(new object[] { "Top 10 Vehicles Per Time Period ", "Income Recieved Per Time Period" });
            cbReportType_RequestReports.Location = new Point(217, 126);
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
            label2.Location = new Point(12, 216);
            label2.Name = "label2";
            label2.Size = new Size(177, 41);
            label2.TabIndex = 3;
            label2.Text = "Start Date: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(12, 267);
            label3.Name = "label3";
            label3.Size = new Size(161, 41);
            label3.TabIndex = 4;
            label3.Text = "End Date: ";
            // 
            // dtpStartDate_RequestReports
            // 
            dtpStartDate_RequestReports.Location = new Point(217, 230);
            dtpStartDate_RequestReports.Name = "dtpStartDate_RequestReports";
            dtpStartDate_RequestReports.Size = new Size(250, 27);
            dtpStartDate_RequestReports.TabIndex = 5;
            // 
            // dtpEndDate_RequestReports
            // 
            dtpEndDate_RequestReports.Location = new Point(217, 279);
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
            // dgvRequestReports
            // 
            dgvRequestReports.AllowUserToAddRows = false;
            dgvRequestReports.AllowUserToDeleteRows = false;
            dgvRequestReports.AllowUserToResizeColumns = false;
            dgvRequestReports.AllowUserToResizeRows = false;
            dgvRequestReports.BackgroundColor = SystemColors.ControlLightLight;
            dgvRequestReports.BorderStyle = BorderStyle.None;
            dgvRequestReports.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRequestReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvRequestReports.DefaultCellStyle = dataGridViewCellStyle1;
            dgvRequestReports.Enabled = false;
            dgvRequestReports.Location = new Point(506, 245);
            dgvRequestReports.Name = "dgvRequestReports";
            dgvRequestReports.ReadOnly = true;
            dgvRequestReports.RowHeadersVisible = false;
            dgvRequestReports.RowHeadersWidth = 51;
            dgvRequestReports.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRequestReports.Size = new Size(744, 402);
            dgvRequestReports.TabIndex = 9;
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
            // pbRequestReports
            // 
            pbRequestReports.BackColor = Color.White;
            pbRequestReports.Location = new Point(506, 9);
            pbRequestReports.Name = "pbRequestReports";
            pbRequestReports.Size = new Size(744, 782);
            pbRequestReports.SizeMode = PictureBoxSizeMode.Zoom;
            pbRequestReports.TabIndex = 11;
            pbRequestReports.TabStop = false;
            pbRequestReports.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(713, 103);
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
            label6.Location = new Point(526, 205);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 13;
            label6.Text = "Start Date:";
            // 
            // lblStartDate_RequestReports
            // 
            lblStartDate_RequestReports.AutoSize = true;
            lblStartDate_RequestReports.BackColor = Color.White;
            lblStartDate_RequestReports.Font = new Font("Segoe UI", 12F);
            lblStartDate_RequestReports.Location = new Point(638, 205);
            lblStartDate_RequestReports.Name = "lblStartDate_RequestReports";
            lblStartDate_RequestReports.Size = new Size(32, 28);
            lblStartDate_RequestReports.TabIndex = 14;
            lblStartDate_RequestReports.Text = ".....";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(829, 205);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 15;
            label8.Text = "End Date:";
            // 
            // lblEndDate_RequestReports
            // 
            lblEndDate_RequestReports.AutoSize = true;
            lblEndDate_RequestReports.BackColor = Color.White;
            lblEndDate_RequestReports.Font = new Font("Segoe UI", 12F);
            lblEndDate_RequestReports.Location = new Point(938, 204);
            lblEndDate_RequestReports.Name = "lblEndDate_RequestReports";
            lblEndDate_RequestReports.Size = new Size(32, 28);
            lblEndDate_RequestReports.TabIndex = 16;
            lblEndDate_RequestReports.Text = ".....";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(774, 698);
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
            label12.Location = new Point(774, 726);
            label12.Name = "label12";
            label12.Size = new Size(147, 28);
            label12.TabIndex = 19;
            label12.Text = "End Of Report";
            // 
            // lblTotalEntries_RequestReports
            // 
            lblTotalEntries_RequestReports.AutoSize = true;
            lblTotalEntries_RequestReports.BackColor = Color.White;
            lblTotalEntries_RequestReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEntries_RequestReports.Location = new Point(915, 698);
            lblTotalEntries_RequestReports.Name = "lblTotalEntries_RequestReports";
            lblTotalEntries_RequestReports.Size = new Size(32, 28);
            lblTotalEntries_RequestReports.TabIndex = 20;
            lblTotalEntries_RequestReports.Text = "....";
            lblTotalEntries_RequestReports.Click += label13_Click;
            // 
            // lblPageNumber_RequestReports
            // 
            lblPageNumber_RequestReports.AutoSize = true;
            lblPageNumber_RequestReports.BackColor = Color.White;
            lblPageNumber_RequestReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageNumber_RequestReports.Location = new Point(675, 177);
            lblPageNumber_RequestReports.Name = "lblPageNumber_RequestReports";
            lblPageNumber_RequestReports.Size = new Size(24, 28);
            lblPageNumber_RequestReports.TabIndex = 21;
            lblPageNumber_RequestReports.Text = "1";
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
            label11.Location = new Point(526, 177);
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
            label16.Location = new Point(815, 754);
            label16.Name = "label16";
            label16.Size = new Size(52, 23);
            label16.TabIndex = 24;
            label16.Text = "Page:";
            // 
            // lblPageNumberDual_RequestReports
            // 
            lblPageNumberDual_RequestReports.AutoSize = true;
            lblPageNumberDual_RequestReports.BackColor = Color.White;
            lblPageNumberDual_RequestReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageNumberDual_RequestReports.Location = new Point(873, 754);
            lblPageNumberDual_RequestReports.Name = "lblPageNumberDual_RequestReports";
            lblPageNumberDual_RequestReports.Size = new Size(20, 23);
            lblPageNumberDual_RequestReports.TabIndex = 25;
            lblPageNumberDual_RequestReports.Text = "1";
            // 
            // btnClear_RequestReports
            // 
            btnClear_RequestReports.Location = new Point(294, 403);
            btnClear_RequestReports.Name = "btnClear_RequestReports";
            btnClear_RequestReports.Size = new Size(104, 52);
            btnClear_RequestReports.TabIndex = 26;
            btnClear_RequestReports.Text = "Clear";
            btnClear_RequestReports.UseVisualStyleBackColor = true;
            btnClear_RequestReports.Click += btnClear_RequestReports_Click;
            // 
            // lblOrderBy_RequestReports
            // 
            lblOrderBy_RequestReports.AutoSize = true;
            lblOrderBy_RequestReports.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblOrderBy_RequestReports.Location = new Point(12, 159);
            lblOrderBy_RequestReports.Name = "lblOrderBy_RequestReports";
            lblOrderBy_RequestReports.Size = new Size(151, 41);
            lblOrderBy_RequestReports.TabIndex = 27;
            lblOrderBy_RequestReports.Text = "Order By:";
            // 
            // cbOrderBy_RequestReports
            // 
            cbOrderBy_RequestReports.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrderBy_RequestReports.FormattingEnabled = true;
            cbOrderBy_RequestReports.Items.AddRange(new object[] { "Ascending", "Descending" });
            cbOrderBy_RequestReports.Location = new Point(217, 172);
            cbOrderBy_RequestReports.Name = "cbOrderBy_RequestReports";
            cbOrderBy_RequestReports.Size = new Size(248, 28);
            cbOrderBy_RequestReports.TabIndex = 28;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // lblReportTypeName
            // 
            lblReportTypeName.AutoSize = true;
            lblReportTypeName.BackColor = Color.White;
            lblReportTypeName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportTypeName.Location = new Point(526, 149);
            lblReportTypeName.Name = "lblReportTypeName";
            lblReportTypeName.Size = new Size(367, 31);
            lblReportTypeName.TabIndex = 29;
            lblReportTypeName.Text = "Income Recieved Per Time Period";
            // 
            // frmRequestReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 170, 146);
            ClientSize = new Size(1262, 803);
            Controls.Add(lblReportTypeName);
            Controls.Add(cbOrderBy_RequestReports);
            Controls.Add(lblOrderBy_RequestReports);
            Controls.Add(btnClear_RequestReports);
            Controls.Add(lblPageNumberDual_RequestReports);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(label15);
            Controls.Add(lblPageNumber_RequestReports);
            Controls.Add(lblTotalEntries_RequestReports);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(lblEndDate_RequestReports);
            Controls.Add(label8);
            Controls.Add(lblStartDate_RequestReports);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvRequestReports);
            Controls.Add(btnBack_RequestReport);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtpEndDate_RequestReports);
            Controls.Add(dtpStartDate_RequestReports);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbReportType_RequestReports);
            Controls.Add(pictureBox1);
            Controls.Add(pbRequestReports);
            Name = "frmRequestReports";
            Text = "frmRequestReports";
            Load += frmRequestReports_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequestReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRequestReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
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
        private DataGridView dgvRequestReports;
        private Label label4;
        private PictureBox pbRequestReports;
        private Label label5;
        private Label label6;
        private Label lblStartDate_RequestReports;
        private Label label8;
        private Label lblEndDate_RequestReports;
        private Label label10;
        private Label label12;
        private Label lblTotalEntries_RequestReports;
        private Label lblPageNumber_RequestReports;
        private Label label15;
        private Label label11;
        private Label label16;
        private Label lblPageNumberDual_RequestReports;
        private Button btnClear_RequestReports;
        private Label lblOrderBy_RequestReports;
        private ComboBox cbOrderBy_RequestReports;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Label lblReportTypeName;
    }
}