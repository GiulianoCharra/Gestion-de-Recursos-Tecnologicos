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
    }
}
