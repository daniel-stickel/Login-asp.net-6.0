using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class BDConnection
    {
        public static SqlConnection conn = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\70410\Desktop\ASP.NET\AulaInicial\DAL\AulaInicialBD.mdf;Integrated Security=True"); // Esse link muda de computador para computador

        public static SqlConnection Conn { get => conn; private set => conn = value; }

    }
}
