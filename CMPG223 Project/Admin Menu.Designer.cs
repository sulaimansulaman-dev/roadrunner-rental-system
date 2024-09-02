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
            buttonReports = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 12);
            label1.Name = "label1";
            label1.Size = new Size(516, 62);
            label1.TabIndex = 0;
            label1.Text = "Welcome Administrator";
            // 
            // buttonClient
            // 
            buttonClient.Anchor = AnchorStyles.None;
            buttonClient.Location = new Point(187, 204);
            buttonClient.Margin = new Padding(3, 4, 3, 4);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(230, 84);
            buttonClient.TabIndex = 1;
            buttonClient.Text = "Maintain Clients";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += button1_Click;
            // 
            // buttonVehicleClass
            // 
            buttonVehicleClass.Anchor = AnchorStyles.None;
            buttonVehicleClass.Location = new Point(689, 311);
            buttonVehicleClass.Margin = new Padding(3, 4, 3, 4);
            buttonVehicleClass.Name = "buttonVehicleClass";
            buttonVehicleClass.Size = new Size(230, 84);
            buttonVehicleClass.TabIndex = 2;
            buttonVehicleClass.Text = "Maintain Vehicle Classes";
            buttonVehicleClass.UseVisualStyleBackColor = true;
            buttonVehicleClass.Click += button2_Click;
            // 
            // buttonVehicle
            // 
            buttonVehicle.Anchor = AnchorStyles.None;
            buttonVehicle.Location = new Point(689, 204);
            buttonVehicle.Margin = new Padding(3, 4, 3, 4);
            buttonVehicle.Name = "buttonVehicle";
            buttonVehicle.Size = new Size(230, 84);
            buttonVehicle.TabIndex = 3;
            buttonVehicle.Text = "Maintain Vehicles";
            buttonVehicle.UseVisualStyleBackColor = true;
            buttonVehicle.Click += button3_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.Anchor = AnchorStyles.None;
            buttonUsers.Location = new Point(187, 311);
            buttonUsers.Margin = new Padding(3, 4, 3, 4);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(230, 84);
            buttonUsers.TabIndex = 4;
            buttonUsers.Text = "Maintain Users";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += button4_Click;
            // 
            // buttonRentalOrder
            // 
            buttonRentalOrder.Anchor = AnchorStyles.None;
            buttonRentalOrder.Location = new Point(187, 417);
            buttonRentalOrder.Margin = new Padding(3, 4, 3, 4);
            buttonRentalOrder.Name = "buttonRentalOrder";
            buttonRentalOrder.Size = new Size(230, 84);
            buttonRentalOrder.TabIndex = 5;
            buttonRentalOrder.Text = "Rental Orders";
            buttonRentalOrder.UseVisualStyleBackColor = true;
            buttonRentalOrder.Click += button5_Click;
            // 
            // buttonReports
            // 
            buttonReports.Anchor = AnchorStyles.None;
            buttonReports.Location = new Point(689, 417);
            buttonReports.Margin = new Padding(3, 4, 3, 4);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(230, 84);
            buttonReports.TabIndex = 8;
            buttonReports.Text = "Request Reports";
            buttonReports.UseVisualStyleBackColor = true;
            buttonReports.Click += button8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 676);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 69);
            button1.TabIndex = 9;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(967, 676);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(121, 69);
            button2.TabIndex = 10;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Admin_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 170, 146);
            BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1102, 761);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonReports);
            Controls.Add(buttonRentalOrder);
            Controls.Add(buttonUsers);
            Controls.Add(buttonVehicle);
            Controls.Add(buttonVehicleClass);
            Controls.Add(buttonClient);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Menu";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button buttonReports;
        private Button button1;
        private Button button2;
    }
}
