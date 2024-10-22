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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] arrayAngka = new int[10];

            
            for (int i = 0; i < arrayAngka.Length; i++)
            {
                arrayAngka[i] = i;
            }

            label1.Text = "Isi Array: ";

            foreach (int angka in arrayAngka)
            {
                label1.Text += angka.ToString() + " ";
            }
        }
    }
}
