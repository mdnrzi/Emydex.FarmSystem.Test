using FarmSystem.Test1.Interfaces;
using System;

namespace FarmSystem.Test1
{
    public class Horse : IAnimal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; set; } = 4;

        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }
        

    }
}