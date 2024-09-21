using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var degerler = db.TBLNOTLAR.Where(x => x.SINAV1 < 50);
                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton2.Checked == true)
            {
                var degerler = db.TBLOGRENCI.Where(x => x.AD == "ibrahim");
                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton3.Checked == true)
            {
                var degerler = db.TBLOGRENCI.Where(x => x.AD == textBox1.Text || x.SOYAD == textBox1.Text);
                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton4.Checked == true)
            {
                var degerler = db.TBLOGRENCI.Select(x => new { Soyadı = x.SOYAD });
                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton5.Checked == true)
            {
                var degerler = db.TBLOGRENCI.Select(x => new
                {
                    Adı = x.AD.ToUpper(),
                    SoyAdı = x.SOYAD.ToLower()
                });

                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton6.Checked == true)
            {
                var degerler = db.TBLOGRENCI.Select(x => new
                {
                    Adı = x.AD.ToUpper(),
                    SoyAdı = x.SOYAD.ToLower()
                }).Where(x =>x.Adı != "ibrahim");

                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton7.Checked == true)
            {
                var degerler = db.TBLNOTLAR.Select(x => new
                {
                    OgrenciAd = x.OGRID,
                    Ortalaması = x.ORTALAMA,
                Durumu= x.DURUM == true ? "Geçti" : "Kaldı"
                });

                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton8.Checked == true)
            {
                var degerler = db.TBLNOTLAR.SelectMany(x => db.TBLOGRENCI.Where(y => y.OGRID == x.OGRID), (x, y) => new
                {
                    y.AD,
                    y.SOYAD,
                    x.ORTALAMA,
                    DURUMU =x.DURUM == true ? "Geçti" : "Kaldı"
                });

                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton9.Checked == true)
            {
                var degerler = db.TBLOGRENCI.OrderBy(x => x.OGRID).Take(3);

                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton10.Checked == true)
            {
                var degerler = db.TBLOGRENCI.OrderByDescending(x => x.OGRID).Take(3);

                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton11.Checked == true)
            {
                var degerler = db.TBLOGRENCI.OrderBy(x => x.AD);

                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton12.Checked == true)
            {
                var degerler = db.TBLOGRENCI.OrderBy(x => x.OGRID).Skip(3);

                dataGridView1.DataSource = degerler.ToList();
            }


            if (radioButton13.Checked == true)
            {
                var degerler = db.TBLOGRENCI.OrderBy(x => x.SEHIR).GroupBy(y=>y.SEHIR).Select(z=> new { 
                    Şehir = z.Key, 
                    Toplam =z.Count()
                });

                dataGridView1.DataSource = degerler.ToList();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
