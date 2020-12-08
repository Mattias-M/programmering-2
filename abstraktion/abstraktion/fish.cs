using System;
using System.Collections.Generic;
using System.Text;

namespace abstraktion
{
    class Fish : Animals
    {
        public override void dance()
        {
            Console.WriteLine("Fisken dansar galet");
        }

        public override void Move()
        {
            Console.WriteLine("Fisken simmar galet");
        }
    }
}
