using SMarketProject.Produto.Enum;

namespace SMarketProject.Produto
{
    public class ProdutoPorPeso : Produtos
    {
        public double Peso { get; }
        public ProdutosEnum Tipo { get; }

        public ProdutoPorPeso(long id, string nome, double preco, double peso, ProdutosEnum tipo) 
            : base(id, nome, preco)
        {
            Peso = peso;
            Tipo = tipo;
        }

        public override double ValorProduto()
        {
            return Preco * Peso;
        }
    }
}
