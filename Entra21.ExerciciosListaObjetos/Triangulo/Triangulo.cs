using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos
{

    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;

        public bool ValidarTriangulo()
        {
            var trianguloValido = true;
            if (Lado1 + Lado2 < Lado3)
            {
                return trianguloValido;
            }
            return false;
        }

    }
        
}

