using System;
using System.Collections.Generic;
using System.Text;

namespace abstraktion
{
    class Cow : Animals
    {

        public Cow()
        {
            kills = 0;
        }
        public override void dance()
        {
            Console.WriteLine("Kossan dansar!!");
        }

        public override void Move()
        {
            Console.WriteLine("Kossan går galet");
        }
    }
}
