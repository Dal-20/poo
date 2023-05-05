using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc3
{
    class Program
    {

        static void pedir(string m, out int n)
        {
            Console.WriteLine(m);
            n = int.Parse(Console.ReadLine());
        }
        static void Menu()
        {
            Console.WriteLine("\n\n\tMENU\n");
            Console.WriteLine("1.encender la computadora");
            Console.WriteLine("2.anadir un dato");
            Console.WriteLine("3.eliminar un dato");
            Console.WriteLine("4.apagart la computadora");
            Console.WriteLine("5.salir");
        }
        static void Ejecutar(Computadora cp)
        {
            int opc;
            do
            {
                int dato;
                Menu();
                pedir("de la opcion: ", out opc);
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        cp.Enceder(); break;
                    case 2:
                        pedir("de el tamaño del dato: ", out dato);
                        cp.AñadirDato(dato);
                        break;
                    case 3:
                        pedir("de el tamaño del dato a eliminar: ", out dato);
                        cp.EliminarDato(dato);
                        break;
                    case 4:
                        cp.apagado();
                        break;
                    case 5:
                        Console.WriteLine("saliendo...");
                        break;
                    default:
                        Console.WriteLine("opcion fuera del rango");
                        break;
                }
            }
            while (opc != 5);
        }
        static void Main(string[] args)
        {
            Computadora cp = new Computadora(0, 200, false);
            Ejecutar(cp);
            Console.ReadKey();
        }
    }
}
