using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ip_adresi_ogren
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry siteadi = Dns.GetHostEntry(textBox1.Text);
                IPAddress[] ip = siteadi.AddressList;
                textBox2.Text = ip[0].ToString();
                ListViewItem ekle = new ListViewItem();
                ekle.Text = textBox1.Text.ToString();
                ekle.SubItems.Add(textBox2.Text.ToString());
                listView1.Items.Add(ekle);
            }
            catch (Exception)
            {

                MessageBox.Show("Böyle Bir Site Bulunamadı");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
