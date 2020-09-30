using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[] {

                new Bear(),
                new Eagle(),
                new Frog(),
                new Dolphin(),
                new Carp()
            };

            foreach (var item in zoo)
            {
                item.Say();
                item.Print();
                Console.WriteLine();
            }

        }
    }
}
