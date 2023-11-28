using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace den
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi chislo ot 1 do 7:");
            string  den= Console.ReadLine();
            switch (den)
            {
                case "1": Console.WriteLine("ponedelnik"); break;
                case "2": Console.WriteLine("vtornik"); break;
                case "3": Console.WriteLine("srqda"); break;
                case "4": Console.WriteLine("chetvartak"); break;
                case "5": Console.WriteLine("petak"); break;
                case "6": Console.WriteLine("sabota"); break;
                case "7": Console.WriteLine("nedelia"); break;

                default: Console.WriteLine(" nqma takav den"); break;

            }
        }
    }
}
