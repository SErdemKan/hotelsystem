using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rüvisotelnypprj.DAL
{
    class müsteriDAO
    {
        public void müsteriKaydet(string adsoyad,int tckimlik,string adres,int telefon,string email,int odalar,int tutar,string odemeturu,string giristarihi,string cikistarihi)
        {
            dbbaglanti.baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into kayitkisibilgileri(adsoyad,tckimlik,adres,telefon,email,odalar,tutar,odemeturu,giristarihi,cikistarihi)values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", dbbaglanti.baglanti);
            komut.Parameters.AddWithValue("@p2", adsoyad);
            komut.Parameters.AddWithValue("@p3", tckimlik);
            komut.Parameters.AddWithValue("@p4", telefon);
            komut.Parameters.AddWithValue("@p5", email);
            komut.Parameters.AddWithValue("@p6", odalar);
            komut.Parameters.AddWithValue("@p7", tutar);
            komut.Parameters.AddWithValue("@p8", odemeturu);
            komut.Parameters.AddWithValue("@p9", giristarihi);
            komut.Parameters.AddWithValue("@p10", cikistarihi);
            komut.ExecuteNonQuery();
            dbbaglanti.baglanti.Close();

        }
        public void müsteriGüncelle(string adsoyad,int tckimlik,string adres,int telefon,string email,int odalar,int tutar,string odemeturu,string giristarihi,string cikistarihi)
        {
            dbbaglanti.baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("update kayitkisibilgileri set adsoyad=@p1,tckimlik=@p2,adres=@p3,telefon=@p4,email=@p5,odalar=@p6,tutar=@p7,odemeturu=@p8,giristarihi=@p9,cikistarihi=@p10", dbbaglanti.baglanti);
            komut2.Parameters.AddWithValue("@p2", adsoyad);
            komut2.Parameters.AddWithValue("@p3", tckimlik);
            komut2.Parameters.AddWithValue("@p4", telefon);
            komut2.Parameters.AddWithValue("@p5", email);
            komut2.Parameters.AddWithValue("@p6", odalar);
            komut2.Parameters.AddWithValue("@p7", tutar);
            komut2.Parameters.AddWithValue("@p8", odemeturu);
            komut2.Parameters.AddWithValue("@p9", giristarihi);
            komut2.Parameters.AddWithValue("@p10", cikistarihi);
            komut2.ExecuteNonQuery();
            dbbaglanti.baglanti.Close();
        }
        public void müsteriSil(string adsoyad)
        {
            dbbaglanti.baglanti.Open();
            MySqlCommand komut3 = new MySqlCommand("delete from kayitkisibilgileri where adsoyad=@p1",dbbaglanti.baglanti);
            komut3.Parameters.AddWithValue("@p2", adsoyad);
            komut3.ExecuteNonQuery();
            dbbaglanti.baglanti.Close();

        }
    }
}
