namespace Entra21.ExerciciosFor
{
    internal class Exercicio01
    {
       
        public void Executar()
        {
            Console.Clear();

            var nome = false;
            var preco = false;

            for (var i = 0; i < 13; i++)
            {
                while (nome == false)
                {
                    Console.Write("Informe o nome da peça: ");
                    var nomePeca = Console.ReadLine();

                    if (nomePeca.Length >= 2)
                    {
                        nome = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome da peça informado não é aceitado nesse sistema.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                while (preco == false)
                {
                    try
                    {
                        Console.Write("Informe o preço da peça: R$ ");
                        var precoPeca = Convert.ToDouble(Console.ReadLine());

                        if (precoPeca > 0.0)
                        {
                            preco = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor da peça informado não é aceito nesse sistema.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor da peça informado não é aceito nesse sistema.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                nome = false;
                preco = false;
            }
        }
    }
}