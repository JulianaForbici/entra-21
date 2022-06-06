using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Exercicio03.Listas
{
    public class Lists<>
    {
        Lists<double> notas = new List<double>();

        Console.Write("Digite sua primeira nota: ");
            notas[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            notas[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua terceira nota: ");
            notas[3] = Convert.ToDouble(Console.ReadLine());
             
            Console.WriteLine("Suas notas são: " + 
                          "\n[0]: " + notas[0] +
                          "\n[1]: " + notas[1] +
                          "\n[2]: " + notas[2]);

            double media = Convert.ToDouble(Console.ReadLine());
        media = nota[0] + notas[1] + notas[2] * 3;
            
            Console.WriteLine("Sua média é: " + media);

        if (media > 6) 
            {
            Console.WriteLine("Reprovado.");
             }
        else 
    {
            Console.WriteLine("Aprovado");
        }