using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ejercicio
{
    class auto:Vehiculo
    {
        bool airbag;

        public auto(int id, string marca, string modelo, int km, decimal precio, int anio, bool airbag)
            :base(id,marca,modelo,km,precio,anio)
            
        {
            this.airbag = airbag;
        }
        public bool Airbagr { get => airbag; set => airbag = value; }

        public override decimal Calprecio()
        {
            if (Airbagr)
            {
                Precio1 += 200;
            }
            else
            {
                Precio1 = Precio1;
            }
            return base.Calprecio();
        }
    }
}
