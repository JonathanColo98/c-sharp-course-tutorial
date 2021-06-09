using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Motorizzazione;

namespace Esercizio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ferrari = new Car();
            Ferrari.Wheels = 4;
            Ferrari.InitialValue = 250000;
            Ferrari.RegistrationYear = 2010;
            Ferrari.showActualValue();
            Console.ReadLine();
        }

    }
}
