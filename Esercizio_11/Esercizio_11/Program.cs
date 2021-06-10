using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

// Creare un file di xml di prova e specificare la PATH per testarlo

namespace Esercizio_11
{
    [Serializable()]
    public class Car
    {
        [System.Xml.Serialization.XmlElement("StockNumber")]

        public string StockNumber { get; set; }
        [System.Xml.Serialization.XmlElement("Make")]

        public string Make { get; set; }

        public string Model { get; set; }
    }

    [Serializable()]
    [System.Xml.Serialization.XmlRoot("CarCollection")]
    public class CarCollection
    {
        [XmlArray("Cars")]
        [XmlArrayItem("Car", typeof(Car))]
        public Car[] Car { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new CarCollection();
            cars = XCar();

            //vedere a video il file
            foreach (var car in cars.Car)
            {
                Console.WriteLine(car.Make + " - " + car.Model + " - " + car.StockNumber);
            }

            cars = null;
            Console.ReadLine();
        }

        static CarCollection XCar()
        {
            // Deserializzazione
            // inserire in StreamReader, il percorso del file xml
            using (TextReader reader = new StreamReader(@""))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(CarCollection));
                return (CarCollection) serializer.Deserialize(reader);
            }
        }
    }
}
