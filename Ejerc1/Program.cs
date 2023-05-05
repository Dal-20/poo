using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo(1, "Aveo", "Chevrolet", 5000, 1500, 2017);
            Console.WriteLine(vehiculo.ToString());
            Console.ReadKey();
        }
    }
}
