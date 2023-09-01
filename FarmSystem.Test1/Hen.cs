using FarmSystem.Test1.Interfaces;
using System;

namespace FarmSystem.Test1
{
    public class Hen : IAnimal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; set; } = 2;

        public void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }
       
    }
}