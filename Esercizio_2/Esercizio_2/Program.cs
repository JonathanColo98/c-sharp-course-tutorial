using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_2
{
    class Geometry
    {
        class Form // classe padre
        {
            public double length;
            public double heigth;
        }

        class Rectangle : Form // classe derivata
        {
            // metodi
            public double Area()
            {
                return length * heigth;
            }

            public double Perimeter()
            {
                return 2 * (length + heigth);
            }

            public bool Triangle_Rectangle()
            {
                if (length == heigth)
                    return true;
                else
                    return false;
            }

            public void View_Data()
            {
                Console.WriteLine("Lunghezza: {0}", length);
                Console.WriteLine("Altezza: {0}", heigth);
                Console.WriteLine("Area: {0}", Area());
                Console.WriteLine("Perimetro: {0}", Perimeter());
                Console.WriteLine("Triangolo rettangolo?: {0}", Triangle_Rectangle());
            }

        }

        static void Main(string[] args)
        {
            // istanza
            double number1, number2;
            Console.WriteLine("Inserisci la lunghezza: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci l'altezza: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            // costruttore
            rectangle.length = number1;
            rectangle.heigth = number2;
            rectangle.View_Data();
            Console.ReadLine();
        }
    }
}
