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
            buttonClient = new Button();
            buttonOrder = new Button();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(428, 50);
            label1.TabIndex = 0;
            label1.Text = "Please select your profile";
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(409, 62);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(133, 23);
            comboBoxUsers.TabIndex = 1;
            comboBoxUsers.SelectionChangeCommitted += comboBoxUsers_SelectionChangeCommitted;
            // 
            // buttonClient
            // 
            buttonClient.Location = new Point(135, 244);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(214, 66);
            buttonClient.TabIndex = 3;
            buttonClient.Text = "Maintain Clients";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Visible = false;
            buttonClient.Click += buttonClient_Click;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(618, 244);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(214, 66);
            buttonOrder.TabIndex = 5;
            buttonOrder.Text = "Rental Orders";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Visible = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(391, 9);
            label2.Name = "label2";
            label2.Size = new Size(174, 50);
            label2.TabIndex = 6;
            label2.Text = "Welcome";
            label2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 507);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 7;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(846, 507);
            button2.Name = "button2";
            button2.Size = new Size(106, 52);
            button2.TabIndex = 11;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Assistant_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 170, 146);
            BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(964, 571);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(buttonOrder);
            Controls.Add(buttonClient);
            Controls.Add(comboBoxUsers);
            Controls.Add(label1);
            Name = "Assistant_Menu";
            Text = "Assistant_Menu";
            FormClosing += Assistant_Menu_FormClosing;
            Load += Assistant_Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxUsers;
        private Button buttonClient;
        private Button buttonOrder;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}