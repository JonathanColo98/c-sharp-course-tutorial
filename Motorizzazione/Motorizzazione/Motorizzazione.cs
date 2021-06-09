using System;

namespace Motorizzazione
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

    }

    public class Car : Veichle
    {
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
}
