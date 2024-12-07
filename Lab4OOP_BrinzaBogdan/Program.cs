using System;

namespace Lab4OOP_BrinzaBogdan
{
    class Program
    {
        static void Main(string[] args)
        {
            var herbivore = new Herbivore("Herbivore1", 50, (0, 0));
            var carnivore = new Carnivore("Carnivore1", 80, (5, 5));
            var omnivore = new Omnivore("Omnivore1", 60, (10, 10));
            var plant = new Plant("Plant1", 30, (3, 3));

            var ecosystem = new Ecosystem();
            ecosystem.AddEntity(herbivore);
            ecosystem.AddEntity(carnivore);
            ecosystem.AddEntity(omnivore);
            ecosystem.AddEntity(plant);

            ecosystem.Simulate();
            ecosystem.DisplayStatus();
        }
    }
}
