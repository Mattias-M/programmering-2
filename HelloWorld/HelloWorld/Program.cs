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
                    case 17:
                        Console.WriteLine("du är 17, haha ingen suns för di");
                        break;

                    case 18:
                        Console.WriteLine("Du är 18, Grattis!");
                        break;
                    default:
                        Console.WriteLine("jag bryr mig inte hur gammal du är");
                        break;


                }

                Console.WriteLine("Din ålder är: " + age);
               
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
