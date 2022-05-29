using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Estado
    {
        private int id_estado { get; set; }
        private Ambito ambito { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
    }
}
