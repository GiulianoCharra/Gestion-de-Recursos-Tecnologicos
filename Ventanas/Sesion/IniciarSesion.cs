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
        }

        private void lbl_recuperar_contraseña_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (!GestorIniciarSesion.iniciarSesion(txt_usuario.Text, txt_contraseña.Text))
            {
                lbl_datos_incorrectos.Text = "Alguno de los datos ingresados es incorrecto";
            }
        }
    }
}
