using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploPiezas
{
    abstract class Pieza
    {
        protected string nombre;
        protected int posicionX, posicionY;

        public abstract bool Mover(int X, int Y);

        public string Nombre()
        {
            return nombre;
        }
        public int[] VerPosicion()
        {
            int[] pos = { posicionX, posicionY };
            return pos;
        }
        public string Mostrar()
        {
            return nombre + " x: " + posicionX.ToString(); 
        }
    }
}
