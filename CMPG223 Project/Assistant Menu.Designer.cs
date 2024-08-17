namespace CMPG223_Project
{
    partial class Assistant_Menu
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
            comboBoxUsers = new ComboBox();
            labelWelcome = new Label();
            buttonClient = new Button();
            buttonPayment = new Button();
            buttonOrder = new Button();
            buttonReturn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(428, 50);
            label1.TabIndex = 0;
            label1.Text = "Please select your profile";
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(400, 62);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(133, 23);
            comboBoxUsers.TabIndex = 1;
            comboBoxUsers.Text = "Please Select Profile";
            comboBoxUsers.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(400, 508);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(169, 32);
            labelWelcome.TabIndex = 2;
            labelWelcome.Text = "LabelWelcome";
            // 
            // buttonClient
            // 
            buttonClient.Location = new Point(120, 170);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(214, 66);
            buttonClient.TabIndex = 3;
            buttonClient.Text = "Maintain Clients";
            buttonClient.UseVisualStyleBackColor = true;
            // 
            // buttonPayment
            // 
            buttonPayment.Location = new Point(120, 325);
            buttonPayment.Name = "buttonPayment";
            buttonPayment.Size = new Size(214, 66);
            buttonPayment.TabIndex = 4;
            buttonPayment.Text = "Recieve Payment";
            buttonPayment.UseVisualStyleBackColor = true;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(603, 170);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(214, 66);
            buttonOrder.TabIndex = 5;
            buttonOrder.Text = "Make a Rental Order";
            buttonOrder.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(603, 325);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(214, 66);
            buttonReturn.TabIndex = 6;
            buttonReturn.Text = "Return vehicle";
            buttonReturn.UseVisualStyleBackColor = true;
            // 
            // Assistant_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 170, 146);
            BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(942, 575);
            Controls.Add(buttonReturn);
            Controls.Add(buttonOrder);
            Controls.Add(buttonPayment);
            Controls.Add(buttonClient);
            Controls.Add(labelWelcome);
            Controls.Add(comboBoxUsers);
            Controls.Add(label1);
            Name = "Assistant_Menu";
            Text = "Assistant_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxUsers;
        private Label labelWelcome;
        private Button buttonClient;
        private Button buttonPayment;
        private Button buttonOrder;
        private Button buttonReturn;
    }
}