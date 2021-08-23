using System;
using System.Collections.Generic;
using System.Linq;

// more advance shuffle / RNGCryptoServiceProvider demo: https://stackoverflow.com/questions/273313/randomize-a-listt 
namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            /*
            for (int i = 0; i < 10; i++)
            {
                //SimpleMethod(random);
                Console.WriteLine(random.NextDouble()*10);
            }
            */

            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Tim" },
                new PersonModel{FirstName = "Sue"},
                new PersonModel{FirstName = "Mary"},
                new PersonModel{FirstName = "George"},
                new PersonModel{FirstName = "Jane"},
                new PersonModel{FirstName = "Nancy"},
                new PersonModel{FirstName = "Bob"}
            };

            var sortedPeople = people.OrderBy(x => random.Next());

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);   
            }

            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }


    }
}
