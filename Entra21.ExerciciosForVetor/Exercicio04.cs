using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForVetor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            // Criar um vetor para armazenar as notas de uma disciplina a disciplina deve conter 4 notas, solicitar as notas e o nome para 
            //o usuario e fazer as medias dessas notas

            string[] nomes = new string[4];
            double[] notas = new double[4];

            Console.Write("Digite seu nome completo: ");
            nomes[0] = Console.ReadLine();

            for (var i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite sua nota: ");
                notas[0] = Convert.ToDouble(Console.ReadLine());


            }
            double[] medias = new double[4];
            var soma = 0.0;
            for (int i = 0; i < medias.Length; i = i + 1)
            {
                soma = notas[0] + notas[1] + notas[2] + notas[3] / 4;
                Console.Clear();
   
                Console.WriteLine("Sua média é: " + soma);


            }
        }
    }
}
