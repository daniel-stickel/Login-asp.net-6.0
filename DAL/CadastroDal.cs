using Model;
using System.Data.SqlClient;

namespace DAL
{
    public static class CadastroDal    {
        public static Response Insert(string email, string userLogin, string userPassword)
        {
            Response res = new Response();
            string commandText = $"INSERT into dbo.Cadastro (Email,UserLogin,UserPassword) values ('{email}','{userLogin}','{userPassword}')";

            SqlCommand cmd = new SqlCommand(commandText, BDConnection.Conn);

            try
            {
                BDConnection.Conn.Open();

                cmd.ExecuteNonQuery();

                BDConnection.Conn.Close();
            }
            catch (Exception ex)
            {

                res.Message = ex.Message;
                res.Success = false;
                return res;

            }

            res.Message = $"Cadastro Efetuado {email}";
            res.Success = true;
            return res;
            
        }


    }
}