using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo05
    {
        public void Executar()
        {


            int somaIdades = 0;
            int indice = 0;
            int maiorIdade = -200;
            int menorIdade = 200;

            while(indice <= 2)
            {
                Console.Write("Idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                somaIdades = somaIdades + idade;
                if(idade > maiorIdade)
                {
                    maiorIdade = idade;
                }
                if(idade < menorIdade)
                {
                    menorIdade = idade;
                }
            }

















        }

    }
}