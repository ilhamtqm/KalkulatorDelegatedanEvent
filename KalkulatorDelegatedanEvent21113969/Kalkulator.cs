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
    public partial class Kalkulator : Form
    {
        //delegate event
        public delegate void EventHandler(int operation, int a, int b, int hasil);
        public event EventHandler evhandler;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void btn_Proses_Click(object sender, EventArgs e)
        {
            string operation = comboBox1.SelectedItem.ToString();
            int a = Convert.ToInt32(txtNilaiA.Text);
            int b = Convert.ToInt32(txtNilaiB.Text);
            int hasil = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    break;
                case 1:
                    hasil = a - b;
                    break;
                case 2:
                    hasil = a * b;
                    break;
                case 3:
                    hasil = a / b;
                    break;
                default:
                    hasil = 0;
                    break;
            }
            this.evhandler(comboBox1.SelectedIndex, a, b, hasil);
        }
    }
}
