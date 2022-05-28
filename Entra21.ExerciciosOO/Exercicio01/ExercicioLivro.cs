using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOO.Exercicio01
{
    internal class ExercicioLivro
    {
        public void Executar()
        {
            Livro livro = new Livro();
            Console.Write("Digite título do livro: ");
            livro.Titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            livro.Autor = Console.ReadLine();
            Console.Write("Digite o código de ISBN: ");
            livro.Isbn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o idioma original do livro: ");
            livro.IdiomaOriginal = Console.ReadLine();
            Console.Write("Digite a data de lançamento do livro: ");
            livro.DatadeLançamento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite a quantidade de páginas do livro: ");
            livro.QuantidadePaginas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de páginas lidas: ");
            livro.QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de releituras: ");
            livro.QuantidadeReleituras =  Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("O título do livro é: " + livro.ObterTitulo());
            Console.Write("O autor do livro é: " + livro.ObterAutor());
            Console.WriteLine("A quantidade de páginas lida foi: " + livro.ObterToTalPaginasLidas());
            Console.WriteLine("A quantidade de páginas que faltam para terminar: " + livro.ObterQuantidadePaginas());
        }
    }
}
