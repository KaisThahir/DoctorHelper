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
    public partial class frmBackups : Form
    {
        public frmBackups()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmManager D = new frmManager();
            D.Show();
            this.Hide();
        }
    }
}
