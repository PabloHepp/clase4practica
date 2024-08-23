using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    abstract internal class Persona //al tener Abstract puedo tener un cliente o un empleado pero no Persona
    {
        protected string nombre;
        protected long dni;

        public Persona(string nombre, long dni) //conviene recibir como argumento solo lo pertinente para que el objeto exista
        { 
            this.nombre = nombre;
            this.dni = dni;
        }
        //aca definimos propiedades para acceder a los atributos de persona
        //pero podria ser tambien métodos
        public long DNI // propiedad
        {
            get { return dni; }
        }

        public string Nombre // propiedad 
        {
            get { return nombre; }
        }

        //Para que una clase sea abstracta deberia tener un método abstracto
        //Un metodo abstracto quiere decir que ese metodo está definido en la clase base
        //en un metodo abstracto ejecutado por un objeto el objeto elije como implementar

        //
        abstract public void AgregarCompra(double monto); //Firma
        //Aca agregamos el metodo en la clase abrastracta para que las clases heredadas funcione en objetos creados por cliente o empleado
        // no defino que hace aca porque sino haria lo que diga acá y no lo que le pida el objeto que herede
        // por eso va sin llaves, va vacio. Se le llama Firma
        //sería como el molde de un método
        // y en las clases que heredan la clase abstracta , al método hay que anteponerle lal palabra override para que sobreescriba y tome el comportamiento que necesita el objeto
        //esto es polimorfismo
    }
}
