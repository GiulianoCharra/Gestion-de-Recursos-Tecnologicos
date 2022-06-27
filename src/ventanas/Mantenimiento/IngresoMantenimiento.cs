using Gestión_de_Recursos_Tecnológicos.src.Gestores;
using Gestión_de_Recursos_Tecnológicos.src.Ventanas.Mantenimiento;
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
            cargarTabla();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            GestorIngresoRecursoTecnologicoMantenimientoCorrectivo.registrarIngresoMantenimientoCorrectivo();
        }

        private void cargarTabla()
        {
            dgv_recursos_asignados.DataSource = GestorIngresoRecursoTecnologicoMantenimientoCorrectivo.buscarRecursosAsociadosDisponibles();
        }

        internal void mostrarResultados(List<ViewRecursoTecnologico> recursos_tecnologicos_asignadors_disponibles)
        {
            dgv_recursos_asignados.DataSource = recursos_tecnologicos_asignadors_disponibles;
        }
    }
}
