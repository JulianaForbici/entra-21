using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForVetor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            //Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior idade.
            
            int[] idade = new int[9];
              for (var i = 0; i < idade.Length; i++)
            {
                Console.Write("Digite a idade: ");
                idade[0] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Sua idade é: " + idade[0]);
            }

        }
    }
}
