using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            string nomeProduto = "";
            double valorDoPedido = 0;


            while (nomeProduto != "sair")

            {

                Console.Write("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine();
                if(nomeProduto != "sair")
                {
                    Console.Write("Digite o valor do produto: ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite quantidade do produto: ");
                    int quantidadeProduto = Convert.ToInt32(Console.ReadLine());
                    double valorTotalDoProduto = valorProduto * quantidadeProduto;
                    valorDoPedido = valorDoPedido + valorTotalDoProduto;
                }
               
               
            }
            Console.WriteLine("O valor total do produto sem desconto é: " + valorDoPedido);
            double valorDoPedidoComDesconto = valorDoPedido * 0.95;

            Console.WriteLine("O valor total do produto com desconto é: " + valorDoPedidoComDesconto);
        }
    }
}
