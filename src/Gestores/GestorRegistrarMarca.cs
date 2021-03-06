using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Gestores
{
    internal static class GestorRegistrarMarca
    {
        public static List<Marca> cargarMarcas()
        {
            return Marca.buscarTodas();
        }

        internal static void registrarMarca(string nombre, string descripcion)
        {
            Marca.registrar(nombre, descripcion);
        }
    }
}
