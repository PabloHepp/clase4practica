using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace EjemploPiezas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList piezas = new ArrayList();

        public void Mostar()
        {
            foreach (Pieza p in piezas)
            { 
               int[] posicion = p.VerPosicion();
               listBox1.Items.Add(p.Nombre() + " x: " + posicion[0] + " y: " + posicion[1]);
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            piezas.Add(new Peon(2,2,"Peon caballo izquiero"));
            piezas.Add(new Peon(7,2,"Peon caballo derecho"));
            piezas.Add(new Alfil("Alfil Reina",3,1));
            Mostar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            int y = Convert.ToInt16(textBox2.Text);
            foreach (Pieza p in piezas)
            {
                if (!p.Mover(x, y))
                {
                    MessageBox.Show("No valido");
                }
            }
            Mostar();
        }
    }
}
