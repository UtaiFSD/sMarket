namespace SMarketProject.Produto
{
    public abstract class Produtos
    {
        private static int _totalDeProdutos;

        public long Id { get; }
        public string Nome { get; }
        public double Preco { get; }

        public Produtos(long id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            _totalDeProdutos++;
        }

        public abstract double ValorProduto();

        public static int GetTotalDeProdutos()
        {
            return _totalDeProdutos;
        }
    }
}
