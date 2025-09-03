using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooProject
{
    public interface IAnimal
    {
        public string Name { get; }
        public int Energy { get; }
        public void MakeSound();
        public void Eat();
    }
}
