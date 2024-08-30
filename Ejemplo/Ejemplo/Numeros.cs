using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//EJERCICIO PARA EXPLICAR PASO POR VALOR Y POR REFERENCIA
namespace Ejemplo
{
    class Numeros
    {
        public readonly int CANTIDAD;
        private int[] valores;
       
        public Numeros()
            :this(5)
        {}
        public Numeros(int cantidad)
        {
            CANTIDAD = cantidad;
            valores = new int[CANTIDAD];
            for (int x = 0; x <CANTIDAD; x++)
                valores[x] = (x+1) * 2;

            //SERIA LO IDEAL DECLARAR ACÁ EL VECTOR DONDE SE VAN A COPIAR LAS COSAS
            // int[] resultado = new int[CANTIDAD]; acá solo va a vivir lo que viva el método
        }

        //de esta forma, no quedan protegidos los elementos del vector, se pasa por referencia
        /*
        public int[] Valores()
        {
            return valores; //paso por referencia
            //CANTIDAD = 4;
        }
        */

        // de esta forma si quedan protegidos los elementos, se hace una copia de los datos y se pasan por valor
        public int[] Valores()
        {
            int[] resultado = new int[CANTIDAD];
            for(int x = 0; x< CANTIDAD; x++)
            {
                resultado[x] = valores[x];
            }
            return resultado; //paso por valor
            //return valores; paso por referencia
            //CANTIDAD = 4;
        }


    }
}
