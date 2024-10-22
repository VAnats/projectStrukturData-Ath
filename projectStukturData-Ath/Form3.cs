using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectStukturData_Ath
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = 100;
            int b = 200;
            int hasilPenjumlahan = a + b;
            label1.Text = "Hasil Penjumlahan  : " + hasilPenjumlahan.ToString() ; // pake integer

            string hasilPenggabungan = a.ToString() + b.ToString();
            label2.Text = "Hasil Penggabungan : " + hasilPenggabungan ; // pake string
        }
    }
}
