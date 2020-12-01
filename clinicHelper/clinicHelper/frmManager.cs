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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnRevenuesExpenses_Click(object sender, EventArgs e)
        {
            FrmRevenuesExpenses R = new FrmRevenuesExpenses();
            R.Show();
            this.Hide();
        }

        private void btnClinicStaff_Click(object sender, EventArgs e)
        {
            FrmClinicStaff C = new FrmClinicStaff();
            C.Show();
            this.Hide();
        }

        private void btnBackups_Click(object sender, EventArgs e)
        {
            frmBackups B = new frmBackups();
            B.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
