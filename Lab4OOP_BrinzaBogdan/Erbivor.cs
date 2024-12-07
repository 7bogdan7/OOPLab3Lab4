using System;

namespace Lab4
{
    public class Erbivor : Animal
    {
        public Erbivor(string nume, int energie, (int x, int y) pozitie)
            : base(nume, energie, pozitie, 0.7f, 2, TipHrana.Erbivor) { }
        
        public Erbivor()
        {

        }
        public override void Mananca(EntitateEcosistem planta)
        {
            Console.WriteLine($"{Nume} eats the plant.");
            Energie += 10;
        }

        public override void Actioneaza()
        {
            Deplaseaza();
        }

        public override void Ataca(Animal prada)
        {
            Console.WriteLine($"{Nume} cannot attack (erbivor).");
        }

        public override void Reproduce()
        {
            Console.WriteLine($"{Nume} reproduces itself.");
        }
    }
}
