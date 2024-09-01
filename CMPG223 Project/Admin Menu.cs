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
            frmClients ClientsFrm = new frmClients();
            ClientsFrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVehicleClasses frmVehicleClasses = new frmVehicleClasses();
            frmVehicleClasses.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmVehicles frmVehicles = new frmVehicles(); 
            frmVehicles.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            rentalOrder rentalOrder = new rentalOrder(this);
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
            frmRequestReports RequestReportsfrm = new frmRequestReports(); 
            RequestReportsfrm.ShowDialog();
        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
