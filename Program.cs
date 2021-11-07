using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz funkcję, która „zakoduje” podany napis w „l33t speak”, tzn. zamieni odpowiednio litery
            //(zarówno małe jak i wielkie):
            //A = 4
            //E = 3
            //I = 1
            //O = 0(zero)
            //S = $
            //Przykładowo: dla napisu „Asia” otrzymamy „4$14”.
            //Napisz również funkcję, która „odkoduje” napis(czyli z „4$14” otrzymamy „asia”).
            //Czy potrafisz w swoim rozwiązaniu wykorzystać dwie poniższe tablice ?
            //char[] leetLetters = { '4', '3', '1', '0', '$'};
            //char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
            string l33tText = "L33t h4k3r!";
            string naturalText = "Hakujemy!";
            FromL33tToNatural(l33tText);
            FromNaturalToL33t(naturalText);

        }
        public static void FromL33tToNatural(string l33tText)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            string newText = l33tText;
            for (int i = 0; i < leetLetters.Length; i++)
            {
                newText = newText.Replace(leetLetters[i], naturalLetters[i]);
            }
            Console.WriteLine(newText);

        }
        public static void FromNaturalToL33t(string naturalText)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            string newText = naturalText;
            for (int i = 0; i < leetLetters.Length; i++)
            {
                newText = newText.Replace(naturalLetters[i], leetLetters[i]);
            }
            Console.WriteLine(newText);
        }

    }
}
