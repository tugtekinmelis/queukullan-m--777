using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_kullanımı_777
{
    public partial class Form1 : Form
    {
        Queue<string> musteri = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Enqueue(txtAd.Text);
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (musteri.Count > 0)
            {
                lblAd.Text = musteri.Dequeue();
            }
            else
            {
                MessageBox.Show("işin çok hızlı bitti aferim :)");
            }
        }
    }
}
