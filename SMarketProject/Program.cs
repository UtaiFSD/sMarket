using System;
using System.Globalization;
using SMarketProject.Gerenciador;
using SMarketProject.Produto;
using SMarketProject.Produto.Enum;

namespace SMarketProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================@ SMarkert Program @===============================");
            Console.WriteLine();

            GerenciadorItensEValor gerenciador = new GerenciadorItensEValor();

            bool sair = false;

            while(!sair)
            {
                Console.Write("Código: ");
                long cod = Convert.ToInt64(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço (R$): ");
                double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Tipo (Ex.: KG ou UN): ");
                ProdutosEnum tipo = (ProdutosEnum) Enum.Parse(typeof(ProdutosEnum), Console.ReadLine().ToUpper());

                if(tipo == ProdutosEnum.KG)
                {
                    Console.Write("Peso: ");
                    double peso = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Produtos prod = new ProdutoPorPeso(cod, nome, preco, peso, tipo);
                    Console.WriteLine("R$ " + prod.ValorProduto().ToString("F2", CultureInfo.InvariantCulture));
                    gerenciador.SetQuantidadeDeItens(1);
                    gerenciador.SetValorTotal(prod.ValorProduto());
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Quantidade: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());
                    Produtos prod = new ProdutoPorQuantidade(cod, nome, preco, quantidade, tipo);
                    Console.WriteLine("R$ " + prod.ValorProduto().ToString("F2", CultureInfo.InvariantCulture));
                    gerenciador.SetQuantidadeDeItens(quantidade);
                    gerenciador.SetValorTotal(prod.ValorProduto());
                    Console.WriteLine();
                }

                Console.Write("Deseja continuar S ou N? ");
                string escolha = Console.ReadLine().ToUpper();
                if(escolha[0] == 'N')
                {
                    Console.WriteLine();
                    sair = true;
                }
                else if(escolha[0] == 'S')
                {
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Digite apenas S ou N.");
                    Console.WriteLine();
                    break;
                }
            }

            Console.WriteLine("Total de produtos: " + Produtos.GetTotalDeProdutos());
            Console.WriteLine("Quantidade de Itens: " + gerenciador.QuantidadeDeItens);
            Console.WriteLine("Valor Total R$: " + gerenciador.ValorTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
