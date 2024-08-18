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
            Assistant_Menu assistant_Menu = new Assistant_Menu();
            assistant_Menu.ShowDialog();
            this.Hide();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Admin_Menu admin_Menu = new Admin_Menu();
            admin_Menu.Show();
            this.Hide();
        }
    }
}
