using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rüvisotelnypprj.DAL
{
    class odaDAO
    {
        public void odaKaydet(int odaNumarası,string odaDurumu,int yatakSayisi,int günlükücret,int kati)
        {
            
            dbbaglanti.baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into odavedurumu(oda,durumu,yataksayisi,günlükücret,kati)values(@p1,@p2,@p3,@p4,@p5)", dbbaglanti.baglanti);
            komut.Parameters.AddWithValue("@p1", odaNumarası);
            komut.Parameters.AddWithValue("@p2", odaDurumu);
            komut.Parameters.AddWithValue("@p3", yatakSayisi);
            komut.Parameters.AddWithValue("@p4", günlükücret);
            komut.Parameters.AddWithValue("@p5", kati);
            komut.ExecuteNonQuery();
            dbbaglanti.baglanti.Close();

        }
        public void odaSil(int odaNumarası)
        {
            dbbaglanti.baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("delete from odevedurumu where oda=@p1", dbbaglanti.baglanti);
            komut2.Parameters.AddWithValue("@p1", odaNumarası);
            komut2.ExecuteNonQuery();
            dbbaglanti.baglanti.Close();

        }
        public void odaGuncelle(int odaNumarası, string odaDurumu, int yatakSayisi, int günlükücret, int kati)
        {
            dbbaglanti.baglanti.Open();
            MySqlCommand komut3 = new MySqlCommand("Update urunler set oda=@p1, durumu=@p2, yataksayisi=@p3, günlükücret=@p4,kati=@p5", dbbaglanti.baglanti);

            komut3.Parameters.AddWithValue("@p1", odaNumarası);
            komut3.Parameters.AddWithValue("@p2", odaDurumu);
            komut3.Parameters.AddWithValue("@p3", yatakSayisi);
            komut3.Parameters.AddWithValue("@p4", günlükücret);
            komut3.Parameters.AddWithValue("@p5", kati);

            komut3.ExecuteNonQuery();
            dbbaglanti.baglanti.Close();
        }
    }
}
