﻿using FarmSystem.Test1.Interfaces;
using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : IAnimal,IMilkableAnimal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; set; } = 4;

        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

        public void Run()
        {
            Console.WriteLine("Cow is running");
        }
        

    }
}