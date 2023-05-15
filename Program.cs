using System;
using TestAnimal.Models;

namespace TestAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
        {
            new Dog(true, true, Animal.MOOD_HAPPY),
            new Cat(true, true, Animal.MOOD_SCARE),
            new Frog(false, false, Animal.MOOD_HAPPY)
        };
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].SayHello();
                animals[i].SayHello(Animal.MOOD_SCARE);// we decide what is the mood of the animal because the attribute mood is protected and does not have a get in the diagram
                Console.WriteLine("Number of legs: " + (animals[i] as Land)?.getNumOfLegs());
                Console.WriteLine("Has gills: " + (animals[i] as Water)?.hasGills());
                Console.WriteLine("Lays eggs: " + (animals[i] as Water)?.hasLaysEgges());
                Console.WriteLine();
            }
        }
    }
}
