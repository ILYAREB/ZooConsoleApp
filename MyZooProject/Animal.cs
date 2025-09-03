using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooProject
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; }
        public int Energy { get; set; }
        protected Animal(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }

        public abstract void MakeSound();

        public void Eat()
        {
            Energy += 10;
        }
    }
}
