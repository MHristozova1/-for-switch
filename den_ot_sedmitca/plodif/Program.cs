using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plodif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi ime na plod ili zelenchuk:");
            string plod = Console.ReadLine();
            if (plod == "domat" || plod == "zele" || plod == "krastavitca")
            {
                Console.WriteLine("Zelenchuk");
            }
            else
            if (plod == "kivi" || plod == "banan" || plod == "mandarina")
            {
                Console.WriteLine("Plod");
            }
            else
                Console.WriteLine("Ostava6 gladen");
}
    }
}
