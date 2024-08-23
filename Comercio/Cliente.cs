using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    internal class Cliente:Persona
    {
        int nroCuenta;
        double saldo = 0;

        public Cliente(string nom, long dni, int nro):base(nom,dni)
        {
            nroCuenta = nro;

        }

        public override void AgregarCompra(double monto)
        {
            saldo += monto;

        }

        public int NroCuenta // Propiedad
        {
            get { return nroCuenta; }
        }

        public double Saldo()

        {
            return saldo;
        }

        //Aca tambien sobreescribo el metodo ToString de persona y le agrego lo que quiero desde Cliente
        public override string ToString()
        {
            return base.ToString() + "Esto esta agregado desde persona";
        }
    }
}
