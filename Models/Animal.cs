using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal.Models
{
     abstract class Animal
    {
        protected bool mammalian;
        protected bool carnivorous;
        public const int MOOD_HAPPY = 1;
        public const int MOOD_SCARE = 0;
        protected int mood { get; set; }
        public Animal(bool mammalian, bool carnivorous, int mood)
        {
            this.mammalian = mammalian;
            this.carnivorous = carnivorous;
            this.mood = mood;
        }
        public virtual void SayHello()
        { }
        public abstract void SayHello(int mood);
    }
}