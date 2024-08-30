using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Profesor:Persona
    {
        int legajo;
        public Profesor(string nombre, int valor) : base(nombre)
        {
            legajo = valor;
        }
        public override string Identificar()
        {
            return base.Identificar() + " es profesor " + legajo.ToString(); //aca sobreescribo el método Identificar y le agrego "es profesor"
                                                        //En realidad es profesor pero va a escribir "persona" antes
        }
        public int Legajo
        {
            get => legajo;
        }
    }
}
