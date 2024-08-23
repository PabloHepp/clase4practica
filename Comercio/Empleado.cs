using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    class Empleado : Persona // si marca error es porque falta constructor
    {
        double sueldo; //aca no lleva protected porque no lo hereda  a nadie
        double comision;

        public Empleado(long dni, string nombre, double sueldo) : base(nombre, dni)
        {
            this.sueldo = sueldo;

        }

        public override void AgregarCompra(double monto)
        {
            comision += monto * 10 / 100;
        }

        public double Sueldo()
        {
            return sueldo + comision;
        }
    }

}
