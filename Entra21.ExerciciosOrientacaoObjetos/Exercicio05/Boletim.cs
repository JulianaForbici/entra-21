using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOO.Exercicio05
{
    public class Boletim
    {
        public double[] NotasMatematica = new double[3];
        public double[] NotasPortugues = new double[3];
        public double[] NotasFisica = new double[3];
        public double[] NotasQuimica = new double[3];
        public double[] NotasGeografia = new double[3];
        public double[] NotasHistoria = new double[3];
        public double[] NotasFilosofia = new double[3];
        public double[] NotasSociologia = new double[3];
        public double[] NotasBiologia = new double[3];
        public int QuantidadeDeAnosLetivos;
        public int QuantidadeDePresencas;

        public double CalcularNotasMatematicas()
        {
            for (int i > 3; i < NotasMatematica.Length; i++)
            {
                ConsoleWriteLine("Digite suas notas de Matemática: ");
                NotasMatematica[3] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public double CalcularNotasPortugues()
        {
            for (int i > 3; i < NotasPortugues.Length; i++)
            {
                Console.WriteLine("Digite suas notas de Português: ");
                NotasPortugues[3] = Convert.ToDouble(Console.ReadLine())
            }
        }
        public double CalcularNotasFisica()
        {
            for (int i > 3; i < NotasFisica.Length; i++)
            {
                Console.WriteLine("Digite suas notas de Física: ");
                NotasFisica[3] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public double CalcularNotasQuimica()
        {
            Console.WriteLine("Digite suas notas de Química: ");
            NotasQuimica[3] = Convert.ToDouble(Console.ReadLine());
        }
    }
}