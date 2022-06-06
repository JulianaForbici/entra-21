using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Exercicio01.Listas
{
    public class Lists<>
    {
        // Criar uma classe que irá armazenar os melhores filmes de todos os tempos.

        Lists<string> melhoresFilmes = new List<string>();

        //Adicionar

        melhoresFilmes.Add("Dragon Ball Evollution");
        melhoresFilmes.Add("Titanic");
        melhoresFilmes.Add("Lanterna verde");

            //Listar

        Console.WriteLine("[0]: " + melhoresFilmes[0] +
                          "\n[1]: " + melhoresFilmes[1] +
                           "\n[2]: " + melhoresFilmes[2];
            //Adicionar

        melhoresFilmes.Add("");

            //Mudar
        
            melhoresFilmes[0] = "Dragon Ball Super: Broly";
 
            //Remover

            melhoresFilmes.RemoveAt[2];

            //Se existe
            string contemFilmeLanternaVerde = melhoresFilmes.Contais("Lanterna Verde");
            //if
            
        //add
        melhoresFilmes.Add("Quarteto Fntástico");
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Exercicio01.Listas
{
    public class Lists<>
        {
            // Criar uma classe que irá armazenar os melhores filmes de todos os tempos.

            Lists<string> melhoresFilmes = new List<string>();
            //Adicionar

            melhoresFilmes.Add("Dragon Ball Evollution");
        melhoresFilmes.Add("Titanic");
        melhoresFilmes.Add("Lanterna verde");

            //Listar

        Console.WriteLine("[0]: " + melhoresFilmes[0] +
                          "\n[1]: " + melhoresFilmes[1] +
                          "\n[2]: " + melhoresFilmes[2]);

            //Adicionar

        melhoresFilmes.Add("");

            //Mudar
        
            melhoresFilmes[0] = "Dragon Ball Super: Broly";
 
            //Remover

            melhoresFilmes.RemoveAt[2];

            //Se existe
            string contemFilmeLanternaVerde = melhoresFilmes.Contais("Lanterna Verde");

            melhoresFilmes.Add("Quarteto Fantástico");

            ("[0]: " + melhoresFilmes[0] +
                          "\n[1]: " + melhoresFilmes[1] +
                          "\n[2]: " + melhoresFilmes[2] +
                          "\n[3]: " + melhoresFilmes[3]);

                numeros[1] = "Titanic 2";

                 Console.WriteLine("[0]: " + melhoresFilmes[0] +
                          "\n[1]: " + melhoresFilmes[1] +
                          "\n[2]: " + melhoresFilmes[2] + 
                          "\n[3]: " melhoresFilmes[3] +
                          "\n[4): " melhoresFilmes[4]);

                string contemFilmeLagoaAzul = melhoresFilmes.Contais("Lagoa Azul");
            
        if (melhoresFilmes.Contains("Lagoa Azul")
                {
            Console.WriteLine("Existe Lagoa Azul na Lista.");
                 }
        else 
        {
            Console.WriteLine("Não existe Lagoa Azul na Lista");
        }
}
    }