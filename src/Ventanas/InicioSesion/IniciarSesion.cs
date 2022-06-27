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

namespace Gestión_de_Recursos_Tecnológicos.Ventanas.Sesion
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
            txt_contraseña.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Intenta iniar sesion mediante el usuario y contraseña ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text.Trim() == "" || txt_contraseña.Text.Trim() == "")
            {
                lbl_datos_incorrectos.Text = "Ingrese usuario y contraseña para poder iniciar";
                return;
            }

            if (!GestorIniciarSesion.iniciarSesion(txt_usuario.Text, txt_contraseña.Text))
            {
                lbl_datos_incorrectos.Text = "Alguno de los datos ingresados es incorrecto";
            }

            Bienvenido bienvenido = new Bienvenido();
            bienvenido.ShowDialog();
            
            this.Hide();
        }
        /// <summary>
        /// Cancela el inicio de sesion y cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// CONTRUYENDO
        /// Permite recuperar la contraseña enviando un mail al personal cientifico
        /// asociado al usuario ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llbl_recuperar_contraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
