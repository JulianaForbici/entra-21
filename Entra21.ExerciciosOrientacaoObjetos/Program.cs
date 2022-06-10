using Entra21.ExerciciosOO;
using Entra21.ExerciciosOO.Exercicio01;
using System;

Console.WriteLine(@"----------------------MENU----------------------
1 - Exercicio01
2 - Exercicio02
3 - Exercicio03
4 - Exercicio04
5 - Exercicio05
6 - Exercicio06
7 - Exercicio07
8 - Exemplo08");

Console.WriteLine("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    ExercicioLivro exercicioLivro = new ExercicioLivro();
    exercicioLivro.Executar();
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

