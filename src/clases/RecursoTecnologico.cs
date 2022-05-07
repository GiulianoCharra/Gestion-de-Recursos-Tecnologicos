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
        private string nombre;
        private TipoRecursoTecnologico tipo_recurso_tecnologico;
        private Modelo modelo;
        private Marca marca;
        private DateTime fecha_alta;
        private HistorialRecursoTecnologico[] historial_recurso_tecnologico;
        private Image imagen;
    }
}
