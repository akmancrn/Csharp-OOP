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
using System.Data.Sql;

namespace arabafirmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ozellik s1 = new ozellik();
        //    panel1.Visible = false;
        //    s1.Show();
          
        //}

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter da;
            SqlCommand cmd;
            DataSet ds;
            con = new SqlConnection("server=.; Initial Catalog=car;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from giris where kadi= '"+ textBox1.Text +"' AND sifre='"+textBox2.Text+"'";
            SqlDataReader oku = cmd.ExecuteReader();
            if(oku.Read()){
            ozellik s1 = new ozellik();
                s1.Show();          
            con.Close();
            }
            else{
                
       MessageBox.Show("Hatalı Giriş");}
            con.Close();
        }
    }
}
