using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clinicHelper
{
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
        }

        private void search_Click_1(object sender, EventArgs e)
        {
     MyClass info = new MyClass();
            SqlConnection con = new SqlConnection(info.connectionString);
            string sqlStatment = "SELECT * FROM [clinic].[dbo].[patients]";
            SqlCommand cmd = new SqlCommand(sqlStatment, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if  (textBox1.Text == reader.GetString(1))
                {

                    MessageBox.Show("yes");

                }

                con.Close();
            }
        }

      

        private void back_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("yes");
            Form f = new Form();
            f.Show();
            this.Close();
           
        }

      

     
    }
}
