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
    public partial class frmTransformation : Form
    {
        public frmTransformation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Doctor P = new Doctor();
            P.Show();
            this.Close();
        }
    }
}
