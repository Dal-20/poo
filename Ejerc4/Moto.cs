using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc4
{
    class Moto:Vehiculo
    {
        bool sidecar;

        public Moto(bool sidecar)
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
