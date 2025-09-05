using System;

namespace MyZooProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ZOO!");
            Zoo zoo = new Zoo();
            string? name;

            while (true)
            {
                Console.WriteLine("\n" + """
                *** Interface ***
                1.Add new lion
                2.Feed the animals
                3.See the full list of animals
                4.Exit
                """);
                Console.Write("\nSelect an action: ");

                string? input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    switch (number)
                    {
                        case 1:
                            Console.Write("Enter name: ");
                            name = Console.ReadLine();
                            zoo.AddAnimal(new Lion(name));
                            Console.WriteLine($"A new animal has been adeed to the zoo: {name}");
                            break;

                        case 2:
                            if (zoo.GetHungryAnimals().Count != 0)
                            {
                                var hungryAnimals = zoo.GetHungryAnimals();

                                Console.WriteLine("List of animals that want to eat:");
                                for (int i = 1; i <= hungryAnimals.Count; i++)
                                {
                                    Console.WriteLine($"{i}){hungryAnimals[i - 1].Name}");
                                }

                                Console.Write("Select an animal: ");
                                input = Console.ReadLine();
                                if (int.TryParse(input, out int index) && index >= 1 && index <= hungryAnimals.Count)
                                {
                                    hungryAnimals[index - 1].Eat();
                                    Console.WriteLine($"{hungryAnimals[index - 1].Name} ate! >u<");
                                }

                            }
                            else
                            {
                                Console.WriteLine("There are no hungry animals left :)");
                                break;
                            }
                            break;

                        case 3:
                            if (zoo.GetAllAnimals().Count != 0)
                            {
                                Console.WriteLine("List of animals:");
                                for (int i = 1; i <= zoo.GetAllAnimals().Count; i++)
                                {
                                    Console.WriteLine($"{i}){zoo.GetAllAnimals()[i - 1].Name}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("There are no animals at the zoo yet :(");
                            }
                            break;
                        case 4: return;
                    }

                }
                else
                {
                    Console.WriteLine("I received an incorrect response!");
                }
            }

        }
    }
}
