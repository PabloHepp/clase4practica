using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajes
{
    class Micro
    {
        string destino;
        int canAsientos;
        string horario;
        double precio;
        Asiento[] asientos;
        int id;
        public string Fecha { get; set; }

        public Micro(string destino, int asientos, double precio, string horario, int codigo)
        {
            this.destino = destino;
            this.precio = precio;
            this.horario = horario;
            canAsientos = asientos;
            this.asientos = new Asiento[asientos];
            for ( int i=0;i<this.asientos.Length;i++)
            {
                this.asientos[i] = new Asiento(precio);
            }
            id = codigo;
        }
        public Asiento[] ConsultarA()
        {
            return asientos;
        }
        public string Destino
        {
           get { return destino; }
        }
        public string HoraSalida
        {
            get { return horario; }
        }
        public double Precio
        {
            get { return precio; }
              
        }
        public Asiento ReservarA(int asiento)//long cuit
        {
            Asiento ret = null;
            if (!asientos[asiento - 1].Ocupado)
            {
                asientos[asiento - 1].Vender(123);
              ret = asientos[asiento - 1];
            }
            return ret; //devuelve true si se hizo la reserva
        }

    }
}
