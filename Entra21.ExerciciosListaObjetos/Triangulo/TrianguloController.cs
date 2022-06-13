using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos
{
    internal class TrianguloController
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;

            while (codigo != 6)
            {
                //    codigo = ApresentarMenu();

                if (codigo == 1)
                {
                    // Cadastrar();
                }
                else if (codigo == 2)
                {
                    //  Editar();
                }
                else if (codigo == 3)
                {
                    //   Apagar();
                }
                else if (codigo == 4)
                {
                    //   ApresentarTodos();
                }
                else if (codigo == 5)
                {
                    // ApresentarTriangulo();
                }
                else
                {
                    Console.WriteLine(@"Aperte alguma tecla para continuar.");
                    Console.ReadKey();
                }

                Console.WriteLine(@"--------------MENU-------------
1- Cadastrar.
2- Editar.
3- Apagar.
4- Apresentar todos os triângulos.
5- Apresentar o triângulo.
6- Sair.");

            }
        }
    }
}
                


    

