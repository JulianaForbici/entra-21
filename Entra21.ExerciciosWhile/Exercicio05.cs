using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            int quantidadeCarros = 0;
            int contador = 0;
            Console.Write("Quantidade de carros que você quer cadastrar: ");
            quantidadeCarros = Convert.ToInt32(Console.ReadLine());
            int somaAnoVrumvrum = 0;
            int mediaAnosVrumvrum = 0;
            double somaValorVrumvrum = 0;
            double mediaValorVrumvrum = 0;
            int comecaComGVrumvrum = 0;
            int comecaComAVrumvrum = 0;
            

            while(contador < quantidadeCarros)
            {
                Console.Write("Digite o modelo de carro que você quer cadastrar: ");
                string modeloVrumvrum = Console.ReadLine().ToLower().Trim();
                Console.Write("Digite o valor do carro: ");
                double valorVrumvrum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o ano do carro: ");
                int anoVrumvrum = Convert.ToInt32(Console.ReadLine());
                somaAnoVrumvrum = somaAnoVrumvrum + anoVrumvrum;
                somaValorVrumvrum = somaValorVrumvrum + valorVrumvrum;
                if (modeloVrumvrum.StartsWith("a") == true) 
                {
                    comecaComAVrumvrum = comecaComAVrumvrum + 1;
                }
                if(modeloVrumvrum.StartsWith("g") == true)
                {
                    comecaComGVrumvrum = comecaComGVrumvrum + 1;
                }
                contador = contador + 1;
            }

            Console.WriteLine("A média do ano dos carros é: " + somaAnoVrumvrum);
            Console.WriteLine("A média do valor dos carros é: " + somaValorVrumvrum);
            Console.WriteLine("Quantidade dos carros que começam com a letra g: " + comecaComGVrumvrum);
            Console.WriteLine("Quantidade dos carros que começam com a letra a: " + comecaComAVrumvrum);
           

        }
    }
}
