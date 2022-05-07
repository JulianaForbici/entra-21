using System;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int indice = 0;
            int preço = Convert.ToInt32(Console.ReadLine());
            string nome = Console.ReadLine();

            while (indice >= 13)
            {
                Console.Write("Digite o preço: " + preço);
                Console.Write("Digite o nome: " + nome);           
            }
            indice = indice + 1;
        }
    }
}
