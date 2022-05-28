using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Gestores
{
    internal class GestorIniciarSesion
    {
        private Sesion sesion;

        public GestorIniciarSesion()
        {

        }

        public static bool iniciarSesion(String usuario, string contraseña)
        {
            if (Usuario.existeUsuario(usuario, contraseña))
            {

            }
            return false;
        }
    }
}
