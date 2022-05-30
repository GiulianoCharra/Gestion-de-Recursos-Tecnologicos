using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Marca
    {
        private int id_marcar { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private Modelo[] modelos { get; set; }
    }
}
