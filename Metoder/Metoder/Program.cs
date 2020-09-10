using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] addlist= { 3, 4, 6, 7, 8 };


            Console.WriteLine(add(addlist));
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

        static int minus(int tal1, int tal2)
        {
            var sum = tal1 - tal2;

            return sum;
        }

    }
}
