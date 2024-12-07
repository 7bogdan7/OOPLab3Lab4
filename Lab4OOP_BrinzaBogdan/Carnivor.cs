namespace Lab4OOP_BrinzaBogdan
{
    public class Carnivore : Animal
    {
        public Carnivore(string name, int energy, (int x, int y) position)
            : base(name, energy, position, 5, FoodType.Carnivore) { }

        public override void Eat(Entity entity)
        {
            if (entity is Animal)
            {
                Console.WriteLine($"{Name} eats {entity.Name}.");
                Energy += 10;
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
            Energy -= 5;
        }

        public override void Reproduce()
        {
            Console.WriteLine($"{Name} reproduces.");
        }

        public override void Act()
        {
            base.Act();
            Console.WriteLine($"{Name} is hunting.");
        }
    }
}
