using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ejercicio
{
    class moto : Vehiculo
    {
        bool sidecar;

        public moto(int id, string marca, string modelo, int km, decimal precio, int anio, bool sidecar)
            : base(id, marca, modelo, km, precio, anio)
        {
            this.sidecar = sidecar;
        }
        public bool Sidecar { get => sidecar; set => sidecar = value; }

        public override decimal Calprecio()
        {
            if (sidecar)
            {
                Precio1 += 50;
            }
            else
            {
                Precio1 = Precio1;
            }
            return base.Calprecio();
        }
    }
}
