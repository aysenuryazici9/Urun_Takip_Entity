using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Desktop
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        Db_Entity_UdemyEntities db=new Db_Entity_UdemyEntities();

        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategori.Count().ToString();
            label3.Text=db.Tbl_Urun.Count().ToString(); 
            label5.Text=db.Tbl_Musteri.Count(x=>x.Durum==true).ToString(); 
            label7.Text=db.Tbl_Musteri.Count(x=>x.Durum==false).ToString();
            label11.Text=db.Tbl_Urun.Sum(x=>x.Stok).ToString();
            label19.Text=db.Tbl_Satis.Sum(y=>y.Fiyat).ToString()+"₺";
            label13.Text=(from x in db.Tbl_Urun orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            label15.Text=(from x in db.Tbl_Urun orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            label9.Text = db.Tbl_Urun.Count(x => x.Kategori == 1).ToString();
            label23.Text= db.Tbl_Urun.Count(x => x.UrunAd=="Buzdolabı").ToString();
            label17.Text = (from x in db.Tbl_Musteri select x.Sehir).Distinct().Count().ToString();
            label21.Text = db.MARKAGETİR().FirstOrDefault();
        }
    }
}
