using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Amphibia : Animal
    {
        public string Detachment { get; set; }

        public Amphibia() : this(1, "No detachment") { }


        public Amphibia(int spd, string d) : base("Amphibia", spd)
        {
            Detachment = d;
        }


        public override void Say()
        {
            Console.WriteLine($"I`m a {Species}, I can say hhh-hh");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Detachment: {Detachment}");
        }
    };
}
