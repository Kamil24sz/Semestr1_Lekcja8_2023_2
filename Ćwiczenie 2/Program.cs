using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisz program „Konfigurator PC”, w którym skompletujesz wymagane podzespoły
            // każdego komputera stacjonarnego takie jak: procesor, płyta główna, pamięć RAM,
            // karta graficzna, dysk twardy, zasilacz oraz obudowa.
            decimal koszyk = 0m;
            string procesor = "";
            string płyta = "";

            Console.WriteLine("Witaj w konfiguratorze PC");
            // jaki procesor wybierasz?
            Console.WriteLine("Jaki procesor wybierasz?");
            Console.WriteLine("1.AMD Ryzen 5 5500 - 500zł");
            Console.WriteLine("2.Intel Core i5-12400F - 1000zł");
            Console.WriteLine("3.Intel Core i5-10400F - 501zł");

            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    koszyk = koszyk + 500;
                    procesor = "AMD Ryzen 5 5500";
                    break;
                case 2:
                    koszyk = koszyk + 1000;
                    procesor = "Intel Core i5-12400F";
                    break;
                case 3:
                    koszyk = koszyk + 501;
                    procesor = "Intel Core i5-10400F";
                    break;
            }
            Console.Clear();

            Console.WriteLine("Jaką płytę główną wybierasz?");
            Console.WriteLine("1.Gigabyte B660M DS3H DDR4 - 519zł");
            Console.WriteLine("2.Asus PRIME Z690-P D4 - 849zł");
            Console.WriteLine("3.Asus TUF GAMING Z690-PLUS D4 - 1049zł");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    koszyk = koszyk + 519;
                    płyta = "Gigabyte B660M DS3H DDR4";
                    break;
                case 2:
                    koszyk = koszyk + 849;
                    płyta = "Asus PRIME Z690-P D4";
                    break;
                case 3:
                    koszyk = koszyk + 1049;
                    płyta = "Asus TUF GAMING Z690-PLUS D4";
                    break;
            }
            Console.Clear();


            // jaką płytę główną wybierasz?

            //Podsumowanie
            Console.WriteLine("Zawartość koszyka:");
            Console.WriteLine($"Procesor: {procesor}");
            Console.WriteLine($"Płyta: {płyta}");

            Console.WriteLine();
            Console.WriteLine($"Wartość koszyka: {koszyk}zł");

            Console.ReadLine();
        }
    }
}
