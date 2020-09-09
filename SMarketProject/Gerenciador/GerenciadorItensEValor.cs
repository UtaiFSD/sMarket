namespace SMarketProject.Gerenciador
{
    public class GerenciadorItensEValor
    {
        public int QuantidadeDeItens { get; private set; }
        public double ValorTotal { get; private set;  }

        public GerenciadorItensEValor()
        {
        }

        public void SetQuantidadeDeItens(int quantidadeDeItens)
        {
            QuantidadeDeItens += quantidadeDeItens;
        }

        public void SetValorTotal(double valorTotal)
        {
            ValorTotal += valorTotal;
        }
    }
}
