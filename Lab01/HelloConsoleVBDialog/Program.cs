using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HelloConsoleVBDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            Interaction.MsgBox("Program na powitanie!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Aplikacja Visual Basic");

            string imie = Interaction.InputBox("Podaj imię: ", "Podawanie imienia");
            if (imie == "")
            {
                Console.WriteLine("Koniec");
                Console.ReadKey();
                return;
            }
            string nazwisko = Interaction.InputBox("Podaj nazwisko: ", "Podawanie nazwiska");
            if (nazwisko == "")
            {
                Console.WriteLine("Koniec");
                Console.ReadKey();
                return;
            }

            Interaction.MsgBox($"Witaj {imie} {nazwisko}!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Witaj");

            string wiekString = Interaction.InputBox("Podaj wiek: ", "Podawanie wieku");
            if (wiekString == "")
            {
                Console.WriteLine("Koniec");
                Console.ReadKey();
                return;
            }
            int wiek = Convert.ToInt32(wiekString);


            if (wiek < 0)
            {
                Interaction.MsgBox("Błędne dane!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Wiek");
            }
            else if (wiek < 67)
            {
                Interaction.MsgBox($"Do emerytury pozostało {67 - wiek} lat", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Wiek");
            }
            else
            {
                Interaction.MsgBox("Jesteś emerytem", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Wiek");
            }
            Console.ReadKey();
        }
    }
}
