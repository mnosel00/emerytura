using System;

namespace ConsoleAppInterakcja
{
    const int WIEK_EMERYTALNY = 65;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");
            Console.Write("Podaj imię: "); //cw tab tab (od razu leci )
           string imie = Console.ReadLine(); // zapisanie imienia do zmiennej
          

            Console.WriteLine("Podaj nazwisko"); //cw tab tab (od razu leci )
            string nazwisko = Console.ReadLine(); //zapisanie nazwiska

            Console.WriteLine("Witaj "+ imie +""+ nazwisko + "!");
            Console.WriteLine($"Witaj {imie} {nazwisko} !"); //szablon napisu
            Console.WriteLine(string.Format("Witaj {0} {1}!",nazwisko,imie));


            //zabawa z liczba
            Console.Write("Podaj Wiek: ");
            //string napis = Console.ReadLine();
            int wiek = int.Parse(Console.ReadLine());

            if(wiek >= WIEK_EMERYTALNY)
            {
                Console.WriteLine("Jesteś emerytem");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało ci {WIEK_EMERYTALNY - wiek} lat.");
            }




        }
    }
}
