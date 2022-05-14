using Entra21.ExerciciosFor;
using System;

Console.WriteLine(@"----------------------MENU----------------------)
1- Exercicio01
2- Exercicio02
3- Exercicio03
4- Exercicio04
5- Exercicio05
6- Exercicio06");

Console.WriteLine("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if(opcaoDesejada == 1)
{
    Exercicio01 Exercicio1 = new Exercicio01();
    Exercicio1.Executar();
}
else if(opcaoDesejada == 2)
{
    Exercicio02 Exercicio2 = new Exercicio02();
    Exercicio2.Executar();
}
if(opcaoDesejada == 3)
{
    Exercicio03 Exercicio3 = new Exercicio03();
    Exercicio3.Executar();
}
else if(opcaoDesejada == 4)
{
    Exercicio04 Exercicio4 = new Exercicio04();
    Exercicio4.Executar();
}
