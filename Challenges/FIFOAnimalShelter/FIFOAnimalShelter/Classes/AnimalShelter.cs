using System;
using System.Collections.Generic;
using System.Text;
using Stack_and_Queue.Classes;


namespace FIFOAnimalShelter.Classes

{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }


        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        public void Enqueue(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
        }


        /// <summary>
        /// Method to dequeue the front animal if there is not an animal preference
        /// </summary>
        /// <returns></returns>
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Method to return the front animal if oldest in shelter or move queue to get longest selcted animal in shelter
        /// </summary>
        /// <param name="value"></param>
        /// <returns>adoptMe</returns>
        public Animal Dequeue(string value)
        {
            Animal adoptMe;
            Animal temp = Front;
            if (Front.Name == value)
            {
                return Dequeue();
            }

            while (Front.Name != value)
            {
                Enqueue(Dequeue());
                if (temp == Front)
                {
                    return Dequeue();
                }
            }
            adoptMe = Dequeue();

            while (Front != temp)
            {
                Enqueue(Dequeue());
            }
            return adoptMe;
        }
    }

}
