using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Recursos_Tecnológicos.Ventanas
{
    public partial class VentanaPrueba : Form
    {
        public VentanaPrueba()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Reajusta el ancho de los botoner de un contenedor
        /// </summary>
        /// <param name="container">Contenedor que contiene botones</param>
        /// <param name="w">el nuevo ancho que tendran los botones</param>
        private void ajustarAnchoBoton(Control container, int w)
        {
            foreach (Control b in container.Controls)
            {
                if (b is IconButton)
                    b.Width = w;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaPrueba_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            IconButton buttonAux = this.iconButton1;
            if (MenuVertical.Width == 250)
            {
                ajustarAnchoBoton(this.MenuVertical, 55);
                this.MenuVertical.Width = 60;

            }
            else
            {
                ajustarAnchoBoton(this.MenuVertical, 245);
                this.MenuVertical.Width = 250;
            }
        }
    }
}
