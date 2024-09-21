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



namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void BtnDersListele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=XY;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from TBLDERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnOgrListele_Click(object sender, EventArgs e)
        {
            DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            dataGridView1.Columns[3].Visible = false; //istemediğimiz sütunu böyle kapatabiliriz ama kullanışlı değil.
            dataGridView1.Columns[4].Visible = false;
        }

        private void BtnNotListele_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLNOTLAR select new { item.NOTID, item.OGRID, item.DERSID, item.SINAV1, item.SINAV2, item.SINAV3, item.ORTALAMA, item.DURUM };
            dataGridView1.DataSource = query.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI t = new TBLOGRENCI(); //TBLOGRENCI veri tabanındaki alanları görüp veri atayabilmek TBLOGRENCI class ından nesne oluşturduk
            t.AD = TxtAd.Text; // TBLOGRENCI sınıfı içerisindeki AD property sine değer atar
            t.SOYAD = TxtSoyad.Text;
            db.TBLOGRENCI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kayıt Eklenmiştir");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

            var x = db.TBLOGRENCI.Find(id);
            db.TBLOGRENCI.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

            var x = db.TBLOGRENCI.Find(id);
            x.AD = TxtAd.Text;
            x.SOYAD = TxtSoyad.Text;
            x.FOTOGRAF = TxtFoto.Text;
            db.SaveChanges();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void BtnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.Where(x => x.AD == TxtAd.Text | x.SOYAD == TxtSoyad.Text).ToList();
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdCont_TextChanged(object sender, EventArgs e)
        {
            string aranan = BtnAdCont.Text;
            var degerler = from x in db.TBLOGRENCI
                           where x.AD.Contains(aranan)
                           select x;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void BtnLinq_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                List<TBLOGRENCI> liste1 = db.TBLOGRENCI.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton2.Checked)
            {
                List<TBLOGRENCI> liste2 = db.TBLOGRENCI.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (radioButton3.Checked)
            {
                List<TBLOGRENCI> liste3 = db.TBLOGRENCI.OrderBy(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            if (radioButton4.Checked)
            {
                List<TBLOGRENCI> liste4 = db.TBLOGRENCI.Where(p => p.OGRID == 5).ToList();
                dataGridView1.DataSource = liste4;
            }
            if (radioButton5.Checked)
            {
                List<TBLOGRENCI> liste5 = db.TBLOGRENCI.Where(p => p.AD.StartsWith("A")).ToList();
                dataGridView1.DataSource = liste5;
            }
            if (radioButton6.Checked)
            {
                List<TBLOGRENCI> liste6 = db.TBLOGRENCI.Where(p => p.AD.EndsWith("e")).ToList();
                dataGridView1.DataSource = liste6;
            }
            if (radioButton7.Checked)
            {
                bool deger = db.TBLKLUPLER.Any();
                MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton8.Checked)
            {
                int ogrsayisi = db.TBLOGRENCI.Count();
                MessageBox.Show(ogrsayisi.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            if (radioButton9.Checked)
            {
                var enyuksek = db.TBLNOTLAR.Max(p => p.SINAV1).ToString();
                MessageBox.Show(enyuksek.ToString(), "Sınav 1 En Yüksek Not", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

            if (radioButton10.Checked)
            {
                var endusuk = db.TBLNOTLAR.Min(p => p.SINAV1).ToString();
                MessageBox.Show(endusuk.ToString(), "Sınav 1 En Düşük Not", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

            if (radioButton11.Checked)
            {
                var ortalama = db.TBLNOTLAR.Average(p => p.SINAV1);
                MessageBox.Show(ortalama.ToString(), "Sınav 1 ortalama", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

            if (radioButton12.Checked)
            {
                var ortalama = db.TBLNOTLAR.Average(p => p.SINAV1);
                List<TBLNOTLAR> liste11 = db.TBLNOTLAR.Where(p => p.SINAV2 > ortalama).ToList();
                dataGridView1.DataSource = liste11;
            }

        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBLNOTLAR
                        join d2 in db.TBLOGRENCI
                        on d1.OGRID equals d2.OGRID
                        join d3 in db.TBLDERSLER
                        on d1.DERSID equals d3.DERSID

                        select new
                        {
                            ÖĞRENCİ = d2.AD + " " + d2.SOYAD,
                            DERS = d3.DERSAD,
                            SINAV1 = d1.SINAV1,
                            SINAV2 = d1.SINAV2,
                            SINAV3 = d1.SINAV3,
                            ORTALAMA = d1.ORTALAMA
                        };
            dataGridView1.DataSource = sorgu.ToList();

        }
    }
}
