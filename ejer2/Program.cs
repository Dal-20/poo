using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa_comercial varcasa = new Casa_comercial("Juan","JP@gmail.com",0,new List<Vehiculo>());
            Vehiculo clavehic = new Vehiculo(123, "KIA", "Montañero", 180, 150000, 2020);
            varcasa.AnadirVehiculo(clavehic);
            varcasa.Mostrarvehiculos();
            varcasa.VaciarVehiculo();
            varcasa.EliminarVehiculo(clavehic);
            Console.ReadKey();
        }
    }
}
