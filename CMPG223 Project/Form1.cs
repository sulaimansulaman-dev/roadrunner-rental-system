using System.Diagnostics;

namespace CMPG223_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assistant_Menu assistant_Menu = new Assistant_Menu(this);
            assistant_Menu.Closed += (s, args) => this.Show();
            assistant_Menu.ShowDialog();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Menu admin_Menu = new Admin_Menu();
            admin_Menu.Closed += (s, args) => this.Show();
            admin_Menu.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path2 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Resources\\Help Functionality.pdf");
                var psi = new ProcessStartInfo(path2) { 
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
