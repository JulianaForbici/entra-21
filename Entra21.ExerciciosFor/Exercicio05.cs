namespace Entra21.ExerciciosFor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            var tabuada = 0;
            var i = 1000;

            while (tabuada <= 0)
            {
                try
                {
                    Console.WriteLine("Digite um número e apresentaremos a seguir sua multiplicação até mil: ")
                double tabuada = Convert.ToDouble(Console.ReadLine());

                    if (tabuada <= 0)
                    {
                        Console.WriteLine("Número não válido.");

                    }
                }
                catch (Excepetion ex)
                {
                    Console.WriteLine("Número não válido.");
                }
            }
            for (var j = 1; j <= i; j++)
            {

                var resultadoTabuada = j * tabuada;

                Console.WriteLine(j + "x" + tabuada + "=" + resultadoTabuada);
            }
        }
    }
}










//solicitar a tabuada do numero que o usuario pediu ate mil
