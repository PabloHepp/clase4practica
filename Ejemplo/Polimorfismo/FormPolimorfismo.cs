using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class FormPolimorfismo : Form
    {
        public FormPolimorfismo()
        {
            InitializeComponent();
        }
        List<Persona> listado = new List<Persona>();
        
        private void bCrear_Click(object sender, EventArgs e)
        {
            if (rBpersona.Checked)
            {
                listado.Add(new Profesor(tBnombre.Text,123));
            }
            else
            {
                listado.Add(new Estudiante(tBnombre.Text));
            }

            tBnombre.Clear();
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listado.Sort();
            string linea;
            foreach (Persona p in listado)
            {
                listBox1.Items.Add(p.Identificar());
                
                /*
                linea = p.Identificar();
                
                if (p is Estudiante)
                {
                    linea += ((Estudiante)p).Dni;

                }
                else if (p is Profesor)
                {
                    linea += ((Profesor)p).Dni;
                }
                */

                //listBox1.Items.Add(linea);
            }
        }
    }
}
