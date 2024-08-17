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
            assistant_Menu.Show();
            this.Hide();
        }
    }
}
