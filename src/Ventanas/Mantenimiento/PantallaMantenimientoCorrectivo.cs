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
            habilitar();
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
            btn_buscar_turnos.Enabled = true;
            dtp_fecha_fin_prevista.Enabled = true;
        }
        /// <summary>
        /// Toma la fecha prevista de fin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tomarFechaFinPrevista(object sender, EventArgs e)
        {
            DateTime fechaFinPrevista = DateTime.Parse(dtp_fecha_fin_prevista.Value.ToShortDateString());
            if (fechaFinPrevista == DateTime.Today)
            {
                MessageBox.Show("Por favor seleccione una fecha mayor a la actual", "Para continuar");
                return;
            }
            GestorMantenimientoCorrectivo.tomarFechaFinPrevista(fechaFinPrevista);
            cargarTablaTurnos();
            btn_aceptar.Enabled = true;
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
            MessageBox.Show("FIN");
            this.Close();
        }

        /// <summary>
        /// Muestra la pantalla
        /// </summary>
        /// 
        private void habilitar()
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
            MessageBox.Show("Por favor seleccione un Recurso", "Para continuar");
        }
        /// <summary>
        /// Muestra un mensaje solicitando se ingrese una fecha de fin 
        /// de mantenimiento prevista
        /// </summary>
        internal static void solicitarFechaFinPrevista()
        {
            MessageBox.Show("Ahora si es tan amable de seleccionar una fecha", "Para continuar");
        }
        /// <summary>
        /// Muestra un mensaje solicitando la confirmacion del registro del
        /// mantenimiento
        /// </summary>
        internal static void solicitarConfirmacionMantenimiento()
        {
            MessageBox.Show("Ahora solo tiene que apretar en el boton aceptar, HAGALO", "Para Finalizar");
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
            dgv_turnos.DataSource = turnos;
        }

    }
}
