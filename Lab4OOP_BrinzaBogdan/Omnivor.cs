using System;

namespace Lab4OOP_BrinzaBogdan
{
    public class Omnivore : Animal
    {
        public Omnivore(string name, int energy, (int x, int y) position)
            : base(name, energy, position, 4, FoodType.Omnivore) { }

        public override void Eat(Entity entity)
        {
            if (entity is Plant)
            {
                Console.WriteLine($"{Name} eats plant {entity.Name}.");
                Energy += 18;
            }
            else if (entity is Animal)
            {
                Console.WriteLine($"{Name} eats animal {entity.Name}.");
                Energy += 22;
            }
        }

        public override void Move()
        {
            Position = (Position.x + Speed, Position.y);
            Console.WriteLine($"{Name} moved to position ({Position.x}, {Position.y}).");
        }

        public override void Hunt(Animal prey)
        {
            Console.WriteLine($"{Name} hunts {prey.Name}.");
            Energy -= 6;
        }

        public override void Reproduce()
        {
            Console.WriteLine($"{Name} reproduces.");
        }

        public override void Act()
        {
            base.Act();
            Console.WriteLine($"{Name} is looking for food.");
        }
    }
}
