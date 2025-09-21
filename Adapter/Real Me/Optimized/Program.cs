using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized
{
    public class Program
    {
        public static void Main()
        {
            // Non-adapted chemical compound 
            var unknown = new Compound();
            unknown.Display();

            // Adapted chemical compounds
            var water = new RichCompound(Chemical.Water);
            water.Display();

            var benzene = new RichCompound(Chemical.Benzene);
            benzene.Display();

            var ethanol = new RichCompound(Chemical.Ethanol);
            ethanol.Display();

            Console.ReadKey();
        }
    }
}
