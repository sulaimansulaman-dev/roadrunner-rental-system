namespace CMPG223_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAdmin = new Button();
            buttonAssistant = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.LightSteelBlue;
            buttonAdmin.FlatAppearance.BorderColor = Color.Black;
            buttonAdmin.FlatStyle = FlatStyle.Popup;
            buttonAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdmin.Location = new Point(88, 233);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(258, 83);
            buttonAdmin.TabIndex = 0;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // buttonAssistant
            // 
            buttonAssistant.BackColor = Color.FromArgb(68, 138, 163);
            buttonAssistant.FlatStyle = FlatStyle.Popup;
            buttonAssistant.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAssistant.Location = new Point(612, 233);
            buttonAssistant.Name = "buttonAssistant";
            buttonAssistant.Size = new Size(258, 82);
            buttonAssistant.TabIndex = 1;
            buttonAssistant.Text = "Assistant";
            buttonAssistant.UseVisualStyleBackColor = false;
            buttonAssistant.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Matura MT Script Capitals", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 11);
            label1.Name = "label1";
            label1.Size = new Size(551, 65);
            label1.TabIndex = 2;
            label1.Text = "RoadRunner Rentals";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(324, 507);
            label2.Name = "label2";
            label2.Size = new Size(296, 37);
            label2.TabIndex = 3;
            label2.Text = "Please choose your role";
            // 
            // button1
            // 
            button1.Location = new Point(12, 507);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 4;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(846, 507);
            button2.Name = "button2";
            button2.Size = new Size(106, 52);
            button2.TabIndex = 5;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 170, 146);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(964, 571);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAssistant);
            Controls.Add(buttonAdmin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdmin;
        private Button buttonAssistant;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
