using System;

namespace Lab4OOP_BrinzaBogdan
{
    public abstract class Animal : Entity, IInteractiune
    {
        public int Speed { get; set; }
        public FoodType DietType { get; set; }

        public Animal(string name, int energy, (int x, int y) position, int speed, FoodType dietType)
            : base(name, energy, position)
        {
            Speed = speed;
            DietType = dietType;
        }

        public abstract void Eat(Entity entity);
        public abstract void Move();
        public abstract void Hunt(Animal prey);
        public abstract void Reproduce();

        public override void Act()
        {
            Console.WriteLine($"{Name} acts.");
            Energy -= 2;
        }

        public void Ataca(Animal prada)
        {
            Hunt(prada);
        }

        public void Reproduce()
        {
            Console.WriteLine($"{Name} reproduces.");
        }
    }
}
