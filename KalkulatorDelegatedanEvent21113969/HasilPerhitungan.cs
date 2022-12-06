using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorDelegatedanEvent21113969
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Tampil(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', 'x', '/' };
            string[] operasi_str = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            listBox1.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}");
        }

        private void Btn_Hitung_Click(object sender, EventArgs e)
        {
            Kalkulator kalkulator = new Kalkulator();
            kalkulator.evhandler += Tampil; ;
            kalkulator.ShowDialog();
        }
    }
}
