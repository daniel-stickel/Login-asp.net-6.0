namespace DocesMargout.Models
{
    public class MockDoce : IDoce
    {
        public IEnumerable<Doce> TodosDoces => new List<Doce>
        {
            new Doce {DoceID = 1, Nome = "Cuca de farofa ", Descricao = "Uma cuca feita com muito amor e carrinho, massa tradiconal e cobertura de farofa tipica alemã  ALÉRGICOS: Contém Glutem, Contém Lactose", Ingredientes  = "Farinha de trigo , Fermanto Biológico, Açúcar, Sal, Ovo , Leite , Manteiga", Categoria = ECategoria.Cuca, Sabor = "Farofa", Preco = 15.99m },

            new Doce {DoceID = 2, Nome = "Cuca de Banana ", Descricao = "Uma cuca feita com muito amor e carrinho, massa tradiconal e cobertura de Banana tipica alemã  ALÉRGICOS: Contém Glutem, Contém Lactose", Ingredientes  = "Farinha de trigo , Fermento Biológico, Açúcar, Sal, Ovo , Leite , Manteiga", Categoria = ECategoria.Cuca, Sabor = "Banana Caramelizada", Preco = 16.99m },

            new Doce {DoceID = 3, Nome = "Nega Maluca ", Descricao = "Uma massa fofinha com cobertura que derete na boca ALÉRGICOS: Contém Glutem, Contém Lactose", Ingredientes  = "Farinha de trigo , Fermanto Biológico, Açúcar, Sal, Ovo , Leite , Manteiga, Achocolatado, Crema de Leite", Categoria = ECategoria.Bolo, Sabor = "Chocolate", Preco = 14.99m  },

            new Doce {DoceID = 4, Nome = "Cuca de Morengo ", Descricao = "Uma cuca feita com muito amor e carrinho, massa tradiconal e cobertura de Banana tipica alemã  ALÉRGICOS: Contém Glutem, Contém Lactose", Ingredientes  = "Farinha de trigo , Fermento Biológico, Açúcar, Sal, Ovo , Leite , Manteiga", Categoria = ECategoria.Cuca, Sabor = "Morengo", Preco = 19.99m },
        };

        public Doce GetDoceID(int DoceID) => TodosDoces.FirstOrDefault(p => p.DoceID == DoceID);
    //{
     //   throw new NotImplementedException();
    //}
}
}
