using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Cientifico
    {
        private int id_cientifico { get; set; }
        private PersonalCientifico personal_cientifico { set; get; }
        private CentroInvestigacion centro_investigacion { set; get; }
        private Usuario usuario { get; set; }
        private DateTime fecha_hora_inicio { get; set; }
        private DateTime fecha_hora_fin { get; set; }
    }
}
