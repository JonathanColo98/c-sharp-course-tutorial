using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = {29, 15, 30, 98};
            int[] temp = list;

            
            foreach (int i in list)
            {
                Console.Write(i + " - ");
            }
            Console.WriteLine();
            Console.ReadLine();
            Array.Reverse(temp);
            Console.Write("Reverse: ");

            foreach (int i in temp)
            {
                Console.Write(i + " - ");
            }
            Console.ReadKey();
        }
    }
}
