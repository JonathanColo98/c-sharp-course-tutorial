﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            IList<F1Team> teams = createListTeams();

            // query di selezione classica
            var query = from team in teams select team;
            //Dump(query);
            //Console.ReadKey();

            // la clausola from specifica il tipo da ricavare
            var query2 = from F1Team team in teams select team;
            //Dump(query2);

            // nome di tutte le squadre di F1
            var query3 = from team in teams select team.TeamName;
            //Dump(query3);

            // solita query3 con lambda expression
            var query3A = teams.Select(team => team.TeamName);
            //Dump(query3A);

            // subquery per accedere ai piloti, array interno della classe Team
            var query4 = from team in teams from pilot in team.Pilots select pilot.LastName;
            //Dump(query4);

            // subquery -> team che hanno almeno un pilota e con cognome più lungo di 7 caratteri
            var query5 = from team in teams
                         from pilot in team.Pilots
                         where pilot.LastName.Length > 7
                         where team.Pilots.Length > 1
                         select pilot.LastName;

            //Dump(query5);

            // let memorizza valore della prop. wins di ogni team
            // ordina i team in base alle vittorie e filtra i team con più di 3 vittorie
            var query6 = from team in teams
                         let wins = team.Wins
                         orderby wins descending
                         where wins > 3
                         select team.TeamName + ": " + wins;

            //Dump(query6);

            // let contiene la collezione di piloti di ogni team ma solo con quelli con 
            // punteggio superiore a 80 e stampa i nomi dei team con un pilota del genere
            var query7 = from team in teams
                         let wins = team.Wins
                         let pilotsConst = team.Pilots
                         from pilot in pilotsConst
                         where pilot.Points > 80
                         orderby wins descending
                         select team.TeamName + " wins: " + wins + ", leader " + pilot.LastName + " with " + pilot.Points + " points";

            //Dump(query7);

            // nomi di tutti i team in maiuscolo 
            var query8 = from team in teams
                         select team.TeamName.ToUpper();

            //Dump(query8);

            // query8 con lambda expression
            var query8A = teams.Select(team => team.TeamName.ToUpper());
            //Dump(query8A);

            // Tuple<string, int> formate da nome e vittorie della squadra
            var query9 = from team in teams
                         select new Tuple<string, int>(team.TeamName, team.Wins);
            //Dump(query9);

            // proprietà tuple ricavate
            /*
            foreach (Tuple<string,int> tupla in query9)
            {
                Console.WriteLine("{0}: {1}", tupla.Item1, tupla.Item2);
            }
            Console.ReadKey();
            */

            // istanziare oggetti al volo con proprietà e metodi pubblici senza costruttore
            var query10 = from team in teams
                          select new F1Team { TeamName = team.TeamName, Wins = team.Wins };
            //Dump(query10);

            // restituire tipi anonimi con clausola select 
            var query11 = from team in teams
                          select new { team.TeamName, team.Wins };
            //Dump(query11);

            // solita query 11 ma con lambda expressions
            var query11A = teams.Select(team => new { team.TeamName, team.Wins });
            //Dump(query11A);

            // per ogni team si ricava la collezione di piloti, filtrata per ottenere 
            // oggetti con lastName di lunghezza almeno pari a 8 caratteri.
            // La seconda espressione crea una enumerazione di stringhe contenente i cognomi dei piloti
            var query12 = teams.SelectMany(team => team.Pilots.Where(pilot => pilot.LastName.Length > 7), (team, pilot) => pilot.LastName);
            //Dump(query12);

            // team della F1 che hanno ottenuto almeno una vittoria e con nome che inizia per m
            var query13 = from team in teams
                          where team.Wins > 1 &&
                          team.TeamName.ToLower().StartsWith("m")
                          select team;

            //Dump(query13);

            // query13 con lambda expressions
            var query13A = teams.Where(team => team.Wins > 1 && team.TeamName.ToLower().StartsWith("m"));
            //Dump(query13A);

            // solita query 13 ma con elementi di indice pari della sequenza
            var query13B = teams.Where((team, index) => team.Wins > 1 &&
                                                       team.TeamName.ToLower().StartsWith("m") &&
                                                       index % 2 == 0);
            //Dump(query13B);

            // ordina i nomi dei team in maniera crescente
            var query14 = from team in teams
                          orderby team.TeamName
                          select team.TeamName;

            //Dump(query14);

            // ottieni i team con almeno 3 vittorie, ordinandoli per nome
            var query15 = from team in teams
                          where team.Wins >= 3
                          orderby team.TeamName
                          select team.TeamName;

            //Dump(query15);

            // Piloti raggruppati per squadra
            var query16 = from team in teams
                          from pilot in team.Pilots
                          group pilot by team;

            /*
            foreach (IGrouping<F1Team, Pilot> group in query16)
            {
                F1Team team = group.Key;
                Console.WriteLine(team);
                foreach (Pilot pilot in group)
                {
                    Console.WriteLine(" - {0} {1} ", pilot.FirstName, pilot.LastName);
                }
            }
            Console.ReadKey();
            */

            // Ricavo i piloti con almeno due vittorie. Da tale risultato memorizzato in topTeamPilots,
            // viene creata una nuova espressione che filtra i piloti con almeno 50 punti, li ordina in 
            // maniera decrescente e infine crea una proiezione di cognome, nome e punteggio.
            var query17 = from team in teams
                          where team.Wins > 2
                          select team.Pilots
                          into topTeamPilots
                          from pilot in topTeamPilots
                          where pilot.Points > 50
                          orderby pilot.Points descending
                          select pilot.LastName + " " + pilot.FirstName + ": " + pilot.Points;

            //Dump(query17);

            // ricavare ogni pilota con la relativa nazione di appartenenza 
            var query18 = from team in teams
                          from pilot in team.Pilots
                          join country in Country.All on pilot.IdCountry equals country.IdCountry
                          select new { pilot.LastName, CountryName = country.Name };

            //Dump(query18);

            // solita query18 con lambda expression
            var query18A = teams.SelectMany(team => team.Pilots)
                                 .Join(Country.All,
                                       pilot => pilot.IdCountry,
                                       country => country.IdCountry,
                                       (pilot, country) => new { pilot.LastName, country.Name } 
                                       );
            
            //Dump(query18A);
            // si ricavano i piloti che appartengono nello stesso paese di provenienza 
            var pilots = from team in teams
                         from pilot in team.Pilots
                         select pilot;

            var query19 = from country in Country.All
                          join pilot in pilots on country.IdCountry equals pilot.IdCountry
                          into pilotSxCountry
                          select new { CountryName = country.Name, Pilots = pilotSxCountry };
            /* Si stampano i risultati ricavati dalla query 19
            foreach (var group in query19)
            {
                Console.WriteLine(group.CountryName);
                foreach (Pilot pilot in group.Pilots)
                {
                    Console.WriteLine(" - {0} {1} ", pilot.FirstName, pilot.LastName);
                }
            }
            Console.ReadKey();
            */

            IEnumerable<Pilot> enumerablePilots = teams.SelectMany(team => team.Pilots);

            var query20 = Country.All.GroupJoin(pilots, // collezione interna
                                                country => country.IdCountry, // chiave esterna
                                                pilot => pilot.IdCountry, // chiave esterna
                                                (country, pilot) => new { country.Name, pilot});

            //Dump(query20);

            // operatore Distincts
            int[] array1 = { 1, 2, 3, 4, 5, 3, 4, 5 };
            int[] array2 = { 1, 2, 3, 4, 6, 7, 8 };
            var queryDistinct = array1.Distinct();
            //Dump(queryDistinct);

            var pilotsDistinct = (from team in teams
                                  from pilot in team.Pilots
                                  select pilot.FirstName).Distinct();

            //Dump(pilotsDistinct);

            // Insieme unione
            var union = array1.Union(array2);
            //Dump(union);

            // Insieme Differenza
            var except = array1.Except(array2);
            //Dump(except);

            // Insieme intersezione
            var intersect = array1.Intersect(array2);
            //Dump(intersect);

            // Somma di elementi a 2 a 2
            var zip = array1.Zip(array2, (firstArg, secArg) => firstArg + secArg);
            //Dump(zip);

            int[] array = { 1, 2, 3, 4 };
            bool boolean = array.Contains(1);
            /*
            Console.WriteLine(boolean);
            Console.ReadKey();
            */

            // All = verifica una condizione e restituisce un booleano
            bool b = array.All(element => element > 0);
            /*
            Console.WriteLine(boolean);
            Console.ReadKey();
            */

            // mostrare teams con piloti che hanno totalizzato un punteggio maggiore di zero 
            var query21 = teams.Where(team => team.Pilots.All(pilot => pilot.Points > 0));
            //Dump(query21);

            // Any = stesso di All ma verifica che ALMENO un elemento soddisfi la condizione
            var query22 = teams.Where(team => team.Pilots.Any(pilot => pilot.Points > 100));
            //Dump(query22);

            int[] arrayIntegers = { 1, 1, 2, 3, 1, 2, 1, 3 };

            // Skip = salta un certo numeri di elementi specificato e restituisce una sequenza
            // di elementi costituita da quelli rimanenti
            var query23 = arrayIntegers.Skip(4);
            //Dump(query23);

            // SkipWhile = salta degli elementi fino a quando una determinata condizione rimane vera
            // e restituisce il resto della sequenza

            var query24 = arrayIntegers.SkipWhile(number => number < 3);
            //Dump(query24);

            // Take = restituisce i primi n elementi di una sequenza
            var query25 = arrayIntegers.Take(4);
            //Dump(query25);

            // TakeWhile = restituisce i primi elementi che soddisfano una condizione e salta il resto
            var query26 = arrayIntegers.TakeWhile(number => number < 3);
            //Dump(query26);


            F1Team teamF1 = teams.ElementAt(0);

            int countTeam = teams.Count(team => team.Wins > 0);
            /*
            Console.WriteLine(countTeam.ToString());
            Console.ReadKey();
            */

            int[] arrayToSum = { 1, 2, 3, 4, 5 };
            int sum = arrayToSum.Sum();
            /*
            Console.WriteLine(sum.ToString());
            Console.ReadKey();
            */

            // calcolare il punteggio totale della scuderia attraverso il punteggio dei corrispettivi piloti
            var query27 = from team in teams
                          let points = team.Pilots.Sum(pilot => pilot.Points)
                          orderby points descending
                          select new { team.TeamName, points };

            //Dump(query27);

            var queryAverage = from team in teams
                               select new { team.TeamName,
                                            AveragePoints = team.Pilots.Average(pilot => pilot.Points) };

            //Dump(queryAverage);

            int maxValuePoints = (from team in teams
                                  from pilot in team.Pilots
                                  select pilot).Max(pilot => pilot.Points);

            int minValuePoints = (from team in teams
                                  from pilot in team.Pilots
                                  select pilot).Min(pilot => pilot.Points);
            /*
            Console.WriteLine("Max: {0}", maxValuePoints);
            Console.WriteLine("Min: {0}", minValuePoints);
            Console.ReadKey();
            */

            string phrase = "senatus populus que romanus";
            var acronym = phrase.Split(' ').Aggregate("", (result, word) => result + word.ToUpper()[0] + " . ");
            //Console.WriteLine(acronym);
            //Console.ReadKey();

            var queryAggregate = from team in teams
                                 select new { Points = team.Pilots.Aggregate(0, (total, pilot) => total + pilot.Points) };

            //Dump(queryAggregate);

            IList<F1Team> listResult = teams.Where(team => team.TeamName.ToUpper().StartsWith("M")).ToList();
            /*
            foreach (F1Team team in listResult)
            {
                Console.WriteLine(team.ToString());
            }
            Console.ReadKey();
            */

            Pilot[] arrayPilots = teams.SelectMany(team => team.Pilots).ToArray();
            /*
            foreach (Pilot pilot in arrayPilots)
            {
                Console.WriteLine(pilot.FirstName);
            }
            Console.ReadKey();
            */

            Dictionary<string, Pilot[]> dictionary = (from team in teams
                                                      where team.Wins > 0
                                                      select team)
                                                      .ToDictionary(team => team.TeamName, team => team.Pilots);
            /*
            foreach (string key in dictionary.Keys)
            {
                Console.WriteLine(key);
                foreach (Pilot pilot in dictionary[key])
                {
                    Console.WriteLine("- {0} : {1}", pilot.LastName, pilot.Points);
                }
            }
            Console.ReadKey();
            */

            // OfType = filtra la sequenza restituendo gli elementi del tipo specificato
            List<object> list = new List<object>() { "a", 1, "b", 2, "c"};
            var strings = list.OfType<string>();

            List<string> listString = new List<string>() { "a", "b", "c"};
            var objects = listString.Cast<object>();

            var months = Enumerable.Range(1, 12)
                                   .Select(numberMonth => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(numberMonth))
                                   .ToList();
            /*
            months.ForEach(Console.WriteLine);
            Console.ReadKey();
            */

            int[] arrayReapeted = Enumerable.Repeat<int>(1, 10).ToArray();

            IEnumerable<Pilot> pilotsEmpty = Enumerable.Empty<Pilot>();

            /*
            foreach (var pilot in pilots.DefaultIfEmpty(new Pilot() { LastName = "Sconosciuto"}))
            {
                Console.WriteLine(pilot.LastName);
            }
            Console.ReadKey();
            */

            var s1 = Enumerable.Range(1, 5);
            var s2 = Enumerable.Range(6, 5);
            var concat = s1.Concat(s2);
            /*
            foreach (var elem in concat)
            {
                Console.WriteLine(elem.ToString());
            }
            Console.ReadKey();
            */

            bool equalSequence = s1.SequenceEqual(s2);
            Console.WriteLine(equalSequence.ToString());
            Console.ReadKey();
        }
    }
}
