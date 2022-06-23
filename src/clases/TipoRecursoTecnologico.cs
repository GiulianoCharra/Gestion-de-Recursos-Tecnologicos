using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class TipoRecursoTecnologico
    {
        private int id_tipo_recurso_mantenimiento { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }

        public TipoRecursoTecnologico(int id_tipo_recurso_mantenimiento, string nombre, string descripcion)
        {
            this.id_tipo_recurso_mantenimiento = id_tipo_recurso_mantenimiento;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        internal static TipoRecursoTecnologico findById(int id_tipo_recurso_tecnologico)
        {
            return DBTipoRecursoTecnologico.findById(id_tipo_recurso_tecnologico);
        }
    }
}
