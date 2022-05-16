
namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            //terminar a lição 2
            Console.Write("Modelo do carro: ");
            int quantidadeCarros = Conver.ToInt32(Console.ReadLine());
            double somaPrecos = 0;

            for (int i -0; i < quantidadeCarros; int++)
            {
                Console.Write("Modelo do carro: ");
                string modelo = Console.ReadLine().Trim();
                Console.Write("Preço: ");
                double preco = Convert.ToDouble(Console.ReadLine());
                somaPrecos = somaPrecos + preco;
                if (modelo.StartsWith("a") == true)
                {
                    comecaComA = comecaComA + 1;
                }
                if (modelo.StartsWith("g") == true)
                {
                    comecaComG= comecaComG + 1;
                }
            }
            Console.WriteLine("Soma dos preços: " + somaPrecos);
           
            