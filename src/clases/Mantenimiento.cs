using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Mantenimiento
    {
        private int id_matenimiento { get; set; }
        private RecursoTecnologico recurso_tecnologico { get; set; }
        private TipoMantenimiento tipo_mantenimiento { get; set; }
        private Estado estado { get; set; }
        private DateTime fecha_hora { get; set; }
        private DateTime fecha_hora_inicio_mantenimiento { get; set; }
        private DateTime fecha_hora_fin_mantenimiento_estimado { get; set; }
        private DateTime fecha_hora_fin_mantenimiento_real { get; set; }
        private string motivo { get; set; }
    }
}
