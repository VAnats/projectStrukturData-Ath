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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tanggal = textBox1.Text;
            string bulan = textBox2.Text;
            string tahun = textBox3.Text;
            string hasil = $"{tanggal.PadLeft(2, '0')}-{bulan.PadLeft(2, '0')}-{tahun}";
            MessageBox.Show("Data yang Anda Masukkan: " + hasil, "Hasil Input", MessageBoxButtons.OK);
        }
    }
}
