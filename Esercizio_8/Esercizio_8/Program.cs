using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_8
{
    public class Program
    {
        public class Person
        {
            public string Name;
            public string Surname;
            public string FiscalCode;

            // per vedere l'effetto diverso a runtime, nominare il metodo sotto virtual e 
            // quello della sottoclasse eliminare new e inserire override dopo public
            public void PrintInformations()
            {
                Console.WriteLine("Cognome: {0} Nome: {1} Codice Fiscale: {2}", Surname, Name, FiscalCode
                    + " da classe Person");
            }

        }

        public class Employee : Person
        {
            public string RegistrationNumber;
            public double Salary;

            new public void PrintInformations()
            {
                Console.WriteLine("Cognome: {0} Nome: {1} Codice Fiscale: {2} Matricola: {3} Stipendio {4}",
                    Surname, Name, FiscalCode, RegistrationNumber, Salary + " - da classe Employee");
            }

        }



        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Antonio",
                Surname = "Rossi",
                FiscalCode = "RSSNT6798HY",
                RegistrationNumber = "867",
                Salary = 1700
            };

            Person person = employee;
            person.PrintInformations();
            
            Console.ReadLine();
        }
    }
}
