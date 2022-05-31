using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOO
{
    internal class Exercicio03
    {
        public void Executar()
        {
            Conversor conversor = new Conversor();
            Console.Write("Digite o número do código ascii e mostraremos seu respectivo caracter: ");
            conversor.Caracter = Console.ReadLine();
             
        }
    }
}
