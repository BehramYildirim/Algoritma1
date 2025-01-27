using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma
{
    public partial class Girilen_sayının_kaç_basamaklı_olduğunu_söyleyen_program : Form
    {
        public Girilen_sayının_kaç_basamaklı_olduğunu_söyleyen_program()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int sayaç = 1;
            sayi = Convert.ToInt32(textBox1.Text);
            while (sayi>9)
            { 
                sayi = sayi / 10;
                sayaç++;
                label1.Text = "Girilen sayı " + sayaç + " basamaklıdır.";
            }
        }
    }
}
