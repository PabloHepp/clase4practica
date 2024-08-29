using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Persona
    {
        protected string nombre;
        public Persona(string nom)
        {
            nombre = nom;
        }
        public virtual string Identificar()
        {
            return nombre + " es persona";
        }

    }
}
