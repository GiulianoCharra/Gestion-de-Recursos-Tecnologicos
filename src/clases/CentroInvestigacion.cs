using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class CentroInvestigacion
    {
        private int id_centro_investigacion;
        private string nombre;
        private string sigla;
        private string email;
        private DateTime fecha_alta;
        private string actividad;
        private string reglamento;
        private string direccion;
        private HistorialDirector[] directores;
        private RecursoTecnologico[] recursoTecnologicos;
        private PersonalCientifico[] personalCientifico;
    }
}
