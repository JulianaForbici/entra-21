namespace Entra21.ExerciciosFor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            // sucessor e antecessor com try catch e for

            int numero = 0;
            int sucessor = 0;
            int antecessor = 0;
            int indice = 0;
            while(numero < 50)
            {

                Console.Write("Digite um n�mero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            sucessor = numero + 1;
            antecessor = numero - 1;
                Console.WriteLine("O sucessor �: " + sucessor)
                Console.WriteLine("O antecessor �: " + antecessor)
            }
            

            for (var i = 0; i < numero; i++)

        }
    }
}