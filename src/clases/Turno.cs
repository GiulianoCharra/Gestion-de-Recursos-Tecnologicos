using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Turno
    {
        public int id_turno { get; set; }
        public int id_recurso_tecnologico { get; set; }
        public int id_cientifico { get; set; }
        public PersonalCientifico id_personal_cientifico { get; set; }
        public int id_centro_investigacion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public TimeSpan hora_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public TimeSpan hora_fin { get; set; }
        public List<HistorialTurno> historiales_turnos { get; set; }

        public Turno(int id_turno, int id_recurso_tecnologico, int id_cientifico, PersonalCientifico personal_cientifico, int id_centro_investigacion, DateTime fecha_inicio, TimeSpan hora_inicio, DateTime fecha_fin, TimeSpan hora_fin, List<HistorialTurno> historiales_turnos)
        {
            this.id_turno = id_turno;
            this.id_recurso_tecnologico = id_recurso_tecnologico;
            this.id_cientifico = id_cientifico;
            this.id_personal_cientifico = personal_cientifico;
            this.id_centro_investigacion = id_centro_investigacion;
            this.fecha_inicio = fecha_inicio;
            this.hora_inicio = hora_inicio;
            this.fecha_fin = fecha_fin;
            this.hora_fin = hora_fin;
            this.historiales_turnos = historiales_turnos;
        }

        public Turno(int id_turno, int id_recurso_tecnologico, int id_cientifico, int id_personal_cientifico, int id_centro_investigacion, DateTime fecha_inicio, TimeSpan hora_inicio, DateTime fecha_fin, TimeSpan hora_fin)
        : this(
            id_turno,
            id_recurso_tecnologico,
            id_cientifico,
            PersonalCientifico.buscarPorIdPersonalCientifico(id_personal_cientifico),
            id_centro_investigacion,
            fecha_inicio,
            hora_inicio,
            fecha_fin,
            hora_fin,
            HistorialTurno.buscarByIdTurno(id_turno))
            {
        }

        internal static List<Turno> buscarTurnosReservadosPendientes(int id_recurso_tecnologico, DateTime fecha_fin_prevista)
        {
            List<Turno> turnos = buscarByIdRecursoTecnologicoAndFechaInicio(id_recurso_tecnologico, fecha_fin_prevista);
            List<Turno> turnosReservadosPendientes = new List<Turno>();
            turnos.ForEach(t =>
            {
                HistorialTurno actual = buscarHistorialActual(t.historiales_turnos);
                if (actual != null)
                {
                    if (actual.esEnEstadoPendiente() || actual.esEnEstadoReservado())
                    {
                        turnosReservadosPendientes.Add(t);
                    }
                }
            });
            return turnosReservadosPendientes;
        }
        internal static List<Turno> buscarByIdRecursoTecnologicoAndFechaInicio(int id_recurso_tecnologico, DateTime fecha_fin_prevista)
        {
            return DBTurno.findByIdRecursoTecnologicoAndMenorFechaInicio(id_recurso_tecnologico, fecha_fin_prevista);
        }


        private static HistorialTurno buscarHistorialActual(List<HistorialTurno> historiales_turnos)
        {
            foreach (HistorialTurno ht in historiales_turnos)
            {
                if (ht.esAtual())
                {
                    return ht;
                }
            }
            return null;
        }

        private bool esEstadoActualReservado()
        {
            return historiales_turnos.Last().esEnEstadoPendiente();
        }

        private bool esEstadoActualPendiente()
        {
            return historiales_turnos.Last().esEnEstadoPendiente();
        }

        internal void actualizarEstado(Estado estado, DateTime fecha_hora_actual)
        {
            HistorialTurno actual = HistorialTurno.getLast(historiales_turnos);
            actual.finalizar(fecha_hora_actual);
            HistorialTurno.actualizar(actual);
            HistorialTurno nuevo = new HistorialTurno(id_turno, estado, fecha_hora_actual, DateTime.MinValue);
            historiales_turnos.Add(nuevo);
            HistorialTurno.insertarNuevo(nuevo);
        }
    }
}
