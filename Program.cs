using System;
using System.Linq;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dla podanego ciągu znaków oznaczającego hasło, sprawdź, czy spełnia on następujące warunki
            //złożoności hasła:

            //• długość co najmniej 6 znaków
            //• występują co najmniej jedna duża i jedna mała litera
            //• występuje co najmniej jedna cyfra
            //• występuje co najmniej jeden znak specjalny spośród następujących: &*$#

            Console.WriteLine("Wpisz hasło:");
            string password = Console.ReadLine();
            int passwordLength = password.Length;
            PasswordComplexity(password);

        }
        public static void PasswordComplexity(string password)
        {
            int passwordLength = password.Length;
            if (passwordLength < 6)
            {
                Console.WriteLine("Podane hasło jest za krótkie (min. 6 znaków).");
            }
            if (!(password.Any(char.IsUpper) && password.Any(char.IsLower)))
            {
                Console.WriteLine("Hasło musi zawierać conajmniej jedną wielką i jedną małą literę.");
            }
            if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Hasło musi zawierać conajmniej jedną cyfrę.");
            }
            int sum = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == '&' || password[i] == '*' || password[i] == '$' || password[i] == '#')
                {
                    sum++;
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("Hasło musi zawierać conajmniej jeden znak specjalny (&*$#).");
            }



        }
    }
}
