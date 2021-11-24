using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnus ja salasona
            //kui sisetatud kasutajatunnus on "admin" ja sisestatud salasona on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul konsoolis kuvatakse "Vale kasutajatunnus voi salasona. Proovi uuesti."

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasona:");
            string userPassword = Console.ReadLine();

            //AND voi OR

            //"admin" AND "admin1234" --> true
            //"admin" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            //"admin1" AND "admin123" --> false


            if(userName == "admin" && userPassword == "admin1234")
                {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus voi salasona. Proovi uuesti.");
            }

        }
    }
}
