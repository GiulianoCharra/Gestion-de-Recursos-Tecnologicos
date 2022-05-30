using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class ResponsableTecnico
    {
        private int id_responsable_tecnico { get; set; }
        private PersonalCientifico personalCientifico { set; get; }
        private CentroInvestigacion centroInvestigacion { set; get; }
        private Usuario usuario { get; set; }
        private DateTime fecha_hora_inicio { get; set; }
        private DateTime fecha_hora_fin { get; set; }
    }
}
