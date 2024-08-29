using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using System.Collections;
//

namespace Viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boleteria unaBoleteria = new Boleteria();
        ArrayList coches = new ArrayList();


 
        private void bAgregar_Click(object sender, EventArgs e)
        {
            Fmicros vMicros = new Fmicros();

            
            if (vMicros.ShowDialog() == DialogResult.OK)
            {
                string destino = vMicros.tBdestino.Text;
                
                Micro nuevoMicro = new Micro(destino,
                                             Convert.ToInt32(vMicros.tBasientos.Text),
                                             Convert.ToDouble(vMicros.tBprecio.Text),
                                             vMicros.tBhoraio.Text,
                                             Convert.ToInt32(vMicros.tBcodigo.Text) );
                unaBoleteria.AgregarMicro(nuevoMicro);
               
                lCmicros.Text = unaBoleteria.Cantidad; //lee los micros cargados
                
                if (!cBdestinos.Items.Contains(destino)) cBdestinos.Items.Add(destino);

            }
            vMicros.Dispose();
        }

        private void bConsultar_Click(object sender, EventArgs e)
        {
            lBhorarios.Items.Clear();
            coches.Clear(); 
            coches = unaBoleteria.ConsultarHorarios(cBdestinos.Text);

            foreach (Micro unMicro in coches)
                    {
                        lBhorarios.Items.Add("Hora: "+unMicro.HoraSalida+" $ "+unMicro.Precio);//tipo
                    }
            
 
        }

        private void lBdisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string destino = cBdestinos.Text;
            string hora = lBhorarios.Text;
            int asiento;// = Convert.ToInt32(lBdisponibles.Items[lBdisponibles.SelectedIndex]);

            if (int.TryParse(lBdisponibles.Text, out asiento))
                {
                    Fboleto vBoleto = new Fboleto();
                    Micro unCole = (Micro)coches[lBhorarios.SelectedIndex];
                    vBoleto.listBox1.Items.Add("Fecha: " + DateTime.Now.ToString());
                    vBoleto.listBox1.Items.Add("Destino: " + destino);
                    vBoleto.listBox1.Items.Add("Horario de salida: " + hora);
                    vBoleto.listBox1.Items.Add("Asiento Numero: " + asiento.ToString());
                    vBoleto.listBox1.Items.Add("Precio: " + unCole.Precio.ToString("0.00"));
                    if (vBoleto.ShowDialog() == DialogResult.OK)
                    {                          
                         unaBoleteria.VenderPasaje(unCole, asiento);
                    }

                    LimpiarListaAsientos(); 
                    vBoleto.Dispose();
                }
            else
                this.Text = "No válido";

        }

        private void LimpiarListaAsientos()
        {
            lBdisponibles.Items.Clear();
            Micro unCole = (Micro)coches[lBhorarios.SelectedIndex];

            lBdisponibles.Items.AddRange(unaBoleteria.ConsultarPasaje(cBdestinos.Text, unCole.HoraSalida).Items);
        }
 

        private void lBhorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            LimpiarListaAsientos();
        }
    }
}
