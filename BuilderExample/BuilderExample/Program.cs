using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamerPCbuiler = new GamerPCBuilder();
            var officePCbuilder = new OfficePCBuilder();
            var buy = new BuyPC();
            Console.WriteLine("Press 1 - office PC or press 2- gamer PC");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    buy.SetPcBuilder(officePCbuilder);
                    break;
                case 2:
                    buy.SetPcBuilder(gamerPCbuiler);
                    break;
                default:
                    Console.WriteLine("Unknown parameter");
                    break;
            }
            buy.ConstructPC();
            PC pc = buy.GetPc();
            Console.WriteLine(pc.ToString());
        }
    }
}
