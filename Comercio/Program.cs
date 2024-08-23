using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>(); //List es una clse tipada, "persona" es el tipo que se le asigna
            // Persona primero = new Persona(123, "wali"); // no se puede crear una clase abstracta
            Persona empleado = new Cliente("Juan",34014825,1218);
            lista.Add(empleado);
            empleado = new Empleado(12445, "Maria", 112999);
            lista.Add(empleado);

            foreach(Persona p in lista) //la idea es que nunca castee
            {
                p.AgregarCompra(3000); // esto es polimorfismo
                //porque recorro todo como persona, y cada cosa sabe si es persona o es cliente
                Console.Write("es:"+p.Nombre+"");
                //Ahora no queda otra que castear y preguntar si es cliente o empleado
                if(p is Empleado)
                {
                    Console.WriteLine("sueldo:" + ((Empleado)p).Sueldo()); //Pregunto si es empleado
                    //aca en la 29 no es polimorfismo porque estoy casteando

                }
                if (p is Cliente)
                {
                    Console.WriteLine("Su saldo es:" + ((Cliente)p).Saldo()); //Pregunto si es empleado
                    //aca en la 29 no es polimorfismo porque estoy casteando

                }

                Console.ReadKey();

            }

            

        }
    }
}
