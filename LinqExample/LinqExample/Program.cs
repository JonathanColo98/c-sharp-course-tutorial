using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    public class F1Team
    {
        public string TeamName { get; set; }
        public Pilot[] Pilots { get; set; }

        public int Wins { get; set; }

        public override string ToString()
        {
            return String.Format("Team {0}, Wins : {1}", this.TeamName, this.Wins);
        }
    }

    public class Pilot
    {
        public F1Team Team { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int IdCountry { get; set; }

        public int Points { get; set; }
    }

    public class Country
    {
        public int IdCountry { get; set; }

        public string Name { get; set; }

        public static List<Country> All = new List<Country>(
            new Country[]
            {
                new Country(){ IdCountry = 1, Name = "Spagna" },
                new Country(){ IdCountry = 2, Name = "Brasile" },
                new Country(){ IdCountry = 3, Name = "Germania" },
                new Country(){ IdCountry = 4, Name = "Australia" },
                new Country(){ IdCountry = 5, Name = "Regno Unito" },
                new Country(){ IdCountry = 6, Name = "Messico" },
                new Country(){ IdCountry = 7, Name = "Finlandia" },
                new Country(){ IdCountry = 8, Name = "Svizzera" },
                new Country(){ IdCountry = 9, Name = "Italia" },
                new Country(){ IdCountry = 10, Name = "USA" },
            }
       );
    }

    class Program
    {

        public static IList<F1Team> createListTeams()
        {

            IList<F1Team> teams = new List<F1Team>();
            teams.Add(new F1Team()
            {
                TeamName = "Ferrari",
                Wins = 7,
                Pilots = new Pilot[]
                {
                    new Pilot() { FirstName = "Fernando", LastName = "Alonso", IdCountry = 1, Points = 120},
                    new Pilot() { FirstName = "Felipe", LastName = "Massa", IdCountry = 2, Points = 42}
                }
            });

            teams.Add(new F1Team()
            {
                TeamName = "Red Bull",
                Wins = 10,
                Pilots = new Pilot[]
                {
                    new Pilot() { FirstName = "Sebastian", LastName = "Vettel", IdCountry = 3, Points = 112},
                    new Pilot() { FirstName = "Mark", LastName = "Webber", IdCountry = 4, Points = 77}
                }
            });

            teams.Add(new F1Team()
            {
                TeamName = "McLaren",
                Wins = 2,
                Pilots = new Pilot[]
                {
                    new Pilot() { FirstName = "Jenson", LastName = "Button", IdCountry = 5, Points = 88},
                    new Pilot() { FirstName = "Sergio", LastName = "Perez", IdCountry = 6, Points = 30}
                }
            });

            teams.Add(new F1Team()
            {
                TeamName = "Lotus",
                Wins = 3,
                Pilots = new Pilot[]
                {
                    new Pilot() { FirstName = "Kimi", LastName = "Raikkonen", IdCountry = 7, Points = 90},
                    new Pilot() { FirstName = "Romain", LastName = "Grosjean", IdCountry = 8, Points = 51}
                }
            });

            teams.Add(new F1Team()
            {
                TeamName = "Mercedes Petronas",
                Wins = 1,
                Pilots = new Pilot[]
                {
                    new Pilot() { FirstName = "Nico", LastName = "Rosberg", IdCountry = 3, Points = 63},
                    new Pilot() { FirstName = "Lewis", LastName = "Hamilton", IdCountry = 5, Points = 98}
                }
            });

            return teams;
        }

        public static void Dump(IEnumerable query)
        {
            foreach (var result in query)
            {
                Console.WriteLine(result);
            }
        }

        static void Main(string[] args)
        {
            

        }
    }
}
