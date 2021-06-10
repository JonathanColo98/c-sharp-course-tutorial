using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Esercizio_11
{
    [Serializable()]

    public class Car
    {
        [System.Xml.Serialization.XmlElement("StockNumber")]

        public string StockNumber { get; set; }
        [System.Xml.Serialization.XmlElement("Make")]

        public string Make { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
