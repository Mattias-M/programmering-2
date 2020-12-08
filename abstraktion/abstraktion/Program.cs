using System;
using System.Collections.Generic;

namespace abstraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animals> animals = new List<Animals>();

            var fish = new Fish();
            fish.kills = 50;

            var cow = new Cow();

            animals.Add(fish);
            animals.Add(cow);

            foreach (var Animals in animals)
            {
                Animals.dance();
                Animals.Move();
            }
        }
    }
}
