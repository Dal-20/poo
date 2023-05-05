using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Casa_comercial
    {
       
        string nombre;
        string email;
        int total;
        List<Vehiculo> vehiculos;

        public Casa_comercial(string nombre, string email, int total, List<Vehiculo> vehiculos)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Total = total;
            this.Vehiculos = vehiculos;
        }

       
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Total { get => total; set => total = value; }
        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

        
        public void AnadirVehiculo(Vehiculo vehiculo)
        {
            try
            {
                
                this.vehiculos.Add(vehiculo);
                
                this.total += 1;
                Console.WriteLine("Se ha añadido un nuevo vehiculo\n");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo añadir debido a: {0}", ex.Message);
                Console.ReadLine();
            }
        }
        public void Mostrarvehiculos()
        {
            foreach (var n in this.vehiculos)
            {
                Console.WriteLine(n.ToString());
                
            }
        }
        public void VaciarVehiculo()
        {
            Console.WriteLine("Estas seguro que desea vaciar los elementos mostrados en la lista: S/N");
            string resp = Console.ReadLine();
            if (resp == "S" || resp == "s")
            {
                vehiculos = new List<Vehiculo>();
                this.total = 0;
                Console.WriteLine("Se ha eliminado todos los elementos");
            }
            else
            {
                Console.WriteLine("No se elimino, Hay {0} vehiculo registrado", total);
                Console.ReadKey();
            }
        }
        public void EliminarVehiculo(Vehiculo v)
        {
            if (vehiculos.Count > 0)
            {
                vehiculos.Remove(v);
                total -= 1;
                Console.WriteLine("Se ha eliminado un registro");
            }
            else
                Console.WriteLine("No hay elementos que eliminar en la lista");
            Console.ReadKey();
        }
    }
}


    

