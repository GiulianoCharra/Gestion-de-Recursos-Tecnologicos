using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Facultad
    {
        private int id_facultad { get; set; }
        private string nombre { get; set; }
        private string direccion { get; set; }
        private CentroInvestigacion[] centros_investigacion { get; set; }
    }
}
