using Gestión_de_Recursos_Tecnológicos.src.Gestores;
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
    public partial class sension : Form
    {
        private int m, mx, my;

        public sension()
        {
            InitializeComponent();
            //txt_pass.UseSystemPasswordChar = true;
        }


        /// <summary>
        /// Minimiza la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Cierra la ventana al hacer click en la X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.cerrar();
        }

        /// <summary>
        /// Cancela el inicio de sesion y cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.cerrar();
        }

        /// <summary>
        /// Cierra la ventana actual
        /// </summary>
        private void cerrar()
        {
            this.Close();
        }

        /// <summary>
        /// Intenta iniar sesion mediante el usuario y contraseña ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txt_user.Text);
            if (validarDatos())
            {
                lbl_error.Text = "Ingrese usuario y contraseña para poder iniciar";
                return;
            }
            if (!validarUsuario())
            {
                lbl_error.Text = "Alguno de los datos ingresados es incorrecto";
                return;
            }

            this.Hide();
            Bienvenido.habilitar();
        }

        /// <summary>
        /// Verifica si 
        /// </summary>
        /// <returns></returns>
        private bool validarDatos()
        {
            return txt_user.Text.Trim() == "" || txt_pass.Text.Trim() == "";
        }


        /// <summary>
        /// Intenta iniciar sesion mediante el usuario y contraseña ingresados,
        /// si existe, es <b>true</b> y si no, es <b>false</b>
        /// </summary>
        /// <returns></returns>
        private bool validarUsuario()
        {
            return GestorIniciarSesion.iniciarSesion(txt_user.Text, txt_pass.Text);
        }

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
    }
}
