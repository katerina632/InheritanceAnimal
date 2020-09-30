using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Fish : Animal
    {
        double swimmingDepth;
        protected double SwimmingDepth
        {
            get { return swimmingDepth; }

            set
            {
                if (value < 1)
                    swimmingDepth = 1;
                else
                    swimmingDepth = value;
            }
        }

        public Fish() : this(1, 1) { }
        public Fish(int spd, double sd) : base("Fish", spd)
        {
            SwimmingDepth = sd;
        }


        public override void Say()
        {
            Console.WriteLine($"I`m a {Species}, I can say bul'-bul'");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Swimming depth: {SwimmingDepth}");
        }
    };
}
