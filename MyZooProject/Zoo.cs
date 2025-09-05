using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooProject
{
    public class Zoo
    {
        private List<IAnimal> animals = new List<IAnimal>();

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
        }
        public IReadOnlyList<IAnimal> GetAllAnimals()
        {
            return animals.AsReadOnly();
        }
        public List<IAnimal> GetHungryAnimals()
        {
            List<IAnimal> hungryAnimals = new List<IAnimal>();
            foreach (IAnimal animal in animals)
            {
                if(animal.Energy < 55)
                {
                    hungryAnimals.Add(animal);
                }
            }
            return hungryAnimals;
        }
    }
}
