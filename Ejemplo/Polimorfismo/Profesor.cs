using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Profesor
    {
        int legajo;
        public Profesor (string nombre, int valor)
        {
            legajo = valor;
        }
        public string Identificar()
        {
            return "es profesor";
        }
        public int Legajo
        {
            get => legajo;
        }
    }
}
