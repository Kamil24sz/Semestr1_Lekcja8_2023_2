using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja8_2023_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //POWTÓRKA IF

            //piszemy program który pobiera od usera liczbę od 1 do 7 i tłumaczy ją na nazwę tygodnia
            // 1 -> poniedziałek
            // 4 -> czwartek

            Console.WriteLine("Podaj numer dnia tygodnia (1-7)");
            int numer = int.Parse(Console.ReadLine());
            if(numer == 1) 
            {
                Console.WriteLine($"{numer} to jest poniedziałek");
            }
            else if(numer == 2)
            {
                Console.WriteLine($"{numer} to jest wtorek");
            }
            else if (numer == 3)
            {
                Console.WriteLine($"{numer} to jest środa");
            }
            else if (numer == 4)
            {
                Console.WriteLine($"{numer} to jest czwartek");
            }
            else if (numer == 5)
            {
                Console.WriteLine($"{numer} to jest piątek");
            }
            else if (numer == 6)
            {
                Console.WriteLine($"{numer} to jest sobota");
            }
            else if (numer == 7)
            {
                Console.WriteLine($"{numer} to jest niedziela");
            }
            else
            {
                Console.WriteLine("Podany numer tygodnia jest nieprawidłowy");
            }

            //Jak działa switch

            switch (numer)
            {
                case 1:  // to jest to samo co if(numer == 1)
                    Console.WriteLine($"{numer} to poniedziałek");
                    break;
                case 2: // to jest to samo co else if(numer == 2)
                    Console.WriteLine($"{numer} to wtorek");
                    break;
                case 3: // to jest to samo co else if(numer == 3)
                    Console.WriteLine($"{numer} to środa");
                    break;
                case 4: // to jest to samo co else if(numer == 4)
                    Console.WriteLine($"{numer} to czwartek");
                    break;
                case 5: // to jest to samo co else if(numer == 5)
                    Console.WriteLine($"{numer} to piątek");
                    break;
                case 6: // to jest to samo co else if(numer == 6)
                    Console.WriteLine($"{numer} to sobota");
                    break;
                case 7: // to jest to samo co else if(numer == 7)
                    Console.WriteLine($"{numer} to niedziela");
                    break;
                default:
                    Console.WriteLine("Podany numer tygodnia był nieprawidłowy");
                    break;
            }


            //piszemy program który pobiera od użytkownika ocenę (1-6) i tłumaczy ją na ocenę słowną
            // 6 - celujący
            // 5 - bardzo dobry - A
            // 4 - dobry - B
            // 3 - dostateczny - C
            // 2 - dopuszczający - D
            // 1 - niedostateczny - F
            Console.Clear();
            Console.WriteLine("Podaj ocenę");
            //pobranie oceny od użytkownika
            char ocena = char.Parse(Console.ReadLine());

            // int a = 1;      // 2
            // char a = '1';
            // string a = "1";  // 11

            // ZAMIENIA WSZYSTKO NA DUŻE LITERY
            ocena = char.Parse(ocena.ToString().ToUpper());

            //switch
            switch (ocena)
            {
                case '6':
                    Console.WriteLine("Celujący");
                    break;
                case 'A':  //  if (ocena == 'A' || ocena == '5')
                case '5':
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 'B':
                case '4':
                    Console.WriteLine("Dostateczny");
                    break;
                case 'C':
                case '3':
                    Console.WriteLine("Dostateczny");
                    break;
                case 'D':
                case '2':
                    Console.WriteLine("Dopuszczający");
                    break;
                case 'F':
                case '1':
                    Console.WriteLine("Niedostateczny");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa ocena");
                    break;
            }

            Console.ReadLine();
        }
    }
}
