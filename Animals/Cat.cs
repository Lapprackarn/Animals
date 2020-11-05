using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            species = 0;
            canFly = false;
            base.name = name;
        }

        public override void IntroduceYoureself()
        {
            Console.WriteLine("Mjau. jag är en Katt som heter " + name);
            base.IntroduceYoureself();
        }
    }
}

