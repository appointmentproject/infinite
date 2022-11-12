﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IAnimal
    {
        string speak();
    }

    public class Cat : IAnimal
    {
        public string speak()
        {
            return "Meow Meow";
        }
    }

    public class Dog : IAnimal
    {
        public string speak()
        {
            return "Bow Bow";
        }
    }

    public class Shark : IAnimal
    {
        public string speak()
        {
            return "Cannot Speak";
        }
    }

    public class Octopus : IAnimal
    {
        public string speak()
        {
            return "Squawck";
        }
    }

    public class Lion : IAnimal
    {
        public string speak()
        {
            return "Roar Roar";
        }
    }
    public class elephant : IAnimal
    {
        public string speak()
        {
            return "trumpet";
        }
    }
    public class tiger : IAnimal
    {
        public string speak()
        {
            return "roar";
        }
    }

}