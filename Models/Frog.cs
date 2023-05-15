using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal.Models
{
    class Frog : Animal, Water, Land
    {
        private int numberOfLegs;
        public virtual int getNumOfLegs()
        {
            return numberOfLegs;
        }
        public Frog(bool mammalian, bool carnivorous, int mood) : base(mammalian, carnivorous, mood)
        {
            this.numberOfLegs = 4;
        }
        public override void SayHello(int mood)
        {
            //when frightened, it will "plop into the water"
            if (mood == MOOD_SCARE)
                Console.WriteLine("plop into the water");
            //When the frog is in a good mood, it will sing "quack quack quack" on the shore
            //I assume that if I didn't get  as a parameter One of the mood options (0,1) the default is happy

            else
                Console.WriteLine("quack quack quack");
        }
        public virtual bool hasGills()
        {
            return true;
        }
        public bool hasLaysEgges()
        {
            return true;
        }
    }
}
