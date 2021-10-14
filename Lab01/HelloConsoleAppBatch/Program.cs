using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleAppBatch
{
    class Program
    {
        private static object daneArr;

        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie");

            string imie = "";
            string nazwisko = "";
            string wiek = "";

            try
            {
                imie = args[0];
                nazwisko = args[1];
                wiek = args[2];
            }
            catch
            {
                string[] nazwyDanychWejsciowych = new string[] { "imie", "nazwisko", "wiek" };
                string[] daneWejsciowe = new string[] { imie, nazwisko, wiek };
                List<string> listWejsciowa = new List<string>(daneWejsciowe);
                List<string> listaWyjsciowa = new List<string>();
                int indexListy = 0;
                listWejsciowa.ForEach(delegate (string current)
                {
                    if (current == "")
                    {
                        listaWyjsciowa.Add(PodajDane(nazwyDanychWejsciowych[indexListy]));
                    }
                    else
                    {
                        listaWyjsciowa.Add(current);
                    }
                    indexListy++;
                });
                imie = listaWyjsciowa[0];
                nazwisko = listaWyjsciowa[1];
                wiek = listaWyjsciowa[2];
            }

            string imieINazwisko = $"{imie} {nazwisko}";

            var listMethods = new List<Func<string, string>>();
            listMethods.Add((string variable) => Program.Powitanie(variable));
            listMethods.Add((string variable) => Program.IleDoEmerytury(variable));

            string[] tabDane = new string[] { imieINazwisko, wiek };
            List<string> list = new List<string>(tabDane);
            int index = 0;
            list.ForEach(delegate (string current)
            {
                string toDisplay = listMethods[index](current);
                Console.WriteLine(toDisplay);
                index++;
            });
            Console.ReadKey();
        }

        static string PodajDane(string coPodac)
        {
            Console.Write($"Podaj {coPodac}:");
            string wczytane = Console.ReadLine();
            return (wczytane);
        }

        static string Powitanie(string imieINazwisko)
        {
            return (($"Witaj {imieINazwisko}"));
        }
        static string IleDoEmerytury(string wiekText)
        {
            int wiek = Convert.ToInt32(wiekText);

            if (wiek < 0)
            {
                return ("Błędne dane!");
            }
            else if (wiek < 67)
            {
                return ($"Do emerytury pozostało {67 - wiek} lat");
            }
            else
            {
                return ("Jesteś emerytem");
            }
        }
    }
}
