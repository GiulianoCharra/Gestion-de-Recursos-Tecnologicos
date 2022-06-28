using Gestión_de_Recursos_Tecnológicos.src.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class HistorialRecursoTecnologico
    {
        public int id_recurso_tecnologico { set; get; }
        public Estado estado { get; set; }
        public DateTime fecha_hora_inicio { get; set; }
        public DateTime fecha_hora_fin { get; set; }


        public HistorialRecursoTecnologico(int id_recurso_tecnologico, Estado estado)
            :this(id_recurso_tecnologico, estado, DateTime.Now, DateTime.MinValue)
        {
        }
        public HistorialRecursoTecnologico(int id_recurso_tecnologico, int id_estado, DateTime fecha_hora_inicio)
            :this(id_recurso_tecnologico, Estado.buscarByIdEstado(id_estado), fecha_hora_inicio)
        {
        }
        public HistorialRecursoTecnologico(int id_recurso_tecnologico, Estado estado, DateTime fecha_hora_inicio)
            :this(id_recurso_tecnologico, estado, fecha_hora_inicio, DateTime.MinValue)
        {
        }
        public HistorialRecursoTecnologico(int id_recurso_tecnologico, int id_estado, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
            :this(id_recurso_tecnologico, Estado.buscarByIdEstado(id_estado), fecha_hora_inicio, fecha_hora_fin)
        {
        }
        public HistorialRecursoTecnologico(int id_recurso_tecnologico, Estado estado, DateTime fecha_hora_inicio, DateTime fecha_hora_fin
            )
        {
            this.id_recurso_tecnologico = id_recurso_tecnologico;
            this.estado = estado;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }



        internal bool esEnEstadoDisponible()
        {
            return estado.esDisponible();
        }
        internal void finalizar(DateTime fecha_hora_actual)
        {
            fecha_hora_fin = fecha_hora_actual;
        }
        internal static HistorialRecursoTecnologico getLast(List<HistorialRecursoTecnologico> historial_recursos)
        {
            foreach (HistorialRecursoTecnologico hr in historial_recursos)
            {
                if (hr.esAtual())
                {
                    return hr;
                }
            }
            return null;
        }
        private bool esAtual()
        {
            return fecha_hora_fin == DateTime.MinValue;
        }

        internal static List<HistorialRecursoTecnologico> buscarByIdRecursoTecnologico(int id_recurso_tecnologico)
        {
            return DBHistorialRecursoTecnologico.findByIdRecursoTecnologico(id_recurso_tecnologico);
        }
        internal static void insertarNuevo(HistorialRecursoTecnologico nuevo)
        {
            DBHistorialRecursoTecnologico.insert(nuevo.id_recurso_tecnologico, nuevo.estado.id_estado, nuevo.fecha_hora_inicio);
        }
        internal static void actualizar(HistorialRecursoTecnologico actual)
        {
            DBHistorialRecursoTecnologico.update(actual.id_recurso_tecnologico, actual.estado.id_estado, actual.fecha_hora_inicio, actual.fecha_hora_fin);

        }
    }
}
