namespace CMPG223_Project
{
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClients frmClients = new frmClients();
            frmClients.Closed += (s, args) => this.Show();
            frmClients.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVehicleClasses frmVehicleClasses = new frmVehicleClasses();
            frmVehicleClasses.Closed += (s, args) => this.Show();
            frmVehicleClasses.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVehicles frmVehicles = new frmVehicles();
            frmVehicles.Closed += (s, args) => this.Show();
            frmVehicles.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsers frmUsers = new frmUsers();
            frmUsers.Closed += (s, args) => this.Show();
            frmUsers.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentalOrder rentalOrder = new rentalOrder(this, 1);
            rentalOrder.Closed += (s, args) => this.Show();
            rentalOrder.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRequestReports RequestReportsfrm = new frmRequestReports();
            RequestReportsfrm.Closed += (s, args) => this.Show();
            RequestReportsfrm.ShowDialog();
        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
