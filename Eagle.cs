using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Eagle : Bird
    {
        double wingspan;
        public double Wingspan
        {
            get
            {
                return wingspan;
            }
            set
            {
                if (value < 1)
                    wingspan = 1;
                else
                    wingspan = value;
            }
        }
        public Eagle() : this(1, 1, 1) { }

        public Eagle(int spd, double fa, double w) : base(spd, fa)
        {
            Wingspan = w;
        }

        public override void Say()
        {
            Console.WriteLine("I`m an eagle, I can say - eea-eea-ea ");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Wingspan: {wingspan}");
        }
    };
}
