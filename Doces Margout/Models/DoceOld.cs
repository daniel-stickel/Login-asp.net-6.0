namespace DocesMargout.Models
{
    public class DoceOld
    {
        public int DoceID { get; set; }
        public string Nome { get; set; } 

        public string? Sabor { get; set; }

        public string? Descricao { get; set; }

        public string? Ingredientes { get; set; } // poderia ser uma List<string> Ingredientes

        public int Categoria { get; set; } // Lista de categorias

        public decimal Preco { get; set; }
    }

    public enum ECategoria
    {
        Cuca = 1,
        Bolo = 2,
        Torta = 3,
        Biscoito = 4,
        Bolacha = 5,
        BoloConfeitado = 6
    }


}
