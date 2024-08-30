using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploPiezas
{
    class Peon: Pieza
    {
        public Peon(int x, int y, string nombre)
        {
            this.nombre = nombre;
            posicionX = x;
            posicionY = y;
        }
        public override bool Mover(int X, int Y)
        {
            bool puede = false;
            if ((X == posicionX) && (Y == posicionY + 1))
                {
                    puede = true;
                    posicionY = Y;
                }
            return puede;
        }
    }
}
