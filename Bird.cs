using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Bird : Animal
    {
        double flightAltitude;
        public double FlightAltitude
        {
            get
            {
                return flightAltitude;
            }
            set
            {
                if (value < 1)
                    flightAltitude = 1;
                else
                    flightAltitude = value;
            }
        }

        public Bird() : this(1, 1) { }

        public Bird(int spd, double fa) : base("Bird", spd)
        {
            FlightAltitude = fa;
        }


        public override void Say()
        {
            Console.WriteLine($"I`m a {Species}, I can say twit-twit");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Flight Altitude: {FlightAltitude}");
        }
    };
}
