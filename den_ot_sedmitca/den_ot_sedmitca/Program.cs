using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace den_ot_sedmitca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi ime na plod ili zelenchuk:");
            string plod=Console.ReadLine();
            switch (plod) 
            {
                case "domat":
                case "zele":
                case "krastavitca":
                case "marulia":

                    Console.WriteLine(" zelenchuk");break;

                case "kivi":
                case "banan":
                case "mandarina":
                case "portokal":
                case "dinq":                  
                    
                    Console.WriteLine("plod");break;
 
                default :Console.WriteLine(" ostanal si gladen");break;

            }
        }

    }
}
