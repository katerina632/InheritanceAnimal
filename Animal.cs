using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    abstract class Animal
    {
        protected string Species { get; set; }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 1)
                    speed = 1;
                else
                    speed = value;
            }
        }

        public Animal() : this("No species", 1) { }

        public Animal(string sp, int spd)
        {
            Species = sp;
            Speed = spd;
        }

        public abstract void Say();

        virtual public void Print()
        {

            Console.WriteLine($"I`m a {Species}, my speed is {Speed}!");
        }

    };
}
