using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Carp : Fish
    {
        double bodyLength;
        public double BodyLength
        {
            get { return bodyLength; }

            set
            {
                if (value < 1)
                    bodyLength = 1;
                else
                    bodyLength = value;
            }
        }

        public Carp() : this(1, 1, 1) { }
        public Carp(int spd, double sd, double dl) : base(spd, sd)
        {
            BodyLength = dl;
        }
        public override void Say()
        {
            Console.WriteLine("I`m a carp, I can say buuul'");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Body Length: {BodyLength}");
        }

    };
}
