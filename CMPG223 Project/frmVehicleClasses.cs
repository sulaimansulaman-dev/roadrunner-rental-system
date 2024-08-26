namespace CMPG223_Project
{
    public partial class frmVehicleClasses : Form
    {
        Form form;
        public frmVehicleClasses(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void frmVehicleClasses_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
