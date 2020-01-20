using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GİRİS.ULASIMBİLGİ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SİPARİŞİNİZ ONAYLANDI BİZİ SEÇTİĞİNİZ İÇİN TEŞEKKÜR EDERİZ :)");
            this.Close();
            Application.Exit();
        }

        private void iptalb_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            SEPETEEKLE.Form4 btnGERİ = new SEPETEEKLE.Form4();
            btnGERİ.Show();
            this.Hide();
        }
    }
}
