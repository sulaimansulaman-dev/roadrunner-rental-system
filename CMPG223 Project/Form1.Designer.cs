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
            buttonAdmin.Location = new Point(101, 311);
            buttonAdmin.Margin = new Padding(3, 4, 3, 4);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(295, 111);
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
            buttonAssistant.Location = new Point(699, 311);
            buttonAssistant.Margin = new Padding(3, 4, 3, 4);
            buttonAssistant.Name = "buttonAssistant";
            buttonAssistant.Size = new Size(295, 109);
            buttonAssistant.TabIndex = 1;
            buttonAssistant.Text = "Assistant";
            buttonAssistant.UseVisualStyleBackColor = false;
            buttonAssistant.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Matura MT Script Capitals", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 15);
            label1.Name = "label1";
            label1.Size = new Size(630, 87);
            label1.TabIndex = 2;
            label1.Text = "RoadRunner Rentals";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(370, 676);
            label2.Name = "label2";
            label2.Size = new Size(373, 46);
            label2.TabIndex = 3;
            label2.Text = "Please choose your role";
            // 
            // button1
            // 
            button1.Location = new Point(14, 676);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 69);
            button1.TabIndex = 4;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(967, 676);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(121, 69);
            button2.TabIndex = 5;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 170, 146);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1102, 761);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAssistant);
            Controls.Add(buttonAdmin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
