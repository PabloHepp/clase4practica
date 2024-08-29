using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajes
{
    class Pasaje
    {
        Asiento elAsiento;
        Micro elMicro;
        public Pasaje (Micro coche, Asiento boleto)
        {
            elMicro = coche;
            elAsiento = boleto;
        }
    }
}
