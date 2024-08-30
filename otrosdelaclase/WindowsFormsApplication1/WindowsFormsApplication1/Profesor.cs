using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Profesor:Persona
    {
        string catedra;
        public Profesor(string n, string catedra)
            : base(n)
        {
            this.catedra = catedra;
        }
        public override string VerStado()
        {
            return nombre + " profesor de: " + catedra;
        }

    }
}
