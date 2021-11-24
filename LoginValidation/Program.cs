using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnus ja salasona
            //kui sisetatud kasutajatunnus on "admin" ja sisestatud salasona on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul konsoolis kuvatakse "Vale kasutajatunnus voi salasona. Proovi uuesti."
            //kasutajal on kolm katset

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Sisesta parool:");
                string userPassword = Convert.ToString(Console.ReadLine());

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else if (i == 2)
                {
                    Console.WriteLine($"Vale, konto on blokeeritud!");
                    break;

                }
                else
                {
                    Console.WriteLine($"Vale kasutajatunnus voi salasona. Proovi uuesti.");
                }
            }
        }
    }
}
