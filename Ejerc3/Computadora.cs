using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc3
{
    class Computadora
    {
            int capacidadDisco;
            int espacioDispinible;
            bool on;

            public Computadora(int cpacidadDisco, int espacioDispinible, bool on)
            {
                this.CapacidadDisco = cpacidadDisco;
                this.EspacioDispinible = espacioDispinible;
                this.On = on;
            }

            public int CapacidadDisco { get => capacidadDisco; set => capacidadDisco = value; }
            public int EspacioDispinible { get => espacioDispinible; set => espacioDispinible = value; }
            public bool On { get => on; set => on = value; }

            public void AñadirDato(int dato)
            {
                if (on)
                {
                    if (dato < espacioDispinible)
                    {
                        this.capacidadDisco += dato;
                        Console.WriteLine("eEl dato se ha añadido");
                    }
                }
                else
                {
                    Console.WriteLine("La computadora esta apagada");
                }
            }

            public void EliminarDato(int dato)
            {
                if (on)
                {
                    if (dato < capacidadDisco)
                    {
                        capacidadDisco -= dato;
                        Console.WriteLine("Se ha elimida el dato");
                    }
                    else
                    {
                        Console.WriteLine("El dato es mayor a lo almacenado en el disco");
                    }
                }
                else
                {
                    Console.WriteLine("La computadora esta apagada");
                }
            }
            public void Enceder()
            {
                this.on = true;
                Console.WriteLine("Encendiendo el equipo");
            }
            public void apagado()
            {
                this.on = false;
                Console.WriteLine("Apagando el equipo");
            }
        }
}
