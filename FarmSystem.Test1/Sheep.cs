using FarmSystem.Test1.Interfaces;
using System;

namespace FarmSystem.Test1
{
    public class Sheep : IAnimal
    {

        public string Id { get; set; }
        public int NoOfLegs { get; set; } = 4;


        public void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }
       
    }

}