using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DBConnection
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\70410\Desktop\DAL\DataBaseMargot.mdf;Integrated Security=True"); // Esse link muda de computador para computador. o link pega na propriedades do banco de dados clicando em cima da Tabela e na laterl direita inferior copiar a cadeia de conexão e cola dentro das aspas 

        public static SqlConnection Conn { get => conn; private set => conn = value; }
    }
}

