using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            int quantidadeProdutos = 0;
            double valorTotalProduto = 0;

            while(quantidadeProdutos < 5)
            {
                Console.Write("Digite o nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                double valorProduto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a quantidade de produtos: ");
                quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                double valorTotalDoProduto = valorProduto * quantidadeProdutos;
                valorProduto = valorProduto + valorTotalDoProduto;
            }
            Console.WriteLine("O valor total do produto sem desconto é: " + valorTotalProduto);
            double valorDoProdutoComDesconto = valorTotalProduto - 150;
            Console.WriteLine("O Valor total do produto com o desconto: " + valorDoProdutoComDesconto);




        }






    }
}
