using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Frog : Amphibia
    {
        double jumpRange;

        public double JumpRange
        {
            get
            {
                return jumpRange;
            }
            set
            {
                if (value < 1)
                    jumpRange = 1;
                else
                    jumpRange = value;
            }
        }

        public Frog() : this(1, 1) { }

        public Frog(int spd, double jp) : base(spd, "Tailless")
        {
            JumpRange = jp;
        }

        public override void Say()
        {
            Console.WriteLine("I`m frog, I can say kva-kva");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Wingspan: {jumpRange}");
        }

    };
}
