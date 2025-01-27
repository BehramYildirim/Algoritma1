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
    public partial class Girilen_sayının_istenilen_sayıya_göre_mod_işlemi : Form
    {
        public Girilen_sayının_istenilen_sayıya_göre_mod_işlemi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bölünen = Convert.ToInt32(textBox1.Text);
            double bölen = Convert.ToInt32(textBox2.Text);
             double modSonuc;
            if (bölünen >= bölen)
            {
                modSonuc = bölünen % bölen;
                label1.Text = "Sonuç = " + modSonuc;
            }
        }
    }
}
