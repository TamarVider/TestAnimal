using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal.Models
{
    class Dog : Animal, Land
    {
        private int numberOfLegs;
        public virtual int getNumOfLegs()
        {
            return numberOfLegs;
        }
        public Dog(bool mammalian, bool carnivorous, int mood) : base(mammalian, carnivorous, mood)
        {
            this.numberOfLegs = 4;
        }
        public override void SayHello()
        {
            //Dogs usually greet people by "wagging their tails"
            Console.WriteLine("wagging their tails");
        }
        public override void SayHello(int mood)
        {
            //When they are frightened and upset, they will make a "whooping" sound
            if (mood == MOOD_SCARE)
                Console.WriteLine("whooping");
            //When they feel comfortable being touched, they will bark loudly
            //I assume that if I didn't get  as a parameter One of the mood options (0,1) the default is happy
            else
                Console.WriteLine("bark loudly");
        }
    }
}