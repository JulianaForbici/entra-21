using Entra21.ExerciciosWhile;
using System;

Console.WriteLine(@"----------------------MENU----------------------
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03
4 - Exercicio 04
5 - Exercicio 05
6 - Exercicio 06
7 - Exercicio 07");

Console.WriteLine("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 Exercicio1 = new Exercicio01();
    Exercicio1.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 Exercicio2 = new Exercicio02();
    Exercicio2.Executar();
}
if (opcaoDesejada == 3)
{
    Exercicio03 Exercicio3 = new Exercicio03();
    Exercicio3.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicio04 Exercicio4 = new Exercicio04();
    Exercicio4.Executar();
}
    if (opcaoDesejada == 5)
    {
    Exercicio05 Exercicio5 = new Exercicio05();
    Exercicio5.Executar();
    }
    else if (opcaoDesejada == 6)
{
    Exercicio07 Exercicio7 = new Exercicio07();
    Exercicio7.Executar();
}
    else if (opcaoDesejada == 7)
    {
        Exercicio07 Exercicio7 = new Exercicio07();
        Exercicio7.Executar();
    }


