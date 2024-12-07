namespace Lab4OOP_BrinzaBogdan
{
    public class Plant : Entity
    {
        public Plant(string name, int energy, (int x, int y) position)
            : base(name, energy, position) { }

        public override void Act()
        {
            Energy += 6;
            Console.WriteLine($"{Name} grows, energy: {Energy}");
        }

        public void Reproduce()
        {
            Console.WriteLine($"{Name} is reproducing.");
        }
    }
}
