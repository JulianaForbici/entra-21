using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio10
    {
      public void Executar()
        {
            int numero = 0;
            int contador = 0;
             while(contador >= 50)
           Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            contador = contador - 1;
            contador = contador + 1;
        }

