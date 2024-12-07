using System;

namespace Lab4
{
    public class Omnivor : Animal
    {
        public Omnivor(string nume, int energie, (int x, int y) pozitie)
            : base(nume, energie, pozitie, 0.85f, 2, TipHrana.Omnivor) { }
        
        public Omnivor()
        {

        }
        public override void Mananca(EntitateEcosistem entitate)
        {
            Console.WriteLine($"{Nume} eats both the plants and animals.");
            Energie += 15;
        }

        public override void Actioneaza()
        {
            Deplaseaza();
        }

        public override void Ataca(Animal prada)
        {
            Console.WriteLine($"{Nume} attacks {prada.Nume}.");
        }

        public override void Reproduce()
        {
            Console.WriteLine($"{Nume} reproduces itself.");
        }
    }
}
