using FontAwesome.Sharp;
using Gestión_de_Recursos_Tecnológicos.Ventanas.Mantenimiento;
using Gestión_de_Recursos_Tecnológicos.Ventanas.Marca;
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
    public partial class VentanaPrincipal : Form
    {

        private Form activeForm = null;

        public VentanaPrincipal()
        {
            InitializeComponent();
            manejoSubMenu();
            FormResize();
        }

        internal static void habilitar()
        {
            VentanaPrincipal principal = new VentanaPrincipal();
            principal.Show();
        }

        private void VentanaPrueba_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
            //this.panelListIntegrantes.Location=new Point(3,560);
            //btn_actividad2.Location = new Point(3, 195);
            //btn_actividad3.Location = new Point(3, 230);
            //btn_integrantes.Location = new Point(3, 569);
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
            //if (panelListIntegrantes.Visible == true)
            //    panelListIntegrantes.Visible = false;
            //si se agrega mas paneles de sub menu
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            IconButton buttonAux = this.btn_actividad1;
            if (MenuVertical.Width == 250)
            {
                ajustarAnchoBoton(this.MenuVertical, 90);
                this.MenuVertical.Width = 95;
                btn_menu.Location = new Point(50, 3);
                btn_menu.IconChar = IconChar.AngleDoubleRight;
                btn_Inicio.Text = "";
                btn_actividad1.Text = "";
                btn_act1_sub1.Text = "";
                btn_act1_sub2.Text = "";
                btn_act1_sub3.Text = "";
                btn_integrantes.Text = "";
                btn_Inicio.ImageAlign = ContentAlignment.MiddleCenter;
                btn_actividad1.ImageAlign = ContentAlignment.MiddleCenter;
                btn_integrantes.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                ajustarAnchoBoton(this.MenuVertical, 245);
                this.MenuVertical.Width = 250;
                btn_menu.Location = new Point(200, 3);
                btn_menu.IconChar = IconChar.AngleDoubleLeft;
                btn_Inicio.Text = "Inicio";
                btn_actividad1.Text = "Recurso Tecnologico";
                btn_act1_sub1.Text = "Ingresar Mantenimiento";
                btn_act1_sub2.Text = "Marca";
                btn_act1_sub3.Text = "Modelo";
                btn_integrantes.Text = "Infomarcion";
                btn_Inicio.ImageAlign = ContentAlignment.MiddleLeft;
                btn_actividad1.ImageAlign = ContentAlignment.MiddleLeft;
                btn_integrantes.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
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
        private void FormResize()
        {
            if (activeForm != null)
            {
                //activeForm.WindowState = FormWindowState.Normal;
                activeForm.WindowState = FormWindowState.Maximized;
            }
        }       
        private int m, mx, my;
        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }
        private void panelBarra_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }
        private void btn_integrantes_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Info());
            panelCentral.AutoScroll = true;

            //
            //
            //            
            //adjuntar();                      
        }
        private void btn_actividad1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubActividad1);
            //
            //
            //
            //
            //adjuntar();
        }
        private void btn_act1_sub1_Click(object sender, EventArgs e)
        {
            openChildForm(new IngresoMantenimiento());
        }
        private void btn_act1_sub2_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarMarca());
        }
        private void btn_act1_sub3_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarModelo());
        }

    }
}
