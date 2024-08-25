using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
