using DAL;
using Objects;

namespace BAL
{
    public static class DoceBAL
    {
        public static List<Doce> SelectAll()
        {
            return DoceDAL.SelectAll();
        }

        public static bool Insert(string nome, string sabor, string descricao, string ingredientes, int categoria, string preco)
        {
            if (preco.Contains('.'))
            {
                preco = preco.Replace('.', ',');
            }


            Doce doce = new Doce { DoceID = 0, Nome = nome, Sabor = sabor, Descricao = descricao, Ingredientes = ingredientes, Categoria = categoria, Preco = Convert.ToDecimal(preco) };

            return DoceDAL.Insert(doce);
        }

        public static bool Delete(int id)
        {
            return DoceDAL.Delete(id);
        }

    }
}