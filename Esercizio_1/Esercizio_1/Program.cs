using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // commento 

            DateTime today = DateTime.Now;
            Console.WriteLine("Data:{0}", today);
            Console.WriteLine("Giorno:{0:D}", today);
            Console.WriteLine("Ore:{0:T}", today);
            Console.WriteLine("Mese:{0:M}", today);

            Console.WriteLine("Inserire password: ");
            string password = string.Empty;
            //password = Console.ReadLine();

            ConsoleKey key;

            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    password += keyInfo.KeyChar;
                }

            } while (key != ConsoleKey.Enter);

            if (password == "ciao")
            {
                char choosen;
                do
                {
                    int number1 = 0, number2 = 0;
                    Console.Clear();
                    // Menù
                    Console.WriteLine("Benvenuto nella calcolatrice");
                    Console.WriteLine("1. Addizione");
                    Console.WriteLine("2. Sottrazione");
                    Console.WriteLine("3. Moltiplicazione");
                    Console.WriteLine("4. Divisione");
                    Console.WriteLine("5. Esci");
                    choosen = Console.ReadKey().KeyChar;
                    Console.WriteLine("");

                    if (choosen != '5')
                    {
                        Console.Write("Inserisci il primo numero: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserisci il secondo numero: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                    }

                    //calcolo
                    int result;
                    switch (choosen)
                    {
                        case '1': // Somma
                            {
                                result = number1 + number2;
                                Console.WriteLine(number1 + " + " + number2 + " = " + result);
                                break;
                            }

                        case '2': // Sottrazione
                            {
                                result = number1 - number2;
                                Console.WriteLine(number1 + " - " + number2 + " = " + result);
                                break;
                            }

                        case '3': // Moltiplicazione
                            {
                                result = number1 * number2;
                                Console.WriteLine(number1 + " * " + number2 + " = " + result);
                                break;
                            }

                        case '4': // Divisione
                            {
                                if (number2 != 0)
                                {
                                    result = number1 / number2;
                                    Console.WriteLine(number1 + " / " + number2 + " = " + result);
                                }
                                break;
                            }

                        case '5': // Uscita
                            break;

                        default: // scelta non programmata
                            {
                                Console.WriteLine("Opzione errata");
                                break;
                            }
                    } Console.ReadLine();
                } while (choosen != '5');

            } 
            else
            {
                Console.WriteLine("Password Errata");
            }

            Console.ReadKey();

        }
    }
}
