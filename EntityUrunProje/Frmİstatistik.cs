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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategori.Count().ToString();
            label3.Text = db.Tbl_Urun.Count().ToString();
            label5.Text = db.Tbl_Müsteri.Count(x=>x.Durum==true).ToString();
            label7.Text = db.Tbl_Müsteri.Count(x => x.Durum == false).ToString();
            label13.Text = db.Tbl_Urun.Sum(x => x.STOK).ToString();
            label21.Text = db.Tbl_satis.Sum(x => x.Fiyat).ToString()+" TL";
            label11.Text = (from x in db.Tbl_Urun orderby x.FİYAT descending select x.UrunAD).FirstOrDefault();
            label9.Text = (from x in db.Tbl_Urun orderby x.FİYAT ascending select x.UrunAD).FirstOrDefault();
            label15.Text = db.Tbl_Urun.Count(x => x.KATEGORİ == 3).ToString();
            label17.Text = db.Tbl_Urun.Count(x => x.UrunAD == "Buzdolabı").ToString();
            label23.Text = (from x in db.Tbl_Müsteri select x.Sehir).Distinct().Count().ToString();
            label19.Text = db.MARKAGETIR().FirstOrDefault();
       
        }
    }
}
