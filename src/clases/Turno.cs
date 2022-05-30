using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Turno
    {
        private int id_turno { get; set; }
        private RecursoTecnologico recurso_tecnologico { get; set; }
        private Cientifico cientifico { get; set; }
        private DateTime fecha_hora_inicio { get; set; }
        private DateTime hora_hora_fin { get; set; }
        private HistorialTurno[] historiales_turnos { get; set; }
    }
}
