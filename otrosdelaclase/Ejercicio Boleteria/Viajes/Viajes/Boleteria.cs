using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Windows.Forms;
using System.Collections;
//

namespace Viajes
{
    class Boleteria
    {
        double recaudacion=0;
        ArrayList viajes = new ArrayList();
        //Micro[] viajes = new Micro[10];
        ArrayList boletos = new ArrayList();
        public void AgregarMicro(Micro viaje)
        {
                viajes.Add(viaje);
        }
        public ArrayList ConsultarHorarios(string destino)
        {
            ArrayList viajesAdestino = new ArrayList();
            foreach (Micro unMicro in viajes)
            {
                if ((unMicro != null) && (unMicro.Destino == destino))
                {
                    viajesAdestino.Add(unMicro);
                }
            }
            return viajesAdestino;   
        }

        public ListBox ConsultarPasaje(string destino, string hora)
        {               
            Asiento[] pasajes;
            bool hayPasajes= false;
            ListBox lbResumen = new ListBox();
            lbResumen.Items.Add("Disponibles");
            

            foreach (Micro unMicro in viajes)
            {
                if ((unMicro != null) &&  ((unMicro.Destino == destino) && (unMicro.HoraSalida== hora)))
                {
                    
                    pasajes = unMicro.ConsultarA();
                    for (int a = 0; a < pasajes.Length; a++)
                    {
                        if (!pasajes[a].Ocupado)
                        {
                            hayPasajes = true;
                            lbResumen.Items.Add((a + 1).ToString());
                        }
                    }
                }
             
            }
            if (!hayPasajes) lbResumen.Items.Add("No hay asientos");
            return lbResumen;
        }
        public void VenderPasaje(Micro unMicro, int asiento)
        {
            Pasaje nuevoBoleto;
            Asiento pasajeVendido = unMicro.ReservarA(asiento);
            nuevoBoleto = new Pasaje(unMicro, pasajeVendido);
            recaudacion += pasajeVendido.Precio;
        }
        public string Cantidad
        {
            get 
                {
                    return "Micros cargados: " + viajes.Count.ToString();               
                }
        }
        
    }

}

