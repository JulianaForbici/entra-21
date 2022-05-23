using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            //Criar um vetor para guardar 16 números inteiros e apresentar a soma dos números ao final.

            int[] numeros = new int[15];
            for (var i = 0; i < numeros.Length; i++)
            { 

            Console.Write("Digite o número: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());

            }
            var soma = 0;
           for (int i = 0; i < numeros.Length; i = i + 1)
            {
                soma = soma + numeros[0];
                Console.Clear();
                Console.WriteLine("Sua soma dos 16 números é: " + soma);
            }

        }
    }
}
