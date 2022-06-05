using Gestión_de_Recursos_Tecnológicos.Ventanas;
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

namespace Gestión_de_Recursos_Tecnológicos.src.ventanas
{
    public partial class VentanaPrincipal : Form
    {
        private Form formActivo = null;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_cargar_marca_Click(object sender, EventArgs e)
        {
            cargarFormulario(new AgregarMarca());

        }

        private void btn_cargar_modelo_Click(object sender, EventArgs e)
        {
            cargarFormulario(new AgregarModelo());
        }

        private void cargarFormulario(Form nuevoFormulario) {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = nuevoFormulario;
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;

            pan_principal.Controls.Add(nuevoFormulario);
            pan_principal.Tag = nuevoFormulario;
            nuevoFormulario.Show();
        }

        internal static void habilitar()
        {
            VentanaPrincipal principal = new VentanaPrincipal();
            principal.Show();
        }
    }
}
