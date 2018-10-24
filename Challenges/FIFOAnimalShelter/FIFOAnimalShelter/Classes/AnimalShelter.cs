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
        /// 
        /// </summary>
        /// <returns></returns>
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

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
