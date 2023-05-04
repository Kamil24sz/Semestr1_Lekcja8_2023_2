using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bestiariusz Wiedźmina

            // Stworzyć aplikację konsolową, która poprosi o podanie nazwy potwora ze świata
            // wiedźmina i wyświetli krótki opis bestii. Opis można wymyślić samodzielnie albo
            // pobrać z internetu

            // użytkownik podaje nazwę potwora gryf - > opis gryfa 

            Console.WriteLine("Witaj Łowco, na jaką poczwarę polujesz?");
            string potwor = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"{potwor} mówisz... niech pomyślę");

            // 3 sekundy przerwy
            Thread.Sleep(3000);
            Console.Clear();

            switch (potwor.ToLower())
            {
                case "gryf":
                    Console.WriteLine("Gryf to właściwie uzbrojona w skrzydła wersja lwa o szponach orła. Czasami nazywa");
                    Console.WriteLine("się go Inogiem, lecz bez względu na miano to poważny przeciwnik. Chcąc rzucić mu");
                    Console.WriteLine("wyzwanie, kiedyś wystarczyło udać się wysoko w góry, gdzie gryfy zakładają swoje gniazda.");
                    break;
                case "harpia":
                    Console.WriteLine("Harpie to stwory o magicznym rodowodzie. Mają głowy i tułów kobiet, jak też");
                    Console.WriteLine("wzrostem dorównują człowiekowi, lecz na tym lista podobieństw względem rodzaju");
                    Console.WriteLine("ludzkiego wyczerpuje się.");
                    break;
                case "krabopająk":
                    Console.WriteLine("Powinniśmy wiedzieć, że elfy nie przez przypadek unikają w lasach tego osobnika,");
                    Console.WriteLine("bowiem jego szczypce, zębata paszcza oraz kryjący duże ilości trucizny gruczoł");
                    Console.WriteLine("jadowy czynią z krabopająka wymagającego przeciwnika.");
                    break;
                case "dżinn":
                    Console.WriteLine("Dżinny to stworzenia, które Geralt z Rivii oraz Yennefer z Vengerbergu");
                    Console.WriteLine("wspominają z pewną nutką nostalgii. To właśnie próba złapania jednego z nich");
                    Console.WriteLine("stanowiła początek tej znajomości, jak też zakończyła się zniszczeniem połowy");
                    Console.WriteLine("redańskiego miasta Rinde.");
                    break;
                case "gargulec":
                    Console.WriteLine("Gargulce to kolejni starzy znajomi, którzy stawali wcześniej na naszej drodze. Ich");
                    Console.WriteLine("rodowód jest ściśle powiązany z magią, bowiem zaklęcie ożywia te wyrzeźbione z");
                    Console.WriteLine("granitu lub marmuru bestie.");
                    break;
                case "goliat":
                    Console.WriteLine("Opowieść o Dawidzie i Goliacie zna na pewno większość z was, ale");
                    Console.WriteLine("opisywany tutaj niegdyś musiał być zwykłym człowiekiem. Zdradził");
                    Console.WriteLine("jednak rycerskie śluby Toussaint i za karę został przemieniony przez Panią Jeziora");
                    Console.WriteLine("w to, czym jest dzisiaj.");
                    break;
                default:
                    Console.WriteLine("Niestety, takiej gadziny to ja nie znam.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
