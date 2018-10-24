using System;
using Stack_and_Queue.Classes;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AnimalShelterFIFO();
        }

        public static void AnimalShelterFIFO()
        {
            Animal cat1 = new Cat();
            Animal dog1 = new Dog();
            Animal cat2 = new Cat();
            Animal dog2 = new Dog();
            Animal dog3 = new Dog();

            AnimalShelter AShelter = new AnimalShelter(cat1);

            AShelter.Enqueue(dog1);
            AShelter.Enqueue(cat2);
            AShelter.Enqueue(dog2);
            AShelter.Enqueue(dog3);

            Console.WriteLine(cat1.Name);
            Console.WriteLine(dog1.Name);
            Console.WriteLine(cat2.Name);
            Console.WriteLine(dog2.Name);
            Console.WriteLine(dog3.Name);


            Console.WriteLine("Dequeue front animal: cat");
            Console.WriteLine(AShelter.Dequeue("cat").Name);

            Console.WriteLine("Dequeue not front cat.");
            Console.WriteLine(AShelter.Dequeue("cat").Name);

        }
    }
}
