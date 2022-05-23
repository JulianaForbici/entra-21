using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForVetor
{
    internal class Exercicio05
    {
        public void Executar() 
        {
            //Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média dos pesos.

           double[] pesos = new double[5];
           double somaPesos = 0.0;
           double mediaPesos = 0.0;
            

            for (var i = 0; i < pesos.Length; i++)
            {
                Console.Write("Digite peso: ");
                pesos[0] = Convert.ToDouble(Console.ReadLine());
                   Console.Clear();

            }
            for(var i = 0; i < somaPesos.Length; i++)
            {
                somaPesos = somaPesos + pesos[0] + pesos[1] + pesos[2] + pesos[3] + pesos[4] + pesos[5];
                Console.WriteLine("Soma dos pesos: " + somaPesos);
                mediaPesos = mediaPesos + somaPesos / pesos[0];
                Console.WriteLine("Sua média de pesos é: " + mediaPesos);
           
            }
                
           
           
            
        }
    }
}
