using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Dolphin : Mammal
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
        public Dolphin() : this(1, 1) { }

        public Dolphin(int spd, double sd) : base(spd, "Cetacea")
        {
            swimmingDepth = sd;
        }

        public override void Say()
        {
            Console.WriteLine("I`m a dolphin, I can say - iiiiii'");
        }
        public string Swimn()
        {
            return "I can swim!";
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Swimming Depth: {swimmingDepth}");
        }
    }
}
