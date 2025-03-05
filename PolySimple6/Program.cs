using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolySimple6//You can use polymorphism to store
                     //different objects in a collection and call the same method
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog Barks");

        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }
        class Program
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog(),
                new Cat(),
                new Dog()
            };
            foreach (Animal a in animals)
            {
                a.Speak();//Call the overrden in each subclass
            }
        }
    }
}
