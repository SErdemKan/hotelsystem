using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rüvisotelnypprj.DOMAIN
{
    class müsteriler
    {
        string adSoyad;
        int tcKimlik;
        string adres;
        int telefon;
        string email;
        int odalar;
        int tutar;
        int odemeturu;
        int giristarihi;
        int cikistarihi;

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public int TcKimlik { get => tcKimlik; set => tcKimlik = value; }
        public string Adres { get => adres; set => adres = value; }
        public int Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public int Odalar { get => odalar; set => odalar = value; }
        public int Tutar { get => tutar; set => tutar = value; }
        public int Odemeturu { get => odemeturu; set => odemeturu = value; }
        public int Giristarihi { get => giristarihi; set => giristarihi = value; }
        public int Cikistarihi { get => cikistarihi; set => cikistarihi = value; }
    }
}
