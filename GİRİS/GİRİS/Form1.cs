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

namespace GİRİS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-R5EUA3L;Initial Catalog=kullanıcıgirisi;Integrated Security=True");
        private void ad_Click(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici where ad ='" + adt.Text + "'and sifre='" + sifret.Text + "'", bağlanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                PROFİL.user btngrs = new PROFİL.user();
                btngrs.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hatalı giriş");
                adt.Clear();
                sifret.Clear();
            }
            bağlanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HAKKIMIZDA.Form5 btn = new HAKKIMIZDA.Form5();
            Hide();
            btn.Show();
        }

        private void adt_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SİPARİŞBİLGİ.Form3 btngrs = new SİPARİŞBİLGİ.Form3();
            btngrs.Show();
            this.Hide();
        }

        private void kayıt_Click(object sender, EventArgs e)
        {
            KAYITOL.kayıt kyt = new KAYITOL.kayıt();
            kyt.Show();
            this.Hide();
        }
    }
}
