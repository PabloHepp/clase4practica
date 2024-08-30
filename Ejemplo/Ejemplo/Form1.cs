using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        private Numeros misValores;
        private int[] nValores;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            lista.Items.Clear();
            
            //opcion 1:
            /*
            if (tBcantidad.Text != "")
            {
               int c = Convert.ToInt32(tBcantidad.Text);
            }
            
            else misValores = new Numeros();
            */ 

            //opcion 2: 
            bool ver = int.TryParse(tBcantidad.Text, out int c);//con esto trata de llamarlo y si esta vacio pone 5
            if (ver) //verifica si se pudo realizar la conversion , si "ver" es true
                misValores = new Numeros(c);
            else
                misValores = new Numeros(); //llama al constructor vacio, y crea un vector de 5 posiciones


            nValores[0] = 1000;
            nValores = misValores.Valores();
                        
            for (int n = 0; n < nValores.Length; n++)
                lista.Items.Add("Posición: " + n.ToString("00") + " Valor: " + nValores[n].ToString());
            //Con foreach
            foreach (int a in nValores)
            {
                lista.Items.Add($"Valor: {a.ToString()}");
            }

            this.Text = misValores.CANTIDAD.ToString();
            //misValores.CANTIDAD = 4;
        }



        private void tBcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) // esto no lo va a tomar, pero es para discriminar digitos 
            {
                e.Handled = false; //aca asumo que la tecla es invalida, y oculto la tecla
                if (e.KeyChar == 13) button1.PerformClick();//aca le digo que si apreto enter ejecute el boton, char 13 es el enter
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tBcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
