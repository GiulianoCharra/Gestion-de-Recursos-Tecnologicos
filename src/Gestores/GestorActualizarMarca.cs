using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Gestores
{
    internal class GestorActualizarMarca
    {
        internal static void actualizarMarca(int id_marca, string nombre, string descripcion)
        {
            Marca.actualizar(id_marca, nombre, descripcion);
        }
    }
}
