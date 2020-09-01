using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            
                Console.WriteLine("Skriv ditt namn");

                string namn = Console.ReadLine();

                Console.WriteLine("Ditt namn är: " + namn);

                Console.WriteLine("Din ålder:");

                int age = Convert.ToInt32(Console.ReadLine());

                switch (age)
                {
                    case >18:
                        Console.WriteLine("du är under 18");

                    case Z

                }

                Console.WriteLine("Your age is: " + age);
               
                for(int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Lever du skriv ja, om du är död skriv nej");
                }
                Console.WriteLine("Lever du skriv ja, om du är död skriv nej");

                bool alive = true;
                var pulscheck = Console.ReadLine();

                if (pulscheck == "ja")
                {
                    alive = true;

                }
                else
                {
                    alive = false;
                }
                if (alive == true)
                {
                    Console.WriteLine("Ditt namn är " + namn);
                    Console.WriteLine("Din ålder är " + age);
                    Console.WriteLine("Du lever fortfarande");
                }
                else
                {
                    Console.WriteLine("Ditt namn är" + namn);
                    Console.WriteLine("Din ålder är" + age);
                    Console.WriteLine("Du är DÖD");
                    break;
                }
            }

        }
    }
}
