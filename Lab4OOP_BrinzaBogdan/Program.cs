using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace Lab4
{
    class Program
    {
        static public int UserMenu()
        {
            Console.WriteLine($"<--*---*----* ************* *---*---*--->");
            Console.WriteLine($"------------- ------------- -------------");

            Console.WriteLine("1 - - - > Starting the Ecosystem - - - ");
            Console.WriteLine("2 - - - > Happens something - - - ");
            Console.WriteLine("3 - - - > Moving Creatures - - - ");
            Console.WriteLine("4 - - - > Show the state of the Ecosystem - - - ");

            Console.WriteLine($"------------- ------------- -------------");
            Console.WriteLine($"<--*---*----* ************* *---*---*--->");

            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        } 
        static void Main()
        {
            Console.WriteLine($"Length of the safe zone");
            int Cat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Width of the safe zone");
            int PeCat = Convert.ToInt32(Console.ReadLine());
            
            Ecosistem ecosistem = new Ecosistem(Cat,PeCat);
            EntitateEcosistem planta1 = new Planta("Blueberry", 10, (0, 0));
            EntitateEcosistem erbivor = new Erbivor("Deer", 20, (1, 7));
            EntitateEcosistem carnivor = new Carnivor("Fox", 30, (2, 2));
            EntitateEcosistem omnivor = new Omnivor("Bear", 40, (3, 3));
            ecosistem.AdaugaEntitate(planta1);
            ecosistem.AdaugaEntitate(erbivor);
            ecosistem.AdaugaEntitate(carnivor);
            ecosistem.AdaugaEntitate(omnivor);
            while(true)
            {
                switch(UserMenu())
                {
                    case 1:
                        Console.WriteLine("Starting the Ecosystem");
                    break;

                    case 2:
                        Ecosistem.DoSomething(ecosistem);
                    break;

                    case 3:
                        foreach(var it in Ecosistem.entitati)
                        {
                            it.Actioneaza();
                        }
                    break;

                    case 4:
                        EntitateEcosistem.AfiseazaStare();
                    break;
                    
                    case 0:
                        Environment.Exit(0);
                    break; 
                }
            }
        }
    }
}