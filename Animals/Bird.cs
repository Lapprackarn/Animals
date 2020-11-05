using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Bird : Animal
    {
        public Bird(string name)
        {
            species = 3;
            canFly = true;
            base.name = name;
        }


        public override void IntroduceYoureself()
        {
            Console.WriteLine("kaw kaw. jag är en Fågel som heter " + name);
            base.IntroduceYoureself();
        }
    }
    }

