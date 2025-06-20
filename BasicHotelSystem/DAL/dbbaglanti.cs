using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rüvisotelnypprj.DAL
{
    class dbbaglanti
    {
        public static MySqlConnection baglanti = new MySqlConnection("Server=localhost,Database=ybsdb,Uid=root");

    }
}
