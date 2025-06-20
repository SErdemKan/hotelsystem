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
    public partial class Odalarvekayit : Form
    {
        public Odalarvekayit()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        public void odadurumu()
        {
            foreach (Control btn in Controls)
            {
                if (btn is Button)
                {
                    if (btn.Name!="button22"&&btn.Name!="button23")
                    {
                        btn.BackColor = Color.Pink;
                    }
                }
            }
            baglanti.Open();
            MySqlCommand kmt = new MySqlCommand("select *from odavedurumu",baglanti);
            MySqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                foreach (Control oda in Controls)
                {
                    if (oda is Button)
                    {
                        if (oku["oda"].ToString() == oda.Text && oku["durumu"].ToString() == "BOŞ")
                        {
                            oda.BackColor = Color.Green;
                            odalarcmbbx.Items.Add(oku["oda"].ToString());
                        }
                        if (oku["oda"].ToString() == oda.Text && oku["durumu"].ToString() == "DOLU")
                        {
                            oda.BackColor = Color.Red;
                            
                        }

                    }
                }
            }
            baglanti.Close();
        }
        public DataTable dbkaydet(string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select *from kayitkisibilgileri", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
            return tbl;
           

        }
        public void KYDT(string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }         

        
        private void Odalarvekayit_Load(object sender, EventArgs e)
        {
            build.UserID = "root";
            build.Server = "localhost";
            build.Database = "ybsdb";
            baglanti = new MySqlConnection(build.ToString());
            dbkaydet("select *from odavedurumu");
            odadurumu();
            foreach (Control cikmabutonu in Controls)
            {
                if (cikmabutonu is Button)
                {
                    if (cikmabutonu.BackColor == Color.Red)
                    {
                        cikmabutonu.Click += Cikmabutonu_Click;
                    }
                }
            }
        }
        
        private void Cikmabutonu_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor==Color.Red)
            {
                DialogResult cikis = MessageBox.Show("Emin misiniz?", "Oda boşaltılsın mı?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (cikis==DialogResult.Yes)
                {
                      
                        baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("delete from kayitkisibilgileri where odalar='" + Convert.ToInt32(b.Text) + "'", baglanti);
                        komut.ExecuteNonQuery();
                        MySqlCommand kmt = new MySqlCommand("update odavedurumu set durumu='BOŞ' where oda='"+Convert.ToInt32(b.Text)+"'", baglanti);
                        kmt.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Oda Boşaltıldı");
                    
                    
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            odakayıtdüzenleme okd = new odakayıtdüzenleme();
            okd.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void button15_Click(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
        }

        private void button18_Click(object sender, EventArgs e)
        {
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

            KYDT("insert into kayitkisibilgileri values ('" +adsydtxt.Text+ "','" + tckmlktxt.Text + "','" + adrstxt.Text + "','" + tlfntxt.Text+ "','" + mailtxt.Text + "','" + odalarcmbbx.Text + "','" + tutartxt.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "')");
            dbkaydet("select *from kayitkisibilgileri");
            baglanti.Open();
            MySqlCommand kmt = new MySqlCommand("update odavedurumu set durumu='DOLU' where oda='"+odalarcmbbx.SelectedItem+"'",baglanti);
            kmt.ExecuteNonQuery();
            MessageBox.Show("İşlem Başarılı");
            baglanti.Close();
            odalarcmbbx.Items.Clear();
            odadurumu();
            
           
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void odalarcmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select *from odavedurumu where oda='" + odalarcmbbx.SelectedItem + "'", baglanti);
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["günlükücret"].ToString();
                }
                baglanti.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan gün = new TimeSpan();
            gün = DateTime.Parse(dateTimePicker2.Text) - DateTime.Parse(dateTimePicker1.Text);
            textBox2.Text = gün.TotalDays.ToString();
            tutartxt.Text = (double.Parse(textBox2.Text) * double.Parse(textBox1.Text)).ToString();
        }

        private void Odalarvekayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tutartxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tlfntxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void adrstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tckmlktxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void adsydtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
