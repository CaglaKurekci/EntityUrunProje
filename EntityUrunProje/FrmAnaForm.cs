using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUrunProje
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrun f1 = new FrmUrun();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmİstatistik f2 = new Frmİstatistik();
            f2.Show();
        }
    }
}
