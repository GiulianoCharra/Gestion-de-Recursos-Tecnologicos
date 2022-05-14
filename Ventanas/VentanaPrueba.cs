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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
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
            btn_activivdad2.Location = new Point(3, 195);
            btn_actividad3.Location = new Point(3, 230);
            btn_integrantes.Location = new Point(3, 265);
            //si se agregan mas paneles de sub menu
            //adjuntar();
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
            if (panelListIntegrantes.Visible == true)
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
            IconButton buttonAux = this.btn_actividad1;
            if (MenuVertical.Width == 250)
            {
                ajustarAnchoBoton(this.MenuVertical, 100);
                this.MenuVertical.Width = 105;
                btn_menu.IconChar = IconChar.AngleDoubleRight;
                btn_Inicio.Text = "";
                btn_Inicio.ImageAlign=ContentAlignment.MiddleCenter;                
                btn_actividad1.ImageAlign = ContentAlignment.MiddleCenter;
                btn_activivdad2.ImageAlign = ContentAlignment.MiddleCenter;
                btn_actividad3.ImageAlign = ContentAlignment.MiddleCenter;
                btn_integrantes.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                ajustarAnchoBoton(this.MenuVertical, 245);
                this.MenuVertical.Width = 250;
                btn_menu.IconChar = IconChar.AngleDoubleLeft;
                btn_Inicio.Text = "Inicio";
                btn_Inicio.ImageAlign=ContentAlignment.MiddleLeft;
                btn_actividad1.ImageAlign = ContentAlignment.MiddleLeft;
                btn_activivdad2.ImageAlign = ContentAlignment.MiddleLeft;
                btn_actividad3.ImageAlign = ContentAlignment.MiddleLeft;
                btn_integrantes.ImageAlign = ContentAlignment.MiddleLeft;
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
            openChildForm(new frm_recursoTecnologico());
            /*
             escribir codigo
             */
            //hideSubMenu();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            /*
             escribir codigo
             */
            //hideSubMenu();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            /*
             escribir codigo
             */
            //hideSubMenu();
        }

        private void btn_activivdad2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubActividad2);
            //
            //
            //            
            adjuntar();
        }

        private void btn_actividad3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubActividad3);
            //
            //
            //            
            adjuntar();
        }
        
        private void btn_integrantes_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelListIntegrantes);
            openChildForm(new frm_Informacion());
            //
            //
            //            
            adjuntar();                      
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
                    {
                        btn_integrantes.Location = new Point(3, 265);
                        if (panelListIntegrantes.Visible == true)
                            panelListIntegrantes.Location = new Point(3, 300);
                    }
                    else
                    {
                        panelSubActividad3.Location = new Point(3, 265);
                        btn_integrantes.Location = new Point(3, 366);
                    }                        
                }
                else
                {   
                    panelSubActividad2.Location = new Point(3, 230);
                    btn_actividad3.Location = new Point(3, 331);
                    btn_integrantes.Location = new Point(3, 366);
                }                
            }
            else
            {
                btn_activivdad2.Location = new Point(3, 291);
                btn_actividad3.Location = new Point(3, 326);
                btn_integrantes.Location = new Point(3, 361);
            }
        }

        private Form activeForm=null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void fechaActual_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
