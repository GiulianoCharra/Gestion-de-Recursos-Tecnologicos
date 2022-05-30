using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class RecursoTecnologico
    {
        private int id_recurso_tecnologico;
        private TipoRecursoTecnologico tipo_recurso_tecnologico { get; set; }
        private Marca marca { get; set; }
        private Modelo modelo { get; set; }
        private DateTime fecha_alta { get; set; }
        private DateTime fraccionamiento { get; set; }
        private Image imagen { get; set; }
        private string descripcion { get; set; }
        private ResponsableTecnico responsable_tecnico { get; set; }
        private CentroInvestigacion centro_investigacion { get; set; }
        private HistorialRecursoTecnologico[] historial_recurso_tecnologico { get; set; }
    }
}
