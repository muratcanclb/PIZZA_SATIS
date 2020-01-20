using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GİRİS.HAKKIMIZDA
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void HAK_Click(object sender, EventArgs e)
        {

        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Hide();
            pictureBox3.Hide();
            pictureBox2.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox2.Hide();
            label1.Hide();
            label2.Show();
          
        }

        private void giris_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            Hide();
            ana.Show();

        }
    }
}
