using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOO.Exercicio02
{
    public class Temperatura
    {
        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double TemperaturaValor;
        
        public double CalcularCelsiusParaKelvin()
        {
            double CelsiusKelvin = TemperaturaValor + 273.15;
            return CelsiusKelvin;
        }
        public double CalcularCelsiusParaFahrenheit()
        {
            double CelsiusFahrenheit = TemperaturaValor * 1.8 + 32;
            return CelsiusFahrenheit;
        }
        public double CalcularKelvinParaCelsius() 
            {
               double KelvinCelsius = TemperaturaValor - 273.15;
               return = KelvinCelsius;
            } 
        public double CalcularKelvinParaFahrenheit()
        {
            double KelvinFahrenheit = TemperaturaValor * 1.8 + 32;
            return KelvinFahrenheit;
        }
        public double CalcularFahrenheitParaCelsius()
        {
            double FahrenheitCelsius = TemperaturaValor - 32 / 1.8;
            return FahrenheitCelsius;
        }
        public double CalcularFahrenheitParaKelvin()
        {
            double FahrenheitKelvin = TemperaturaValor - 32 * 5 / 9 + 273.15;
            return FahrenheitKelvin;
        }
        public string ObterTemperaturaConvertida()
        {
            if(TemperaturaOrigem == "c" && TemperaturaDestino == "f")
            {
                var temperaturaConvertida = CalcularCelsiusParaFahrenheit();
                return $"Temperatura Convertida:{temperaturaConvertida.ToString("F")}F";
            }
            else if(TemperaturaOrigem == "c" && TemperaturaDestino == "k")
            {
                var temperaturaConvertida = CalcularCelsiusParaKelvin();
                return $"Temperatura Convertida:{temperaturaConvertida.ToString("F")}K";
            }
            if(TemperaturaOrigem == "k" && TemperaturaDestino == "c")
            {
                var temperaturaConvertida = CalcularKelvinParaCelsius();
                return $"Temperatura Convertida:{temperaturaConvertida.ToString("F")}C";
            }
            else if(TemperaturaOrigem == "k" && TemperaturaDestino == "f")
            {
                var temperaturaConvertida = CalcularKelvinParaFahrenheit();
                return $"Temperatura Convertida:{temperaturaConvertida.ToString("F")}F";
            }
            if(TemperaturaOrigem == "f" && TemperaturaDestino == "c")
            {
                var temperaturaConvertida = CalcularFahrenheitParaCelsius();
                return $"Temperatura Convertida:{temperaturaConvertida.ToString("F")}C";
            }
            else if(TemperaturaOrigem == "f" && TemperaturaDestino == "k")
            {
                var temperaturaConvertida = CalcularFahrenheitParaKelvin();
                return $"Temperatura Convertida:{temperaturaConvertida.ToString("F")}K";
            }
         
        }

    }