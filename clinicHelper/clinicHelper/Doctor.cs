using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicHelper
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btnTransformation_Click(object sender, EventArgs e)
        {
            frmTransformation T = new frmTransformation();
            T.Show();
            this.Hide();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            frmRecipe R = new frmRecipe();
            R.Show();
        }


    }
}
