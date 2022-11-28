using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KitaplarEntityCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KitapContext db = new KitapContext();
        int btn = 0;
        int yID;
        int tID;
        void yazarListele()
        {
            var yazarlist = (from y in db.Yazars
                             select new
                             {
                                 y.Id,
                                 y.YazarAdi,
                                 y.YazarSoyadi
                             }).ToList();
            dataGrid.DataSource = yazarlist;
        }
        void kitapListele()
        {
            var kitaplist = (from k in db.Kitaps
                             select new
                             {
                                 k.Id,
                                 k.KitapAdi,
                                 k.Tur.TurAd,
                                 k.SayfaSayisi,
                                 k.BasimYili,
                                 k.Yazar.YazarAdi,
                                 k.Yazar.YazarSoyadi
                             }).ToList();
            dataGrid.DataSource = kitaplist;
        }
        void turListele()
        {
            var turliste = (from t in db.KitapTurs
                            select new
                            {
                                t.Id,
                                t.TurAd
                            }).ToList(); 
            dataGrid.DataSource = turliste;
        }
        void comboBoxYazar()
        {
            var yazarlist = (from y in db.Yazars
                             select new
                             {
                                 y.Id,
                                 y.YazarAdi,
                                 y.YazarSoyadi
                             }).ToList();
            foreach (var item in yazarlist)
            {
                cbyazar.Items.Add(item.YazarAdi+" "+item.YazarSoyadi);
            }
        }
        void comboBoxTur()
        {
            var turlist = (from t in db.KitapTurs
                           select new
                           {
                               t.Id,
                               t.TurAd
                           }).ToList();
            foreach (var item in turlist)
            {
                cbtur.Items.Add(item.TurAd);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxYazar();
            comboBoxTur();
        }
        private void btnlistelekitap_Click(object sender, EventArgs e)
        {
            kitapListele();
            btn = 2;
            lblsecim.Text = groupBox1.Text;
        }
        private void btnlisteletur_Click(object sender, EventArgs e)
        {
            turListele();
            btn = 3;
            lblsecim.Text = groupBox3.Text;
        }
        private void btnlisteleyazar_Click(object sender, EventArgs e)
        {
            yazarListele();
            btn = 1;
            lblsecim.Text = groupBox2.Text;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Yazars)
            {
                string adsoyad = item.YazarAdi+" "+item.YazarSoyadi;
                if (adsoyad == cbyazar.Text)
                {
                    yID = item.Id;
                }
            }
            foreach (var item in db.KitapTurs)
            {
                if (item.TurAd == cbtur.Text)
                {
                    tID = item.Id;
                }
            }
            switch (btn)
            {
                case 1:
                    Yazar yazar = new Yazar();
                    yazar.YazarAdi = txtyazarad.Text;
                    yazar.YazarSoyadi = txtyazarsoyad.Text;
                    db.Yazars.Add(yazar);
                    db.SaveChanges();
                    MessageBox.Show("Ekleme Başarılı");
                    yazarListele();
                    break;
                case 2:
                    Kitap kitap = new Kitap();
                    kitap.KitapAdi = txtkitapad.Text;
                    kitap.BasimYili = mtxtbyili.Text;
                    kitap.SayfaSayisi = int.Parse(txtsayfasayisi.Text);
                    kitap.YazarId = yID;
                    kitap.TurId = tID;
                    db.Kitaps.Add(kitap);
                    db.SaveChanges();
                    MessageBox.Show("Ekleme Başarılı");
                    kitapListele();
                    break;
                case 3:
                    KitapTur kitapTur = new KitapTur();
                    kitapTur.TurAd = txtturad.Text;
                    db.KitapTurs.Add(kitapTur);
                    db.SaveChanges();
                    MessageBox.Show("Ekleme Başarılı");
                    turListele();
                    break;
            }
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            switch (btn)
            {
                case 1:
                    int yazarid = Convert.ToInt32(txtyazarid.Text);
                    var yazarsil = db.Yazars.Find(yazarid);
                    db.Yazars.Remove(yazarsil);
                    db.SaveChanges();
                    MessageBox.Show("Silme Başarılı");
                    yazarListele();
                    break;
                case 2:
                    int kitapid = Convert.ToInt32(txtid.Text);
                    var kitapsil = db.Kitaps.Find(kitapid);
                    db.Kitaps.Remove(kitapsil);
                    db.SaveChanges();
                    MessageBox.Show("Silme Başarılı");
                    kitapListele();
                    break;
                case 3:
                    int turid = Convert.ToInt32(txtturid.Text);
                    var tursil = db.Kitaps.Find(turid);
                    db.Kitaps.Remove(tursil);
                    db.SaveChanges();
                    MessageBox.Show("Silme Başarılı");
                    turListele();
                    break;
            }
        }
        void tekSorguCekmeKitap(int girilenid)
        {
            var teklist = (from k in db.Kitaps
                           where k.Id == girilenid
                           select k);
            dataGrid.DataSource=teklist.ToList();      
        }
        void tekSorguCekmeYazar(int girilenid)
        {
            var teklist = (from k in db.Yazars
                           where k.Id == girilenid
                           select k);
            dataGrid.DataSource=teklist.ToList();
        }
        void tekSorguCekmeTur(int girilenid)
        {
            var teklist = (from k in db.KitapTurs
                           where k.Id == girilenid
                           select k);
            dataGrid.DataSource=teklist.ToList();
        }
        private void btnara_Click(object sender, EventArgs e)
        {
            switch (btn)
            {
                case 1:
                    tekSorguCekmeYazar(int.Parse(txtyazarid.Text));
                    MessageBox.Show("Kayıt Bulundu");
                    break;
                case 2:
                    tekSorguCekmeKitap(int.Parse(txtid.Text));
                    MessageBox.Show("Kayıt Bulundu");
                    break;
                case 3:
                    tekSorguCekmeTur(int.Parse(txtturid.Text));
                    MessageBox.Show("Kayıt Bulundu");
                    break;
            }
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Yazars)
            {
                string adsoyad = item.YazarAdi+" "+item.YazarSoyadi;
                if (adsoyad == cbyazar.Text)
                {
                    yID = item.Id;
                }
            }
            foreach (var item in db.KitapTurs)
            {
                if (item.TurAd == cbtur.Text)
                {
                    tID = item.Id;
                }
            }
            switch (btn)
            {
                case 1:
                    int yazarid = Convert.ToInt32(txtyazarid.Text);
                    var yazarguncelle = db.Yazars.Find(yazarid);
                    yazarguncelle.YazarAdi = txtyazarad.Text;
                    yazarguncelle.YazarSoyadi = txtyazarsoyad.Text;
                    db.SaveChanges();
                    MessageBox.Show("Güncelleme Başarılı");
                    yazarListele();
                    break;
                case 2:
                    int kitapid = Convert.ToInt32(txtyazarid.Text);
                    var kitapguncelle = db.Kitaps.Find(kitapid);
                    kitapguncelle.KitapAdi = txtkitapad.Text;
                    kitapguncelle.BasimYili = mtxtbyili.Text;
                    kitapguncelle.SayfaSayisi = int.Parse(txtsayfasayisi.Text);
                    kitapguncelle.YazarId = yID;
                    kitapguncelle.TurId = tID;
                    db.SaveChanges();
                    MessageBox.Show("Güncelleme Başarılı");
                    kitapListele();
                    break;
                case 3:
                    int turid = Convert.ToInt32(txtturid.Text);
                    var turguncelle = db.KitapTurs.Find(turid);
                    turguncelle.TurAd = txtturad.Text;
                    db.SaveChanges();
                    MessageBox.Show("Güncelleme Başarılı");
                    turListele();
                    break;
            }
        }
        private void btnyenile_Click(object sender, EventArgs e)
        {
            cbyazar.Items.Clear();
            cbtur.Items.Clear();
            Form1_Load(sender, e);
        }
        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGrid.SelectedCells[0].RowIndex;
            int hücre1 = int.Parse(dataGrid.Rows[secim].Cells[0].Value.ToString());
            string hücre2 = dataGrid.Rows[secim].Cells[1].Value.ToString();
            switch (btn)
            {
                case 1:
                    string hücre3 = dataGrid.Rows[secim].Cells[2].Value.ToString();
                    txtyazarid.Text = hücre1.ToString();
                    txtyazarad.Text = hücre2;
                    txtyazarsoyad.Text = hücre3;
                    break;
                case 2:
                    string hücre = dataGrid.Rows[secim].Cells[2].Value.ToString();
                    string hücre4 = dataGrid.Rows[secim].Cells[3].Value.ToString();
                    string hücre5 = dataGrid.Rows[secim].Cells[4].Value.ToString();
                    string hücre6 = dataGrid.Rows[secim].Cells[5].Value.ToString();
                    txtid.Text = hücre1.ToString();
                    txtkitapad.Text = hücre2;
                    txtsayfasayisi.Text = hücre4.ToString();
                    mtxtbyili.Text = hücre5;
                    cbyazar.Text = hücre6;
                    cbtur.Text = hücre;
                    break;
                case 3:
                    txtturid.Text = hücre1.ToString();
                    txtturad.Text = hücre2;
                    break;
            }
        }
    }
}
