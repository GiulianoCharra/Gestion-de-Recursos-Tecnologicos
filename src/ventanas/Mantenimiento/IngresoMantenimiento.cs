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

namespace Gestión_de_Recursos_Tecnológicos.Ventanas.Mantenimiento
{
    public partial class IngresoMantenimiento : Form
    {
        public IngresoMantenimiento()
        {
            InitializeComponent();
            GestorIngresoRecursoTecnologicoMantenimientoCorrectivo.buscarRecursosAsociados();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
