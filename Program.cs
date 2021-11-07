using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz funkcję, która w zależności od przekazanych parametrów wydrukuje spersonalizowany tekst
            // jak poniżej.
            // W nawiasach kwadratowych oznaczyłem elementy, które mają być spersonalizowane:
            // [Imię Drugie_Imię Nazwisko]
            // [ul.Nazwa_ulicy Numer / numer_mieszkaniaMiasto]
            // [Szanowna Pani | Szanowny Panie | Droga Użytkowniczko | Drogi Użytkowniku]
            // Zapraszamy[Pana | Panią | Cię] serdecznie na otwarcie naszego sklepu!
            // Powitamy[Pana | Panią | Cię][kieliszkiem szampana | kubkiem gorącej czekolady].
            // [I zapraszamy do gry w bingo]
            // [do zobaczenia | czekamy na Pana | czekamy na Panią | z wyrazami szacunku]
            // Założenia:
            // -w zależności od płci i wieku wyświetlamy odpowiednie powitanie i później formy(Pan lub Pani, a
            // dla niepełnoletnich Ty i Użytkowniku lub Użytkowniczko
            //- dla niepełnoletnich czekolada, dla pełnoletnich szampan
            //- gra w bingo tylko dla seniorów(powyżej 60 lat)
            //- zakończenie – „z wyrazami szacunku” dla seniorów, pozostałe w zalezności od płci i wieku
            //- płeć powinna być przekazana jako parametr funkcji, możesz np.użyć odpowiednio liter ‘m’ i ‘k’
            //  lub liczb i założyć, że np. 1 to kobieta, 2 to mężczyzna, lub jako zmienna logiczna, np.isFemale
            //- pamiętaj, że nie każdy ma drugie imię i numer mieszkania.
            string name = Console.ReadLine();
            string secondName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string street = Console.ReadLine();
            int homeNumber = Convert.ToInt32(Console.ReadLine());
            int apartamentNumber = Convert.ToInt32(Console.ReadLine());
            string city = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            int sex = Convert.ToInt32(Console.ReadLine());

        }
        public static void FullName(string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName}");
        }
        public static void FullName(string name, string secondName, string lastName)
        {
            Console.WriteLine($"{name} {secondName} {lastName}");
        }
        public static void Adress (string street, int homeNumber, string city)
        {
            Console.WriteLine($"ul.{street} {homeNumber}, {city}");
        }
        public static void Adress(string street, int homeNumber, int apartamentNumber, string city)
        {
            Console.WriteLine($"ul.{street} {homeNumber}/{apartamentNumber}, {city}");
        }
        //public static bool IsFemale(int x)
        //{
        //    if (x==1)
        //    {
        //        return true;
        //    }
        //    else if (x == 2)
        //    {
        //        return false;
        //    }
           
        //}
        public static void WelcomeMessage (int age, int sex)
        {
            FullName();
        
        }
    }
}
