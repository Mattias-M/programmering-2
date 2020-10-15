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
                        Console.WriteLine("du har köpt en bil");
                        Console.WriteLine( "Skriv 1 om du vill ha en fin bil skriv 2 om du vill ha en trågig bil.");
                        int carOr240 = Convert.ToInt32(Console.ReadLine());
                        Car c = new Car();
                        switch (carOr240)
                        {
                            case 1:
                            
                                cust._cart.Add(c._240);
                                Console.WriteLine("Du har köpt en volvo 240");
                                break;

                            case 2:
                                cust._cart.Add(c._xc40);
                                Console.WriteLine("du har köpt en volvo xc40");
                                break;
                        }
                            

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
