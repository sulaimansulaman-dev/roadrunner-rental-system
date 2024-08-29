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
            pictureBox1 = new PictureBox();
            cbReportType_RequestReports = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpStartDate_RequestReports = new DateTimePicker();
            dtpEndDate_RequestReports = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            dgvVehicleClasses_Add = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Add).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            pictureBox1.Location = new Point(2, 401);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cbReportType_RequestReports
            // 
            cbReportType_RequestReports.FormattingEnabled = true;
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
            // button1
            // 
            button1.Location = new Point(361, 434);
            button1.Name = "button1";
            button1.Size = new Size(104, 52);
            button1.TabIndex = 7;
            button1.Text = "Generate Report";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(512, 434);
            button2.Name = "button2";
            button2.Size = new Size(104, 52);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvVehicleClasses_Add
            // 
            dgvVehicleClasses_Add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleClasses_Add.Location = new Point(512, 95);
            dgvVehicleClasses_Add.Name = "dgvVehicleClasses_Add";
            dgvVehicleClasses_Add.RowHeadersWidth = 51;
            dgvVehicleClasses_Add.Size = new Size(473, 293);
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
            // frmRequestReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 170, 146);
            ClientSize = new Size(1027, 584);
            Controls.Add(label4);
            Controls.Add(dgvVehicleClasses_Add);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpEndDate_RequestReports);
            Controls.Add(dtpStartDate_RequestReports);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbReportType_RequestReports);
            Controls.Add(pictureBox1);
            Name = "frmRequestReports";
            Text = "frmRequestReports";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Add).EndInit();
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
        private Button button1;
        private Button button2;
        private DataGridView dgvVehicleClasses_Add;
        private Label label4;
    }
}