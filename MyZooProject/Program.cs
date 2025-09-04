namespace MyZooProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ZOO!");
            Zoo zoo = new Zoo();
            string? name;

            while(true)
            {
                Console.WriteLine("\n"+"""
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
                            foreach (IAnimal animal in zoo.GetAllAnimals())
                            {
                                animal.Eat();
                                Console.WriteLine($"The animal {animal.Name} ate! >u<");
                            }
                            break;

                        case 3:
                            foreach(IAnimal animal in zoo.GetAllAnimals())
                            {
                                Console.WriteLine(animal.Name);
                            }
                            break;
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
