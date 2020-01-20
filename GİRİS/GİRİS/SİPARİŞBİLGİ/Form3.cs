using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GİRİS.SİPARİŞBİLGİ
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSepetekle_Click(object sender, EventArgs e)
        {

            SEPETEEKLE.Form4 btngrs = new SEPETEEKLE.Form4();
      
            btngrs.Show();
           
            if (checkBox2.Checked == true)
            {
                btngrs.goster(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                btngrs.goster(checkBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                btngrs.goster(checkBox4.Text);
            }
            if (checkBox5.Checked == true)
            {
                btngrs.goster(checkBox5.Text);
            }
            if (checkBox6.Checked == true)
            {
                btngrs.goster(checkBox6.Text);
            }
            if (checkBox7.Checked == true)
            {
                btngrs.goster(checkBox7.Text);
            }
            if (checkBox8.Checked == true)
            {
                btngrs.goster(checkBox8.Text);
            }
            if (checkBox9.Checked == true)
            {
                btngrs.goster(checkBox9.Text);
            }

            if (checkBox9.Checked == true)
            {
                btngrs.goster(checkBox9.Text);
            }

            if(incek.Checked==true)
            {
                btngrs.goster(incek.Text);
            }
            if (kalınk.Checked == true)
            {
                btngrs.goster(kalınk.Text);
            }
            if (sucukk.Checked == true)
            {
                btngrs.goster(sucukk.Text);
            }
            if (mozk.Checked == true)
            {
                btngrs.goster(mozk.Text);
            }

            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }
     

      

        private void txtTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pizzalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boyut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mozk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sosisk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sucukk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kalınk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void incek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adl_Click(object sender, EventArgs e)
        {

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
         


            decimal tutanfiyat = 0;
            
            

            if (pizzalar.Text == "Sucuksever")
            {
                tutanfiyat = tutanfiyat + 10;
            }
            if (pizzalar.Text == "Italiano")
            {
                tutanfiyat = tutanfiyat + 5;
            }
            if (pizzalar.Text == "Karışık")
            {
                tutanfiyat = tutanfiyat + 15;
            }
            if (pizzalar.Text == "Kayseri Ateşi")
            {
                tutanfiyat = tutanfiyat + 20;
            }



            if (boyut.Text == "KÜÇÜK")
            {
                tutanfiyat = tutanfiyat*2;
            }
            if (boyut.Text == "ORTA")
            {
                tutanfiyat = tutanfiyat*3;
            }
            if (boyut.Text == "BÜYÜK")
            {
                tutanfiyat = tutanfiyat*4;
            }
            if (boyut.Text == "EXTRA LARGE")
            {
                tutanfiyat = tutanfiyat*5;
            }



            if(incek.Text=="İnce Kenar")
            {
                tutanfiyat = tutanfiyat + 5;
            }
            if (incek.Text == "Kalın Kenar")
            {
                tutanfiyat = tutanfiyat + 8;
            }
            if (incek.Text == "Sucuk Kenar")
            {
                tutanfiyat = tutanfiyat + 10;
            }
            if (incek.Text == "Sosis Kenar")
            {
                tutanfiyat = tutanfiyat + 10;
            }
            if (incek.Text == "Mozarella Kenar")
            {
                tutanfiyat = tutanfiyat + 10;
            }



            if (checkBox2.Text == "Sosis")
            {
                tutanfiyat = tutanfiyat + 5;
            }

            if (checkBox3.Text == "Mısır")
            {
                tutanfiyat = tutanfiyat + 5;
            }
           if (checkBox4.Text == "Susam")
            {
                tutanfiyat = tutanfiyat + 5;
            }
             if (checkBox5.Text == "Zeytin")
            {
                tutanfiyat = tutanfiyat + 5;
            }

             if (checkBox6.Text == "Salam")
            {
                tutanfiyat = tutanfiyat + 5;
            }
            if (checkBox7.Text == "Sucuk")
            {
                tutanfiyat = tutanfiyat + 5;
            }
            if (checkBox8.Text == "Mantar")
            {
                tutanfiyat = tutanfiyat + 5;
            }
             if (checkBox9.Text == "Peynir")
            {
                tutanfiyat = tutanfiyat + 5;
            }
           tutanfiyat = adet.Value * tutanfiyat;


           tutar.Text = tutanfiyat.ToString();
        }
       
    }
}
