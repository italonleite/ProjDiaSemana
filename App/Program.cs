using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var diaSemana = new DiaSemana();

                EnumDias dia = EnumDias.Seg;
                int intervalo = 5;
                Console.WriteLine(diaSemana.BuscaDiaSemana(dia, intervalo));
            }
            catch (System.Exception)
            {
                Console.WriteLine("Houve um erro ao tentar buscar o dia da semana");
            }
        }
    }
}