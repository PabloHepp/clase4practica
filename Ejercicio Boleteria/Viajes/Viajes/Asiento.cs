using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajes
{
    class Asiento
    {
        string clase;
        double precio;
        long cuil;
        bool ocupado;
        public Asiento(double precio) //string clase
        {
            //this.clase = clase;
            Precio = precio;
            ocupado = false;
        }
        public bool Ocupado
        {
           private set { ocupado = value; }
           get { return ocupado; }
        }
        public void Vender(long cuit) // persona pasajaro
        {
            cuil = cuit;
            Ocupado = true;
        }
        public double Precio
        {
           private set { precio = value; }
            get { return precio; }
        }
        public override string ToString()
        {
            return "datos";
        }
    }
}
