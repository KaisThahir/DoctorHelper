using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clinicHelper
{
    public partial class FrmClinicStaff : Form
    {
        public FrmClinicStaff()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmManager D = new frmManager();
            D.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure to delete", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
