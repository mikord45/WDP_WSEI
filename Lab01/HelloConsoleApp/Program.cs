using System;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie");

            Console.Write("Podaj imię: ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj " + imie + " " + nazwisko + ".");
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście naazywa się {1}?", imie, nazwisko);

            Console.Write("Podaj swój wiek: ");
            int wiek = Convert.ToInt32(Console.ReadLine());

            if(wiek < 0){
                Console.WriteLine("Błędne dane!");
            }
            else if(wiek < 67)
            {
                Console.WriteLine("Do emerytury pozostało {0} lat", 67 - wiek);
            }
            else
            {
                Console.WriteLine("Jesteś emerytem");
            }

        }
    }
}
