using DAL;
using Model;

namespace BAL
{
    public class CadastroBal
    {
        private static bool ConfirmaEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool ConfereIgualdade(string login, string password)
        {
            if (login == password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool ConfereTamanho(string value, int tamanho)
        {
            if (value.Length > tamanho)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Response Insert(string email, string userLogin, string userPassword)
        {
            Response res = new Response();

            if (ConfirmaEmail(email))
            {
                if (ConfereIgualdade(userLogin, userPassword))
                {
                    if (ConfereTamanho(email, 100) && ConfereTamanho(userLogin, 45) && ConfereTamanho(userPassword, 45))
                    {
                        res = CadastroDal.Insert(email, userLogin, userPassword);
                    }
                    else
                    {
                        res.Message = "Algo está grande de mais";
                        res.Success = false;
                    }
                }

                else
                {
                    res.Message = "Email invalido";
                    res.Success = false;
                }
            }
            else
            {
                res.Message = "Login e Senha devem ser diferente";
                res.Success = false;
            }
            return res;
        }
    }
}
