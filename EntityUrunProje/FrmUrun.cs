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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void BTNLİSTE_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {
                                            x.UrunID,
                                            x.UrunAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FİYAT,
                                            x.Tbl_Kategori.AD,
                                            x.DURUM
                                        

                                        }).ToList();
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.UrunAD = TXTURUN.Text;
            t.MARKA = TXTMARKA.Text;
            t.STOK = short.Parse(TXTSTOK.Text);
            t.FİYAT = decimal.Parse(TXTFİYAT.Text);
            t.DURUM = true;
            t.KATEGORİ = int.Parse(CMBKATE.SelectedValue.ToString());
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Eklenmiştir");


        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTİD.Text);
            var urun = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("ürün silinmiştir.");
        }

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTİD.Text);
            var urun = db.Tbl_Urun.Find(x);
            urun.UrunAD = TXTURUN.Text;
            urun.MARKA = TXTMARKA.Text;
            urun.STOK = short.Parse(TXTSTOK.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün güncellenmiştir.");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori
                               select new
                               {
                                   x.ID,
                                   x.AD


                               }
        ).ToList();
            CMBKATE.ValueMember = "ID";
            CMBKATE.DisplayMember = "AD";
            CMBKATE.DataSource = kategoriler;

        }
    }
}
