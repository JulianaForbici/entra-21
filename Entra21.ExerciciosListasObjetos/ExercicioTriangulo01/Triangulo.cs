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
        public int base1;
        public int altura2;
        public int apoio3;

        public int CalcularSomaLados()
        {
            var calculo = base1 * altura2 / 2;
            return calculo;
        }

    }