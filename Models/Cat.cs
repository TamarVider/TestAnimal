using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal.Models
{
    class Cat :Animal, Land
    {
        private int numberOfLegs;
        public virtual int getNumOfLegs()
        {
            return numberOfLegs;
        }
        public Cat(bool mammalian, bool carnivorous, int mood) : base(mammalian, carnivorous, mood)
        {
            this.numberOfLegs = 4;
        }
        public override void SayHello()
        {
            //Cats usually make a "meow~" sound when they greet people
            Console.WriteLine("meow~");
        }
        public override void SayHello(int mood)
        {
        //when they are frightened, they make a "hiss" sound
            if (mood == MOOD_SCARE)
                Console.WriteLine("hiss");
            //when they are in a good mood, they make a "purr, purr" sound 
            //I assume that if I didn't get  as a parameter One of the mood options (0,1) the default is happy
            else 
                Console.WriteLine("purr, purr");
        }
    }
}
