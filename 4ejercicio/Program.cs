using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            moto mt = new moto(01, "suize", "nas", 2000, 4500, 2013, true);
            Console.WriteLine(mt.ToString());
            Console.WriteLine();
            Console.WriteLine(mt.Calprecio());
            Console.WriteLine();
            auto at = new auto(02,"toyota","nissan",5000,60000,2014,false);
            Console.WriteLine(at.ToString());
            Console.WriteLine();
            Console.WriteLine(at.Calprecio());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
