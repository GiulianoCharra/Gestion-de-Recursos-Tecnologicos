using Gestión_de_Recursos_Tecnológicos.src.clases;
using Gestión_de_Recursos_Tecnológicos.src.Comun;
using Gestión_de_Recursos_Tecnológicos.src.ventanas;
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
    public partial class Bienvenido : Form
    {
        public object ResponsableTecnivo { get; private set; }

        public Bienvenido()
        {
            InitializeComponent();
        }
                
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                VentanaPrincipal.habilitar();
            }
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            Usuario user = Cache.sesionActual.usuario;
            ResponsableTecnico.buscarResponsableTecnicoPorUsuario(user);

            string name = 
            lblUsuario.Text = "";//Seleccionar usario logueado
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            timer1.Start();
        }

        internal static void habilitar()
        {
            Bienvenido saludo = new Bienvenido();
            saludo.ShowDialog();
        }
    }
}
