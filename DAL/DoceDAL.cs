
using Objects;
using System.Data.Common;
using System.Data.SqlClient;

namespace DAL
{
    public class DoceDAL
    {
        public static List<Doce> SelectAll()
        {
            List<Doce> elementos = new List<Doce>();

            string commandText = "SELECT * from dbo.Doce";
            SqlCommand cmd = new SqlCommand(commandText, DBConnection.Conn);

            try
            {
            DBConnection.Conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                elementos.Add(new Doce
                {
                    DoceID = int.Parse(dr["DoceID"].ToString()),
                    Nome = dr["Sabor"].ToString(),
                    Descricao = dr["Descricao"].ToString(),
                    Ingredientes = dr["Ingredientes"].ToString(),
                    Categoria = int.Parse(dr["Categoria"].ToString()),
                    Preco = decimal.Parse(dr["Preco"].ToString())
                }
                 );
            }
            cmd.Dispose();
            dr.DisposeAsync();
            DBConnection.Conn.Close();
            }
            catch (Exception ex)
            {
               // DBConnection.Conn.Close();
             
            }
            return elementos;
        }

        public static bool Insert(Doce item)
        {
            string commandText = $"INSERT into dbo.Doce (Nome,Sabor,Descricao,Ingredientes,Categoria,Preco) values ('{item.Nome}','{item.Sabor}','{item.Descricao}','{item.Ingredientes}',{item.Categoria},{item.Preco.ToString().Replace(',','.')})"; 

            SqlCommand cmd = new SqlCommand(commandText, DBConnection.Conn);

            try
            {
                DBConnection.Conn.Open();
                    cmd.ExecuteNonQuery();
                DBConnection.Conn.Close();
                return true;
            }
            catch (Exception)
            {
                DBConnection.Conn.Close();
                return false;
            }

            

        }

        public static bool Delete(int id)
        {
            string commandText = $"DELETE from dbo.Doce WHERE DoceID = {id}";
            SqlCommand cmd = new SqlCommand(commandText, DBConnection.Conn);

            
            try
            {
                DBConnection.Conn.Open();
                cmd.ExecuteNonQuery();
                DBConnection.Conn.Close();
            }
            catch (Exception)
            {   // Adicionar o Log de erro  "pendente
                DBConnection.Conn.Close();
                return false;
            }

            return true;

        }


    }
}