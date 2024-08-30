using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

//Diferencia entre clase abstracta e interfaz: la absstracta es cuando los objetos que se crean por herencia son de la misma naturaleza, y las interfaces cuando son de distinta naturaleza

//IComparable VA A PARCIAL
namespace Polimorfismo
{
    internal abstract class Persona:IComparable //si le digo que voy a usar una interface SI O SI tengo que usar un metodo de la interface dentro
    {
        protected string nombre;
        public Persona(string nom)
        {
            nombre = nom;
        }
        public virtual string Identificar()
        {
            return nombre + " es persona "; 
        }

        
        public virtual int CompareTo(object obj) //metodo de la interface
        {
            if (obj == null) return 0;
            Persona otra = obj as Persona;
            return this.nombre.CompareTo(otra.nombre);

        }
        //con este metodo convierto , no casteo
        // con esto puedo ordenar por nombre

    }
}
