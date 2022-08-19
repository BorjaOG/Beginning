using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosPersonales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Apellido = txbApellido.Text;
            string Nombre = txbNombre.Text;
            string Edad = txbEdad.Text;
            string Direccion = txbDireccion.Text;

            if (txbApellido.Text == "")
            txbApellido.BackColor = Color.Red;
            else if (txbNombre.Text == "")
            txbNombre.BackColor = Color.Red;
            else if (txbEdad.Text == "")
            txbEdad.BackColor = Color.Red;
            else if (txbDireccion.Text == "")
            txbDireccion.BackColor = Color.Red;

            textBox1.Text = Nombre.ToUpper() + " " + Apellido.ToUpper() + Environment.NewLine + Edad.ToUpper() + Environment.NewLine + Direccion.ToUpper();
        }

        private void txbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
