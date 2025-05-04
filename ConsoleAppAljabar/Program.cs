using System;
using AljabarLibraries;

namespace ConsoleAppAljabar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Akar persamaan kuadrat
            double[] persamaan1 = { 1, -3, -10 };
            double[] akar = Aljabar.AkarPersamaanKuadrat(persamaan1);
            Console.WriteLine("Akar-akarnya adalah: " + string.Join(", ", akar));

            // Persamaan linear
            double[] persamaan2 = { 2, -3 };
            double[] hasilKuadrat = Aljabar.HasilKuadrat(persamaan2);
            Console.WriteLine("Hasil kuadratnya adalah: " + string.Join(", ", hasilKuadrat));
        }
    }
}
