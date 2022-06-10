sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos
{
    public class Triangulo
    {
        public int Codigo;
        public int lado1;
        public int lado2;
        public int lado3;

        public int CalcularSomaLados()
        {
            var calculo = lado1 * lado2 / 2;
            return calculo;
        }

    }
}