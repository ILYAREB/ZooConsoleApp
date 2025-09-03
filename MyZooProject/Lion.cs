﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooProject
{
    public class Lion : Animal
    {
        public Lion(string name) : base(name, 50)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("R-r-r-r!");
        }
    }
}
