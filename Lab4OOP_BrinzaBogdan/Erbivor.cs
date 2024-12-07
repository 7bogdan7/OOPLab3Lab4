using System;

namespace Lab4OOP_BrinzaBogdan
{
    public class Herbivore : Animal
    {
        public Herbivore(string name, int energy, (int x, int y) position)
            : base(name, energy, position, 3, FoodType.Herbivore) { }

        public override void Eat(Entity entity)
        {
            if (entity is Plant)
            {
                Console.WriteLine($"{Name} consumes {entity.Name}.");
                Energy += 12;
            }
        }

        public override void Move()
        {
            Position = (Position.x + Speed, Position.y);
            Console.WriteLine($"{Name} moved to position ({Position.x}, {Position.y}).");
        }

        public override void Hunt(Animal prey)
        {
            Console.WriteLine($"{Name} can't hunt (herbivore).");
        }

        public override void Reproduce()
        {
            Console.WriteLine($"{Name} reproduces.");
        }

        public override void Act()
        {
            base.Act();
            Console.WriteLine($"{Name} is grazing.");
        }
    }
}
