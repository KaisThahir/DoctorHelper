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
    public partial class FrmRevenuesExpenses : Form
    {
        public FrmRevenuesExpenses()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Doctor D = new Doctor();
            D.Show();
            this.Hide();
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            Doctor D = new Doctor();
            D.Show();
            this.Hide();
        }
    }
}
