using System;
using System.Collections.Generic;

namespace Lab4OOP_BrinzaBogdan
{
    public class Ecosystem
    {
        public List<Entity> Entities { get; private set; }

        public Ecosystem()
        {
            Entities = new List<Entity>();
        }

        public void AddEntity(Entity entity)
        {
            Entities.Add(entity);
        }

        public void RemoveEntity(Entity entity)
        {
            Entities.Remove(entity);
        }

        public void Simulate()
        {
            foreach (var entity in Entities)
            {
                entity.Act();
            }
        }

        public void DisplayStatus()
        {
            foreach (var entity in Entities)
            {
                Console.WriteLine($"Entity: {entity.Name}, Energy: {entity.Energy}, Position: {entity.Position}");
            }
        }
    }
}
