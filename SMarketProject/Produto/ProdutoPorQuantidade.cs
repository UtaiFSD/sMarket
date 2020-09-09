using SMarketProject.Produto.Enum;

namespace SMarketProject.Produto
{
    public class ProdutoPorQuantidade : Produtos
    {
        public int Quantidade { get; }
        public ProdutosEnum Tipo { get; }

        public ProdutoPorQuantidade(long id, string nome, double preco, int quantidade, ProdutosEnum tipo) 
            : base(id, nome, preco)
        {
            Quantidade = quantidade;
            Tipo = tipo;
        }

        public override double ValorProduto()
        {
            return Preco * Quantidade;
        }
    }
}
