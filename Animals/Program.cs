using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] allAnimals;

            allAnimals = new Animal[4];
            allAnimals[0] = new Cat("Molle");
            allAnimals[1] = new Dog("Disa");
            allAnimals[2] = new Cat("Pettsson");
            allAnimals[3] = new Bird("Diesel");

            foreach (Animal a in allAnimals)
            {
                Console.WriteLine("Nu kommer " + a.name);
                a.IntroduceYoureself();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
