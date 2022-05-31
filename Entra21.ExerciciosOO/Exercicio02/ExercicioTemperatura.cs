using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOO.Exercicio02
{
    public class ExercicioTemperatura
    {
        public void Executar()
        {
            Temperatura temperatura = new Temperatura();
            Console.WriteLine("Informe a temperatura origem: ");
            temperatura.TemperaturaOrigem = Console.ReadLine().ToLower();      
            Console.WriteLine("Informe a temperatura de destino: ");
            temperatura.TemperaturaDestino = Console.ReadLine().ToLower();      
            var novaTemperatura = temperatura.ObterTemperaturaConvertida();
            Console.WriteLine(novaTemperatura);
        }
    }
}