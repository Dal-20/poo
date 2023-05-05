using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc4
{
    class Auto:Vehiculo
    {
        bool airbag;

        public Auto(bool airbag)
        {
            this.airbag = airbag;
        }
        public bool Airbagr { get => airbag; set => airbag = value; }
    }
}
