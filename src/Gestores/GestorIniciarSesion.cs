using Gestión_de_Recursos_Tecnológicos.src.clases;
using Gestión_de_Recursos_Tecnológicos.src.Comun;
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
                Cache.sesion = new Sesion(1 ,new Usuario(usuario, contraseña), DateTime.Now); 
                return true;
            }

            return false;
        }
    }
}
