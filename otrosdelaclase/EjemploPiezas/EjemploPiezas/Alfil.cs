using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploPiezas
{
    class Alfil: Pieza
    {
        public Alfil(string n, int x, int y)
        {
            nombre = n;
            posicionX = x;
            posicionY = y;
        }
        public override bool Mover(int X, int Y)
        {
            bool puede = false;
            if (Math.Abs(posicionX - X) == Math.Abs(posicionY - Y))
            {
                puede = true;
                posicionX = X;
                posicionY = Y;
            }
            return puede;
        }
    }
}
