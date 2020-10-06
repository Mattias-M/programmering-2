using System;

namespace Kund
{
    class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();

            Console.WriteLine("skriv in ditt namn");

            cust._name = Console.ReadLine();

            Console.WriteLine(cust._name);

            product pru = new product();

            

            

            Boolean t = true;

            while (t)
            {
                Console.WriteLine("Skriv 1 om du vill köpa en bil. Skriv 2 om du vill köpa en katt. Om du är klar skriv 3");
                int customerChoice = Convert.ToInt32(Console.ReadLine());
                switch (customerChoice)
                {
                    case 1:
                        Console.WriteLine("du har köpt en ´bil");

                        cust._cart.Add(pru._car);

                        break;

                    case 2:
                        Console.WriteLine("du har köpt en katt");

                        cust._cart.Add(pru._cat);
                       

                        break;

                    case 3:

                        t = false;
                        break;

                    default:

                        break;


                }
            }
            
            Console.WriteLine(cust._name + " har köpt");

            foreach (var i in cust._cart)
            {
                Console.WriteLine(i);
            }
        }
    }
}
