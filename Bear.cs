using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Bear : Mammal
    {
        double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 1)
                    weight = 1;
                else
                    weight = value;
            }
        }

        public Bear() : this(1, 1) { }

        public Bear(int spd, double w) : base(spd, "Ursidae")
        {
            Weight = w;
        }

        public override void Say()
        {
            Console.WriteLine("I`m bear, I can say ggrr'");
        }
        public string Run()
        {
            return "I can run!";
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Weight: {Weight}");
        }
    };
}
