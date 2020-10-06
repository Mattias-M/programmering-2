using System;
using System.Globalization;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] addlist= { 3, 4, 6, 7, 8 };

            String[] names = { "hej", "jag", "på", "dig" };


            Console.WriteLine(add(addlist));

            Console.WriteLine(back(names));
        }

        static int add(int[] addlist)
        {
            var sum = 0;

            for (int i = 0; i < addlist.Length; i++)
            {
                sum += addlist[i];
            }

            return sum;


        }

        static String  back (String[] names)
        {

            string reversedArray = "";

            for (int i = names.Length - 1; i >= 0; i--)
            {
                reversedArray += names[i];
                reversedArray += " ";
            }
            return reversedArray;

            
        }

    }
}
