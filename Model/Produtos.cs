using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produtos
    {
        public Produtos(int iD, string nome, string descricao, float preco, int categoria)
        {
            ID = iD;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Categoria = categoria;
        }
        public Produtos()
        {

        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public int Categoria { get; set; }


    }
}
