using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForVetor
{
    internal class Exercicio02
    {    ///Fazer um vetor para 10 nomes e apresentar eles ao fim.
        public void Executar()
        {
            string[] nomes = new string[9];
            for (var i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome: ");
                nomes[0] = Console.ReadLine().Trim().ToLower();

                while (nomes[0].Length < 3 || nomes[0].Length > 100)
                {
                    Console.WriteLine("Digite um nome maior do que 3 caracteres e com no máximo 100 caracteres.");
                    Console.Write("Digite o nome: ");
                    nomes[0] = Console.ReadLine().Trim().ToLower();
                }

               
            }

        }
    }
}


