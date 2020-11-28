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
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            frmRecipe R = new frmRecipe();
            R.Show();
        }

        private void btnTransformation_Click(object sender, EventArgs e)
        {
            frmTransformation T = new frmTransformation();
            T.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Doctor D = new Doctor();
            D.Show();
            this.Hide();
        }
    }
}
