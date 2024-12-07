namespace Lab4OOP_BrinzaBogdan
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public (int x, int y) Position { get; set; }

        public Entity(string name, int energy, (int x, int y) position)
        {
            Name = name;
            Energy = energy;
            Position = position;
        }

        public abstract void Act();
    }
}
