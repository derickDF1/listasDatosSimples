using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listasDatosSimples
{
    public partial class Form1 : Form
    {
        List<int> listaEnteros = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            // Arreglo int numeros[10];

            //Lista
            if (textBoxIngreso.Text == string.Empty)
            {
                MessageBox.Show("Error, no ha ingresado un valor");
                textBoxIngreso.Select();
            }
            else
            {
                int numero = 0;
                bool seConvirtio = int.TryParse(textBoxIngreso.Text, out numero);
                if (seConvirtio)
                {
                    listaEnteros.Add(numero);
                    textBoxIngreso.Text = "";
                    textBoxIngreso.Select();
                }
                else
                {
                    MessageBox.Show("Error, el valor debe ser numerico");
                    textBoxIngreso.Text = "";
                    textBoxIngreso.Select();
                }
            }
        }

        public void Mostrar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = listaEnteros;
            listBox1.Refresh();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            /* Primera forma de mostrar los datos en el list box
            for (int i = 0; i < listaEnteros.Count; i++)
            {
                listBox1.Items.Add(listaEnteros[i]);
            }
            */
            Mostrar();
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            listaEnteros.Sort();
            Mostrar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int numero = 0;

            bool seConvirtio = int.TryParse(textBoxIngreso.Text, out numero);

            if (seConvirtio)
            {
                listaEnteros.Remove(numero);
                Mostrar();
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero");
            }
        }

        private void buttonOrdenarDes_Click(object sender, EventArgs e)
        {
            listaEnteros.Reverse();
            Mostrar();
        }
    }
}
