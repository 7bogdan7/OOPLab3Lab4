using System;

namespace Lab4
{
    public class Carnivor : Animal
    {
        public Carnivor(string nume, int energie, (int x, int y) pozitie)
            : base(nume, energie, pozitie, 0.9f, 3, TipHrana.Carnivor) { }

        public Carnivor()
        {

        }
        public override void Mananca(EntitateEcosistem prada)
        {
            Console.WriteLine($"{Nume} hunts and eats the prey.");
            Energie += 20;
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
