using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dla numeru PESEL podanego jako tekst, sprawdź, czy ma on poprawną cyfrę kontrolną zgodnie z
            //algorytmem podanym na stronie
            //https://pl.wikipedia.org/wiki/PESEL#Cyfra_kontrolna_i_sprawdzanie_poprawno%C5%9Bci_numeru
            //Liczby, przez które mnożymy poszczególne cyfry numeru PESEL nazywają się wagami.
            //Utwórz tablicę, w której zapiszesz te wagi i wykorzystaj tę tablicę do sprawdzenia poprawności
            //cyfry kontrolnej.
            //cyfra kontrolna -checksum 

            string pesel1;
            string pesel2;
            string pesel3;
            
            int [] PESEL = { 5,5,0,3,0,1,0,1,1,9,3 };



        }
        public static void ValidatePESEL(int[] PESEL)
        {
            int[] numberWeight = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
            int sum = 0;
            for (int i = 0; i < PESEL.Length; i++)
            {
                sum += PESEL[i] * numberWeight[i];
            }
            int modulo = sum % 10;

            int checksum = 10 - modulo;
        }
    }
}
