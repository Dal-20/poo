using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc5
{
    class Album
    {
        int Id;
        string Nombre;
        string FecCreac;
        List<Fotos> Lista;
        int totlist;



        public Album(int id, string nombre, string fecCreac, List<Fotos> lista, int totlist)
        {
            Id1 = id;
            Nombre1 = nombre;
            FecCreac1 = fecCreac;
            Lista1 = lista;
            Totlist = totlist;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string FecCreac1 { get => FecCreac; set => FecCreac = value; }
        public int Totlist { get => totlist; set => totlist = value; }
        internal List<Fotos> Lista1 { get => Lista; set => Lista = value; }

        public void AnadirF(Fotos F)
        {
            try
            {
                this.Lista1.Add(F);
                this.totlist += 1;
                Console.WriteLine("Se añadio una nueva foto");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo añadir: {0}", ex.Message);
                Console.ReadKey();
            }
        }
        public void MostrarFot()
        {
            foreach (var n in this.Lista1)
            {
                Console.WriteLine("-----");
                n.ToString();
            }
        }
        public void VaciarAlbum()
        {
            Console.WriteLine("Esta seguro que desea eliminar las fotos??");
            string resp = Console.ReadLine();
            if (resp == "si" || resp == "no")
            {
                Lista1 = new List<Fotos>();
                this.totlist = 0;
                Console.WriteLine("Se ha eliminado todos los elementos");
            }
            else
            {
                Console.WriteLine("No se elimino, Hay {0} fotos", totlist);
                Console.ReadKey();
            }
        }
        public void EliminarFto(List<Fotos> f)
        {

            if (totlist > 0)
            {
                List<Fotos>.re;
                totlist -= 1;
                Console.WriteLine("Se ha eliminado un registro");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hay fotos en el album");
            }

        }
        public void MostrarTamaño()
        {
            int c = 0;
            foreach (var n in Lista1)
            {
                c += n.Tam;
            }
            Console.WriteLine("El tamaño total del album es de: {0}", c);
        }
    }
}
