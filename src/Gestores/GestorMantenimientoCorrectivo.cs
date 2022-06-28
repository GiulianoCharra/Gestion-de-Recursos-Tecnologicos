using Gestión_de_Recursos_Tecnológicos.src.clases;
using Gestión_de_Recursos_Tecnológicos.src.Ventanas.Mantenimiento;
using Gestión_de_Recursos_Tecnológicos.Ventanas.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Gestores
{
    internal class GestorMantenimientoCorrectivo
    {
        private static Usuario user_actual { get; set; }
        private static ResponsableTecnico responsable { get; set; }
        private static List<RecursoTecnologico> recursosAsignadosDisponibles { get; set; }
        private static RecursoTecnologico recursoSeleccionado { get; set; }
        private static DateTime fecha_fin_prevista { get; set; }
        private static List<Turno> turnos { get; set; }



        private static List<ViewRecursoTecnologico> vistaResultados { get; set; }
        private static List<ViewTurnosMantenimiento> vistaTurnos { get; set; }
        private static Estado estadoTurnoCanceladoPorMC { get; set; }
        private static Estado estadoRecursoConIngresoEnMC { get; set; }
        private static DateTime fecha_hora_actual { get; set; }

        public GestorMantenimientoCorrectivo()
        {

        }
        /// <summary>
        /// Inicia el cu, iniciando por la busqueda de los datos del usuarios logueado y asi poder
        /// encontrar los recursos que tenga asiganados
        /// </summary>
        internal static void opcionIngresarEnMC()
        {
            buscarResponsable();
            buscarRecursosAsociadosDisponibles();
            PantallaMantenimientoCorrectivo.mostrarRT(vistaResultados);
            PantallaMantenimientoCorrectivo.solicitarSeleccionRT();
        }
        /// <summary>
        /// Guardo el Recurso Tecnologico seleccionado
        /// </summary>
        /// <param name="idRT"></param>
        internal static void RTSeleccionado(int idRT)
        {
            foreach (RecursoTecnologico rt in recursosAsignadosDisponibles)
            {
                if (rt.id_recurso_tecnologico == idRT)
                {
                    recursoSeleccionado = rt;
                    break;
                }
            }
            PantallaMantenimientoCorrectivo.solicitarFechaFinPrevista();
        }
        /// <summary>
        /// Toma la fecha de fin prevista y se procede a buscar los turnos
        /// </summary>
        /// <param name="fechaFinPrevista"></param>
        internal static void tomarFechaFinPrevista(DateTime fechaFinPrevista)
        {
            fecha_fin_prevista = fechaFinPrevista;
            verificarTurnosRTSeleccionado();
            PantallaMantenimientoCorrectivo.mostrarTurnos(vistaTurnos);
            PantallaMantenimientoCorrectivo.solicitarConfirmacionMantenimiento();
        }
        /// <summary>
        /// Toma la confirmacion del registro y procede a realizar las tareas necesaria
        /// para poder registrar
        internal static void tomarConfirmacion()
        {
            generarMantenimiento();
        }

        /// <summary>
        /// Se realiza tanto el registro del mantenimiento como la actualizacion de los
        /// turnos y el recurso
        /// </summary>
        private static void generarMantenimiento()
        {
            List<Estado> estadosTurno = Estado.buscarByAmbitoTurno();
            List<Estado> estadoRecurso = Estado.buscarByAmbitoRecursoTecnologico();
            
            estadosTurno.ForEach(et =>
            {
                if (et.esCanceladoPorMantenimientoCorrectivo())
                {
                    estadoTurnoCanceladoPorMC = et;
                }
            });
            estadoRecurso.ForEach(er =>
            {
                if (er.esConIngresoEnMantenimientoCorrectivo())
                {
                    estadoRecursoConIngresoEnMC = er;
                }
            });

            getFechaActual();
            actualizarEstadoTurnos();
            actualizarEstadoRT();
        }
        /// <summary>
        /// Se encarga de actualizar el estado del Recurso Tecnologico seleccionado
        /// </summary>
        private static void actualizarEstadoRT()
        {
            recursoSeleccionado.actualizarEstado(estadoRecursoConIngresoEnMC, fecha_hora_actual);
        }
        /// <summary>
        /// Obtiene la fecha y hora actual
        /// </summary>
        private static void getFechaActual()
        {
            fecha_hora_actual = DateTime.Now;
        }
        /// <summary>
        /// Realiza la actualizacion de los turnos a cancelados por mantenimiento correctivo
        /// </summary>
        private static void actualizarEstadoTurnos()
        {
            turnos.ForEach(t =>
            {
                t.actualizarEstado(estadoTurnoCanceladoPorMC, fecha_hora_actual);
            });
        }
        /// <summary>
        /// Busca los Turnos Pendientes/Reservados del recurso seleccionado y que esten 
        /// dentro de la fecha fin prevista
        /// </summary>
        private static void verificarTurnosRTSeleccionado()
        {
            turnos = new List<Turno>();
            turnos = Turno.buscarTurnosReservadosPendientes(recursoSeleccionado.id_recurso_tecnologico, fecha_fin_prevista);
            buildTurnosParaMostrar();
        }
        /// <summary>
        /// Construye en base a los turnos lo que se mandara a la pantalla
        /// en el formato que se mostrara
        /// </summary>
        private static void buildTurnosParaMostrar()
        {
            vistaTurnos = new List<ViewTurnosMantenimiento>();

            foreach (Turno t in turnos)
            {
                string apellidoNombre =
                    t.id_personal_cientifico.apellidos + " " +
                    t.id_personal_cientifico.nombres;

                vistaTurnos.Add(new ViewTurnosMantenimiento(apellidoNombre, t.fecha_inicio, t.hora_inicio));
            }
        }
        /// <summary>
        /// Busca el responsable tecnico que se encuentra logueado actualmente
        /// </summary>
        private static void buscarResponsable()
        {
            user_actual = Sesion.sesionActual().usuario;
            if (!user_actual.esUsuarioResponsableTecnico())
            {
                return;
            }
            responsable = ResponsableTecnico.buscarPorUsuario(user_actual);
        }
        /// <summary>
        /// Buscar los recursos tecnologicos asociados al responsable tecnico actual
        /// </summary>
        internal static void buscarRecursosAsociadosDisponibles()
        {
            int id_responsable_tecnico = responsable.id_responsable_tecnico;
            int id_personal_cientifico = responsable.personal_cientifico.legajo;
            int id_centro_investigacion = responsable.id_centro_investigacion;

            recursosAsignadosDisponibles = RecursoTecnologico.buscarRTAsociadosDisponibles(id_responsable_tecnico, id_personal_cientifico, id_centro_investigacion);
            buildVistaRT();
        }
        /// <summary>
        /// COntruye una lista de vistas en base a los recursos asignados para que puedan ser mostrados
        /// </summary>
        private static void buildVistaRT()
        {
            vistaResultados = new List<ViewRecursoTecnologico>();

            foreach (RecursoTecnologico rt in recursosAsignadosDisponibles)
            {
                vistaResultados.Add(new ViewRecursoTecnologico(rt.tipo_recurso_tecnologico.nombre, rt.id_recurso_tecnologico, rt.marca.nombre, rt.modelo.nombre));
            }
        }
    }
}
