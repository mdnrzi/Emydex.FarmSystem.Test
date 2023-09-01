using FarmSystem.Test1.Interfaces;
using FarmSystem.Test2;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //List of animals
        private List<IAnimal> animals = new List<IAnimal>();
        // Event to notify when the farm is empty
        public event EventHandler FarmEmpty;

        //TEST 1
        public void Enter(IAnimal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            animals.Add(animal);
            Console.WriteLine($"{animal.GetType().Name} has entered the Emydex farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            //Console.WriteLine("There are no animals in the farm");
            foreach (var animal in animals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            //Console.WriteLine("Cannot identify the farm animals which can be milked");
            foreach (var animal in animals)
            {
                if (animal is IMilkableAnimal milkableAnimal)
                {
                    milkableAnimal.ProduceMilk();
                }
            }
        }
        

        //TEST 4
        public void ReleaseAllAnimals()
        {
            //Console.WriteLine("There are still animals in the farm, farm is not free");
            Console.WriteLine("Exercise 4: Releasing all animals");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} has left the farm");
            }

            // Clear the collection
            animals.Clear();

            // Raise the FarmEmpty event
            OnFarmEmpty();

        }
        protected virtual void OnFarmEmpty()
        {
            FarmEmpty?.Invoke(this, EventArgs.Empty);
        }
    }
}