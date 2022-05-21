using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForVetor
{
    internal class Exercicio03
    {
        public void Executar()
        {

            //Criar dois vetores para guardar os nomes e os preços de 7 produtos e apresentar o nome e o preço dos respectivos.

            string[] nomes = new string[6];
            double[] valores = new double[6];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome da peça: ");
                nomes[0] = Console.ReadLine().Trim().ToLower();
                while (nomes[0].Length < 1 || nomes[0].Length > 100)
                {
                    Console.WriteLine("Digite um nome maior do que 1 caracteres e com no máximo 100 caracteres.");
                    Console.Write("Digite o nome: ");
                    nomes[0] = Console.ReadLine().Trim().ToLower();
                }
                Console.Write("Digite o preço da peça: ");
                valores[0] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            var apresentarNomes = "";
            var apresentarPrecos = 0.0;
            for (var i = 0; i < apresentarNomes.Length; i++)
            {

                apresentarPrecos = apresentarPrecos + valores[0];
                apresentarNomes = apresentarNomes + nomes[0];
          
                Console.WriteLine("Nomes peças: " + apresentarNomes);
                Console.WriteLine("Preços peças: " + apresentarPrecos);
            }




        }
    }
}
