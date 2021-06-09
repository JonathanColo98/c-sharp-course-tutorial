using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_3
{
    public class Veichle
    {
        public int Wheels;
        public float Speed;
        public int Direction;
        private bool EngineOnOff;

        public float getSpeed()
        {
            return Speed;
        }

        public void onEngine()
        {
            if (!EngineOnOff)
                EngineOnOff = true;
        }

        public void offEngine()
        {
            if (EngineOnOff)
                EngineOnOff = false;
        }

        public class Car : Veichle {
            public float Displacement;
            public bool AirConditioning;
            public float InitialValue;
            public int RegistrationYear;

            public double CalculateActualValue()
            {
                int ActualYear = DateTime.Now.Year;
                int CountYear = RegistrationYear;
                double Value = InitialValue;

                do
                {
                    Value = Value * 0.95;
                    if (CountYear != ActualYear)
                    {
                        CountYear += 1;
                    }
                } while (ActualYear != CountYear);

                return Value;
            }

            public void showActualValue()
            {
                Console.WriteLine("Il valore attuale è: {0}", CalculateActualValue());
            }
        
        }

        static void Main(string[] args)
        {
            // istanza
            Car Golf = new Car();
            Golf.Displacement = 2000;
            Golf.RegistrationYear = 2020;
            Golf.Wheels = 4;
            Golf.InitialValue = 25000;
            Golf.Speed = 180;
            Golf.showActualValue();
            Console.ReadLine();

        }

    }
}
 