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
            manejoSubMenu();
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

        private void manejoSubMenu()
        {
            this.panelSubActividad1.Visible = false;
            this.panelSubActividad2.Visible = false;
            this.panelSubActividad3.Visible = false;
            this.panelListIntegrantes.Visible = false;
            //si se agregan mas paneles de sub menu
            adjuntar();
        }

        //el siguente se lo va usar en los button para mostrar y ocultar los botones sub menu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void hideSubMenu()
        {
            if (panelSubActividad1.Visible == true)
                panelSubActividad1.Visible = false;
            if(panelSubActividad2.Visible == true)
                panelSubActividad2.Visible = false;
            if(panelSubActividad3.Visible == true)
                panelSubActividad3.Visible = false;
            if(panelListIntegrantes.Visible == true)
                panelListIntegrantes.Visible = false;
            //si se agrega mas paneles de sub menu
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
            //int Px=panelCentral.Location.X;
            //int Py=panelCentral.Location.Y;
                        
            IconButton buttonAux = this.iconButton1;
            if (MenuVertical.Width == 250)
            {
                ajustarAnchoBoton(this.MenuVertical, 100);
                this.MenuVertical.Width = 105;
                //panelCentral.Location = new Point(Px-145,Py);
                //panelCentral.Size = new Size(1073, 461);

            }
            else
            {
                ajustarAnchoBoton(this.MenuVertical, 245);
                this.MenuVertical.Width = 250;
                //panelCentral.Location = new Point(Px+145,Py);
                //panelCentral.Size = new Size(928,461);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubActividad1);
            //
            //
            //
            //
            adjuntar();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            /*
             escribir codigo
             */
            hideSubMenu();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            /*
             escribir codigo
             */
            hideSubMenu();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            /*
             escribir codigo
             */
            hideSubMenu();
        }

        private void adjuntar()
        {
            if (panelSubActividad1.Visible == false)
            {
                btn_activivdad2.Location = new Point(3, 195);
                if (panelSubActividad2.Visible == false)
                {
                    btn_actividad3.Location = new Point(3, 230);
                    if (panelSubActividad3.Visible == false)
                        btn_integrantes.Location = new Point(3, 265);
                    else
                        btn_integrantes.Location = new Point(3, 558);
                }

            }
            else
            {
                btn_activivdad2.Location = new Point(3,291);
                btn_actividad3.Location = new Point(3,326);
                btn_integrantes.Location = new Point(3,361);
            }
        }
    }
}
