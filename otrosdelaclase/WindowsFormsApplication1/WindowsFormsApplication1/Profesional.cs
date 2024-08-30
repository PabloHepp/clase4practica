using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Profesional: Persona
    {
        string profesion;
        public Profesional(string n, string prof)
            : base(n)
        {
            profesion = prof;
        }
        public override string VerStado()
        {
            return nombre + " " + profesion;
        }
    }
}
