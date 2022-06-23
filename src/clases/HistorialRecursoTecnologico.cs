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
        private RecursoTecnologico recurso_tecnologico { set; get; }
        private Estado estado { get; set; }
        private DateTime fecha_inicio { get; set; }
        private DateTime fecha_fin { get; set; }

        public HistorialRecursoTecnologico(RecursoTecnologico recurso_tecnologico, Estado estado, DateTime fecha_inicio)
        {
            this.recurso_tecnologico = recurso_tecnologico;
            this.estado = estado;
            this.fecha_inicio = fecha_inicio;
        }
        public HistorialRecursoTecnologico(RecursoTecnologico recurso_tecnologico, Estado estado, DateTime fecha_inicio, DateTime fecha_fin)
        {
            this.recurso_tecnologico = recurso_tecnologico;
            this.estado = estado;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
        }

        public HistorialRecursoTecnologico(RecursoTecnologico recurso_tecnologico, Estado estado)
        {
            this.recurso_tecnologico = recurso_tecnologico;
            this.estado = estado;
        }

        internal static List<HistorialRecursoTecnologico> findByIdRecursoTecnologico(int id_recurso_tecnologico)
        {
            return DBHistorialRecursoTecnologico.findByIdRecursoTecnologico(id_recurso_tecnologico);
        }
    }
}
