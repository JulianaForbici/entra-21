using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos
{
    internal class Aluno
    {
        public string Cadastrar;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        
        public double CalcularMediaTotal()
        {
            var media = Nota1 + Nota2 + Nota3 / 3;
        }
        
    }
}
