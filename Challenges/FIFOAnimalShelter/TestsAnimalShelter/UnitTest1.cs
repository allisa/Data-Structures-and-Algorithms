using FIFOAnimalShelter.Classes;
using System;
using Xunit;

namespace TestsAnimalShelter
{
    public class UnitTest1
    {

        /// <summary>
        /// Test to dequeue fifo animal, cat which is also front
        /// </summary>
        [Fact]
        public void CanDequeueFrontAnimal()
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

            Assert.Equal(cat1, AShelter.Dequeue("cat"));
        }

        /// <summary>
        /// Test to dequeue cat if in middle of queue
        /// </summary>
        [Fact]
        public void CanDequeueCatInMiddleOfQueue()
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

            AShelter.Dequeue("cat");

            Assert.Equal(cat2, AShelter.Dequeue("cat"));
        }

        /// <summary>
        /// Test to dequeue front animal if no animal preference
        /// </summary>
        [Fact]
        public void CanDequeueFrontIfNoPreference()
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

            Assert.Equal(cat1, AShelter.Dequeue());
        }

        /// <summary>
        /// Test to dequeue dog if it is not front
        /// </summary>
        [Fact]
        public void CanDequeueDogIfNotFirst()
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

            Assert.Equal(dog1, AShelter.Dequeue("dog"));
        }

        /// <summary>
        /// Test that queue rearranges correctly after shuffling to remove specific animal
        /// </summary>
        [Fact]
        public void TestQueuePreservation()
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

            AShelter.Dequeue();
            AShelter.Dequeue("cat");

            Assert.Equal(dog1, AShelter.Front);
        }
        
        /// <summary>
        /// Test to dequeue front animal if invalid animal given
        /// </summary>
        [Fact]
        public void TestToReturnIfIncorrectAnimal()
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

            Assert.Equal(cat1, AShelter.Dequeue("bunny"));
        }

    }
}
