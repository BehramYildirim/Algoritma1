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
    public partial class _1_den_100_kadar_olan_sayıların_küplerinin_toplamı : Form
    {
        public _1_den_100_kadar_olan_sayıların_küplerinin_toplamı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int küpToplam = 0;
            for (int i = 1; i < 101; i++)
            {   
                küpToplam += (i * i * i);
                label1.Text = "1-100 arası sayıların küplerin toplamı="+küpToplam;
            }
        }
    }
}
