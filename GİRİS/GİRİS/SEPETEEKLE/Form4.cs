using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GİRİS.SEPETEEKLE
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void adetlab_Click(object sender, EventArgs e)
        {

        }

        private void siparişonay_Click(object sender, EventArgs e)
        {
            ULASIMBİLGİ.Form2 btnonay = new ULASIMBİLGİ.Form2();
            btnonay.Show();
            this.Hide();
        }

        private void sepeteekle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSepetekle_Click(object sender, EventArgs e)
        {
            ULASIMBİLGİ.Form2 btnOnayla = new ULASIMBİLGİ.Form2();
            btnOnayla.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            SİPARİŞBİLGİ.Form3 btnOnayla = new SİPARİŞBİLGİ.Form3();
            btnGeri.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        public void goster(string x)
        {
            listBox1.Items.Add(x);

        }
    }
}
