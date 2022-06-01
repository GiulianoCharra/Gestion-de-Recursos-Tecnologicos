using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Gestores
{
    internal class GestorIngresoRecursoTecnologicoMantenimientoCorrectivo
    {


        public GestorIngresoRecursoTecnologicoMantenimientoCorrectivo()
        {

        }

        internal static void buscarRecursosAsociados()
        {
            Sesion sesionActual = Sesion.sesionActual();
            Usuario userActual = sesionActual.usuario;
            if (userActual.esUsuarioResponsableTecnico())
            {

            }

            throw new NotImplementedException();
        }
    }
}
