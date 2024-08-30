using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList personas = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            personas.Add(new Persona("Juan Perez"));
            personas.Add(new Profesional("Luis Alba","Abogado"));
            personas.Add(new Profesor("Ana Fernandez", "Matematica"));
            

            foreach (Persona p in personas)
            {
                listBox1.Items.Add(p.VerStado());            
            }

        }
    }
}
