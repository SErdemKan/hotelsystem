using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rüvisotelnypprj.DOMAIN
{
    class odalar
    {
        int oda;
        string durumu;
        int yataksayisi;
        int günlükücret;
        int kati;

        public int Oda { get => oda; set => oda = value; }
        public string Durumu { get => durumu; set => durumu = value; }
        public int Yataksayisi { get => yataksayisi; set => yataksayisi = value; }
        public int Günlükücret { get => günlükücret; set => günlükücret = value; }
        public int Kati { get => kati; set => kati = value; }
    }
}
