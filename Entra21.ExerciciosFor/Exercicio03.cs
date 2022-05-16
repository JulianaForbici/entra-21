namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            // como fazer um cronometro

            for (int i = 0; i < 10; i = i + 1)
            {
                int hora = 0;
                while(hora <= 23)
                {
                    int minuto = 0;
                    while(minuto < 60)
                }
                int segundo = 0;
                while(segundo <= 59)
                {
                    Console.Write(hora + " : " + minuto + " : " + segundo);
                    segundo = segundo + 1;
                }
                minuto = minuto + 1;
            }
            hora = hora + 1;