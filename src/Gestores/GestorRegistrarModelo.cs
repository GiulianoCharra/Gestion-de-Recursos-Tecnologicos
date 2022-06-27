using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Gestores
{
    internal class GestorRegistrarModelo
    {
        internal static void registrarModelo(int id_marca, string nombre, string descripcion)
        {
            Modelo.registrar(id_marca, nombre, descripcion);
        }
    }
}
