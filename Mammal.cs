using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Mammal : Animal
    {
        protected string Subspecies { get; set; }

        public Mammal() : this(1, "No Subspecies") { }
        public Mammal(int spd, string ss) : base("Mammal", spd)
        {
            Subspecies = ss;
        }
        public override void Say()
        {
            Console.WriteLine($"I`m a {Species}, I can say something'");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Subspecies: {Subspecies}");
        }

    }
}
