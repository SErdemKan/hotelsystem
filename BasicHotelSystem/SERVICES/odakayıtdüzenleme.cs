using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using rüvisotelnypprj.DAL;
using rüvisotelnypprj.DOMAIN;

namespace rüvisotelnypprj
{
    public partial class odakayıtdüzenleme : Form
    {
        public odakayıtdüzenleme()
        {
            InitializeComponent();
        }
        
       
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
       

        private void odakayıtdüzenleme_Load(object sender, EventArgs e)
        {
            
            build.UserID = "root";
            build.Server = "localhost";
            build.Database = "ybsdb";
            baglanti = new MySqlConnection(build.ToString());
            Listele_ara("select *from odavedurumu");
            Kisi_bilgileri("select *from kayıtkisibilgileri");
        }
        public DataTable Listele_ara(string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select *from odavedurumu", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
            return tbl;
            
        }
        public DataTable Kisi_bilgileri(string sql)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adaptr = new MySqlDataAdapter("select *from kayitkisibilgileri", baglanti);
            adaptr.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
            return table;
        }


        public void ESG(string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            ESG("insert into odavedurumu values('" + odanumarasıtxt.Text + "','" + odadurumutxt.Text + "','"+yataksayisitxt.Text+"','"+gunlukucrettxt.Text+"','"+kattxt.Text+"'");
            Listele_ara("select *from odavedurumu");
            MessageBox.Show("islem başarılı");
        }

        private void sil_Click(object sender, EventArgs e)
        {
            ESG("delete from odavedurumu where oda='" + dataGridView1.CurrentRow.Cells["oda"].Value.ToString() + "'");
            Listele_ara("select *from odavedurumu");
            MessageBox.Show("islem başarılı");
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            ESG("update odavedurumu set durumu= '" + odadurumutxt.Text + "',yataksayisi='" + yataksayisitxt.Text + "',günlükücret='" + gunlukucrettxt.Text+ "',kati='" + kattxt.Text+  "'where oda='" + odanumarasıtxt.Text + "'");
            Listele_ara("select *from odavedurumu");
            MessageBox.Show("islem başarılı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ESG("insert into kayitkisibilgileri values ('"+adsydtxt.Text+"','"+tckimliktxt.Text+"','"+adrestxt.Text+"','"+teltxt.Text+"','"+mailtxt.Text+"','"+odalarcombo.SelectedItem+"','"+tutartxt.Text+"','"+odemecombo.SelectedItem+ "','" + dateTimePicker1.Value + "','" + dateTimePicker1.Value + "')");
            Kisi_bilgileri("select *from kayitkisibilgileri");
            MessageBox.Show("İşlem Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ESG("delete from kayitkisibilgileri where adsoyad='" + dataGridView2.CurrentRow.Cells["adsoyad"].Value.ToString() + "'");
                Kisi_bilgileri("select *from kayitkisibilgileri");
                MessageBox.Show("islem başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen geçerli bir sütunu ya da veriyi seçin");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ESG("update kayitkisibilgileri set tckimlik= '" + tckimliktxt.Text + "',adres='" + adrestxt.Text + "',telefon='" + teltxt.Text + "',email='" + teltxt.Text + "',odalar='" + odalarcombo.SelectedItem + "',tutar='" + tutartxt.Text + "',odemeturu='" + odemecombo.SelectedItem + "',giristarihi='" + dateTimePicker1.Value + "',cikistarihi='" + dateTimePicker2.Value + "'where adsoyad='" + adsydtxt.Text + "'");
                Kisi_bilgileri("select *from kayitkisibilgileri");
                MessageBox.Show("islem başarılı");
               
            }
            catch
            {
                
                MessageBox.Show("Hata");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void odakayıtdüzenleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        { 

        }           
  
    }
}

