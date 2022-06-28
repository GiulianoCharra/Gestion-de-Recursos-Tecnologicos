using Gestión_de_Recursos_Tecnológicos.src.clases;
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
    public partial class PantallaMantenimientoCorrectivo : Form
    {
        private static List<ViewRecursoTecnologico> recursos { get; set; }
        private static List<ViewTurnosMantenimiento> turnos { get; set; }


        public PantallaMantenimientoCorrectivo()
        {
            InitializeComponent();            
        }

        public void opcionIngresarEnMC()
        {
            habilidar();
            GestorMantenimientoCorrectivo.opcionIngresarEnMC();
            cargarTablaRecursos();
        }
        /// <summary>
        /// Toma el recurso tecnologico seleccionado de la grilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RTSeleccionado(object sender, DataGridViewCellEventArgs e)
        {
            int idRT = (int)dgv_recursos_asignados.SelectedCells[1].Value;
            GestorMantenimientoCorrectivo.RTSeleccionado(idRT);
        }
        /// <summary>
        /// Toma la fecha prevista de fin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tomarFechaFinPrevista(object sender, EventArgs e)
        {
            TimeSpan fechaFinPrevista = TimeSpan.Parse(dtp_fecha_fin_prevista.Value.Date.ToString());
            GestorMantenimientoCorrectivo.tomarFechaFinPrevista(fechaFinPrevista);
        }
        /// <summary>
        /// Toma la confirmacion del registro del ingreso del recurso en 
        /// mantenimiento correctivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tomarConfirmacion(object sender, EventArgs e)
        {
            GestorMantenimientoCorrectivo.tomarConfirmacion();
        }

        /// <summary>
        /// Muestra la pantalla
        /// </summary>
        /// 
        private void habilidar()
        {
            this.Show();
        }
        /// <summary>
        /// Muestra los recursos tecnologicos asignados
        /// </summary>
        /// <param name="vistaResultados"></param>
        internal static void mostrarRT(List<ViewRecursoTecnologico> vistaResultados)
        {
            recursos = vistaResultados;
        }


        /// <summary>
        /// Muesta los turnos disponibles/pendientes del recurso selseccionado
        /// </summary>
        /// <param name="turnosRT"></param>
        internal static void mostrarTurnos(List<ViewTurnosMantenimiento> turnosRT)
        {
            turnos = turnosRT;
        }
        /// <summary>
        /// Muestra un mensaje solicitando se selseccione un recurso
        /// tecnologico de la grilla
        /// </summary>
        internal static void solicitarSeleccionRT()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Muestra un mensaje solicitando se ingrese una fecha de fin 
        /// de mantenimiento prevista
        /// </summary>
        internal static void solicitarFechaFinPrevista()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Muestra un mensaje solicitando la confirmacion del registro del
        /// mantenimiento
        /// </summary>
        internal static void solicitarConfirmacionMantenimiento()
        {
            throw new NotImplementedException();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarTablaRecursos()
        {
            dgv_recursos_asignados.DataSource = recursos;
        }
        private void cargarTablaTurnos()
        {
            dgv_recursos_asignados.DataSource = recursos;
        }

    }
}
