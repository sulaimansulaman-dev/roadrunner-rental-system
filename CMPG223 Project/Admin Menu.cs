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

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentalOrder rentalOrder = new rentalOrder(this,1);
            rentalOrder.Closed += (s, args) => Application.Exit();
            rentalOrder.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

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
    }
}
