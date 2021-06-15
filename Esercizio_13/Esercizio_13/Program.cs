using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, -6, 3, 0, -4, 25, 15, -5 };

            //QUERY

            var numbers_positives = from n in numbers where n > 0 select n;
            Console.WriteLine("I numeri dell'array positivi sono : ");

            foreach (int i in numbers_positives)
            {
                Console.Write(i + " - ");
            }

            List<int> listNumbers = new List<int>() { 5, 4, 1, 3, 5, 8, 9, 15, 99, 2, 9, 7, 8, 9, 15, 16, 17 };

            //Query di raggruppamento
            Console.WriteLine("Nuovo elenco");
            //Media
            double average = listNumbers.Average();
            Console.WriteLine("Media: " + average.ToString());

            double sum = listNumbers.Sum();
            Console.WriteLine("Somma: " + sum.ToString());

            double max = listNumbers.Max();
            Console.WriteLine("Massimo: " + max.ToString());

            double min = listNumbers.Min();
            Console.WriteLine("Minimo: " + min.ToString());

            int count = listNumbers.Count();
            Console.WriteLine("Numero di elementi: " + count.ToString());

            Console.ReadLine();
        }
    }
}
