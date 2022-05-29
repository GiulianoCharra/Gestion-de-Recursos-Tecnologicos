using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class CentroInvestigacion
    {
        private int id_centro_investigacion { get; set; }
        private string nombre { get; set; }
        private string sigla { get; set; }
        private string email { get; set; }
        private DateTime fecha_alta { get; set; }
        private string actividad { get; set; }
        private string reglamento { get; set; }
        private string direccion { get; set; }
        private HistorialDirector[] directores { get; set; }
        private RecursoTecnologico[] recursoTecnologicos { get; set; }
        private PersonalCientifico[] personalCientifico { get; set; }
    }
}
