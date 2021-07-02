using System;
using System.Collections;
using System.Collections.Generic;

namespace EsempioOutIn
{
    public interface ICruiseControl<T>
    {
        public void SetSpeed(T obj, double speed);
    }

    public class Veichle
    {
        public double Speed { get; set; }
    }

    public class Car : Veichle
    {
        public double Wheels { get; set; }
        public double Speed
        {
            get => base.Speed;
            set
            {
                base.Speed = value + 10;
            }
        }
    }

    class VeichleCruiseControl<T> : ICruiseControl<T> where T : Veichle
    {
        public void SetSpeed(T obj, double speed)
        {
            obj.Speed = speed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VeichleCruiseControl veichleCruiseControl = new VeichleCruiseControl();
            Veichle v1 = new Veichle();
            veichleCruiseControl.SetSpeed(new Veichle(), 100);
            ICruiseControl<Car> carCruiseControl = veichleCruiseControl;
            IEnumerable<int> prova = new List<int>();
            Car c1 = new Car();
            carCruiseControl.SetSpeed(c1, 4);
        }

        private void Somma(out int dest, int num1, int num2)
        {
            dest = num1 + num2;
        }
    }
}
