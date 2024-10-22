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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double panjang = Convert.ToDouble(textBox1.Text);
                double lebar = Convert.ToDouble(textBox2.Text);
                double luas = panjang * lebar;

                if (luas > 100)
                {
                    MessageBox.Show("Luas: " + luas.ToString() + " - Besar", "Di atas 100 Maka", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Luas: " + luas.ToString() + " - Kecil", "Di bawah 100 Maka", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input tidak valid: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
