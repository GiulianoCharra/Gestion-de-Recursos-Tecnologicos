using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class HistorialTurno
    {
        private int id_turno { get; set; }
        private Estado estado { get; set; }
        private DateTime fecha_hora_inicio { get; set; }
        private DateTime fecha_hora_fin { get; set; }

        public HistorialTurno(int id_turno, int id_estado, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        :this(id_turno, Estado.buscarByIdEstado(id_estado) , fecha_hora_inicio,fecha_hora_fin)
        {
            
        }
        public HistorialTurno(int id_turno, Estado estado, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            this.id_turno = id_turno;
            this.estado = estado;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }


        internal bool esEnEstadoPendiente()
        {
            return estado.esPendiente();
        }
        internal bool esEnEstadoReservado()
        {
            return estado.esReservado();
        }
        public static HistorialTurno getLast(List<HistorialTurno> historial_turnos)
        {
            foreach (HistorialTurno ht in historial_turnos)
            {
                if (ht.esAtual())
                {
                    return ht;
                }
            }
            return null;
        }
        internal bool esAtual()
        {
            return fecha_hora_fin == DateTime.MinValue;
        }
        internal void finalizar(DateTime fecha_hora_actual)
        {
            this.fecha_hora_fin = fecha_hora_actual;
        }

        internal static List<HistorialTurno> buscarByIdTurno(int id_turno)
        {
           return DBHistorialTurno.findByIdTurno(id_turno);
        }
        internal static void insertarNuevo(HistorialTurno nuevo)
        {
            DBHistorialTurno.insert(nuevo.id_turno, nuevo.estado.id_estado, nuevo.fecha_hora_inicio);
        }
        internal static void actualizar(HistorialTurno actual)
        {
            DBHistorialTurno.update(actual.id_turno, actual.estado.id_estado, actual.fecha_hora_inicio, actual.fecha_hora_fin);
        }
    }
}
