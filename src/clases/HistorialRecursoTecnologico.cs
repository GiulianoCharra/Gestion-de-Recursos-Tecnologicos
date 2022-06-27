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
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }


        public HistorialRecursoTecnologico(int id_recurso_tecnologico, Estado estado)
            :this(id_recurso_tecnologico, estado, DateTime.Now, DateTime.MinValue)
        {
        }
        public HistorialRecursoTecnologico(int id_recurso_tecnologico, int id_estado, DateTime fecha_inicio)
            :this(id_recurso_tecnologico, Estado.buscarByIdEstado(id_estado), fecha_inicio)
        {
        }
        public HistorialRecursoTecnologico(int id_recurso_tecnologico, Estado estado, DateTime fecha_inicio)
            :this(id_recurso_tecnologico, estado, fecha_inicio, DateTime.MinValue)
        {
        }
        public HistorialRecursoTecnologico(int id_recurso_tecnologico, int id_estado, DateTime fecha_inicio, DateTime fecha_fin)
            :this(id_recurso_tecnologico, Estado.buscarByIdEstado(id_estado), fecha_inicio, fecha_fin)
        {
        }
        public HistorialRecursoTecnologico(int id_recurso_tecnologico, Estado estado, DateTime fecha_inicio, DateTime fecha_fin)
        {
            this.id_recurso_tecnologico = id_recurso_tecnologico;
            this.estado = estado;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
        }


        internal static List<HistorialRecursoTecnologico> buscarByIdRecursoTecnologico(int id_recurso_tecnologico)
        {
            return DBHistorialRecursoTecnologico.findByIdRecursoTecnologico(id_recurso_tecnologico);
        }

        internal bool esDisponible()
        {
            return estado.esDisponible();
        }
    }
}
