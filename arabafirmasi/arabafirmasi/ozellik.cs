using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace arabafirmasi
{

  
    public partial class ozellik : Form
    {
        public ozellik()
        {
           
            InitializeComponent();
            
        }
      

        private void ozellik_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Tasit otomobil = new Tasit(); //Burada otomobil nesnesini oluşturduk..
          


            // nesnemize özellik değerlerini giriyoruz
            otomobil.hiz = Convert.ToInt32(txthiz.Text);
            otomobil.yakit = txtyakit.Text;
            otomobil.renk = txtrenk.Text;
            otomobil.marka = txtmarka.Text;
            otomobil.model = txtmodel.Text;



            // Bilgileri veritabanına yazdıracak metodu çağırıyoruz
            otomobil.tasitInfo();
          
        }

    }
    public class Tasit
    {

        public String yakit;// Taşıtın yakıt tipi
        public int hiz; // Taşıtın Maximum hızı 
        public String renk; // Taşıtın rengi
        public String marka; // Taşıtın markası
        public String model; // Taşıtın modeli

        // Taşıtın bilgilerini ekrana yazdıran metot
        public void tasitInfo()
        {
            
            SqlConnection con;
            SqlDataAdapter da;
            SqlCommand cmd;
            DataSet ds;
            con = new SqlConnection("server=.; Initial Catalog=car;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ozellik(yakit,hiz,renk,marka,model) values ('" + yakit + "'," + hiz + ",'" + renk + "','" + marka + "','" + model + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
