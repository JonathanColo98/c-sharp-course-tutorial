using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Register = new int[5, 3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {10, 11, 12}, {13, 14, 15} };
            
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 3; column ++)
                {
                    Console.Write("\t" + Register[row, column]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
