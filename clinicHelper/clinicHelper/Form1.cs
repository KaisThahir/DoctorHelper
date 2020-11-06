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
    public partial class Form1 : Form
    {
     
        string userType = "";// dim userType as string =""
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MyClass info = new MyClass();
            if (!(textBoxUn.Text == "" && textBoxPw.Text == ""))
            {//للتاكد من عدم فراغ مربعين النص 
            //string connectionStr = "Data Source=KAIS1-PC;Initial Catalog=clinic;User ID=aa;Password=12345678 providerName=System.Data.SqlClient";
            SqlConnection con = new SqlConnection(info.connectionString);
            //string sqlStatment = "SELECT * FROM [clinic].[dbo].[users]";
            string sqlStatment = "SELECT * FROM [clinic].[dbo].[users]";
            SqlCommand cmd = new SqlCommand(sqlStatment, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                if (textBoxUn.Text == reader.GetString(3) && textBoxPw.Text == reader.GetString(4))
                {//للتاكد من وجود هذا الاسم وكلمة السر في قاعدة البيانات
                    userType = reader.GetString(5);
                   // info.userID = reader.GetInt64(0);


                }
            }
            con.Close();

            switch (userType)
            {
                case "Doctor":
                    Doctor dForm = new Doctor();
                    dForm.Show();
                    //this.Hide();
                    break;
                case "Reception":
                    Reception rForm = new Reception();
                    rForm.Show();
                    //this.Hide();
                    break;
                case "Lab":
                    Lab lForm = new Lab();
                    lForm.Show();
                    //this.Hide();
                    break;
                case "Pharmacy":
                    Pharmacy pForm = new Pharmacy();
                    pForm.Show();
                    //this.Hide();
                    break;
            }
           

            
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
