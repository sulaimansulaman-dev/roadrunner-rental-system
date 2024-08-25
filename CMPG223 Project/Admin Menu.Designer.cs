namespace CMPG223_Project
{
    partial class Admin_Menu
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
            label1 = new Label();
            buttonClient = new Button();
            buttonVehicleClass = new Button();
            buttonVehicle = new Button();
            buttonUsers = new Button();
            buttonRentalOrder = new Button();
            buttonPayment = new Button();
            buttonReturn = new Button();
            buttonReports = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(410, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome Administrator";
            // 
            // buttonClient
            // 
            buttonClient.Anchor = AnchorStyles.None;
            buttonClient.Location = new Point(175, 132);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(171, 53);
            buttonClient.TabIndex = 1;
            buttonClient.Text = "Maintain Clients";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += button1_Click;
            // 
            // buttonVehicleClass
            // 
            buttonVehicleClass.Anchor = AnchorStyles.None;
            buttonVehicleClass.Location = new Point(175, 208);
            buttonVehicleClass.Name = "buttonVehicleClass";
            buttonVehicleClass.Size = new Size(171, 53);
            buttonVehicleClass.TabIndex = 2;
            buttonVehicleClass.Text = "Maintain Vehicle Classes";
            buttonVehicleClass.UseVisualStyleBackColor = true;
            buttonVehicleClass.Click += button2_Click;
            // 
            // buttonVehicle
            // 
            buttonVehicle.Anchor = AnchorStyles.None;
            buttonVehicle.Location = new Point(175, 284);
            buttonVehicle.Name = "buttonVehicle";
            buttonVehicle.Size = new Size(171, 53);
            buttonVehicle.TabIndex = 3;
            buttonVehicle.Text = "Maintain Vehicles";
            buttonVehicle.UseVisualStyleBackColor = true;
            buttonVehicle.Click += button3_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.Anchor = AnchorStyles.None;
            buttonUsers.Location = new Point(175, 362);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(171, 53);
            buttonUsers.TabIndex = 4;
            buttonUsers.Text = "Maintain Users";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += button4_Click;
            // 
            // buttonRentalOrder
            // 
            buttonRentalOrder.Anchor = AnchorStyles.None;
            buttonRentalOrder.Location = new Point(623, 132);
            buttonRentalOrder.Name = "buttonRentalOrder";
            buttonRentalOrder.Size = new Size(171, 53);
            buttonRentalOrder.TabIndex = 5;
            buttonRentalOrder.Text = "Rental Orders";
            buttonRentalOrder.UseVisualStyleBackColor = true;
            buttonRentalOrder.Click += button5_Click;
            // 
            // buttonPayment
            // 
            buttonPayment.Anchor = AnchorStyles.None;
            buttonPayment.Location = new Point(623, 208);
            buttonPayment.Name = "buttonPayment";
            buttonPayment.Size = new Size(171, 53);
            buttonPayment.TabIndex = 6;
            buttonPayment.Text = "Recieve a Payment";
            buttonPayment.UseVisualStyleBackColor = true;
            buttonPayment.Click += button6_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.Anchor = AnchorStyles.None;
            buttonReturn.Location = new Point(623, 284);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(171, 53);
            buttonReturn.TabIndex = 7;
            buttonReturn.Text = "Return Vehicle";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += button7_Click;
            // 
            // buttonReports
            // 
            buttonReports.Anchor = AnchorStyles.None;
            buttonReports.Location = new Point(623, 362);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(171, 53);
            buttonReports.TabIndex = 8;
            buttonReports.Text = "Request Reports";
            buttonReports.UseVisualStyleBackColor = true;
            buttonReports.Click += button8_Click;
            // 
            // Admin_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 170, 146);
            BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(964, 571);
            Controls.Add(buttonReports);
            Controls.Add(buttonReturn);
            Controls.Add(buttonPayment);
            Controls.Add(buttonRentalOrder);
            Controls.Add(buttonUsers);
            Controls.Add(buttonVehicle);
            Controls.Add(buttonVehicleClass);
            Controls.Add(buttonClient);
            Controls.Add(label1);
            Name = "Admin_Menu";
            Text = "Admin_Menu";
            Load += Admin_Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonClient;
        private Button buttonVehicleClass;
        private Button buttonVehicle;
        private Button buttonUsers;
        private Button buttonRentalOrder;
        private Button buttonPayment;
        private Button buttonReturn;
        private Button buttonReports;
    }
}