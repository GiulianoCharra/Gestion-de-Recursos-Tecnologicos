using Gestión_de_Recursos_Tecnológicos.src.clases;
using Gestión_de_Recursos_Tecnológicos.src.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Recursos_Tecnológicos.src.Gestores
{
    internal static class GestorIniciarSesion
    {
        /// <summary>
        /// Intenta iniciar sesion con los datos ingresados,
        /// si el ususario existe se crea una nueva sesion y decuelve true,
        /// si el ususario no se sncuentra se devuelve un false
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool iniciarSesion(String user, string pass)
        {
            Usuario usuario = buscarUsuarioAndPass(user, pass);

            if (usuario == null || !usuario.esHabilitado())
            {
                return false;
            }

            guardarSesionCache(usuario);

            return true;
        }

        /// <summary>
        /// Se guarda la sesion con el usuario que ingreso
        /// </summary>
        /// <param name="user"></param>
        private static void guardarSesionCache(Usuario user)
        {
            Cache.guardarDatos(Sesion.iniciarSesion(user));
        }

        /// <summary>
        /// Llama a la clase usuario para verificar si el user y pass
        /// ingresado existe
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static Usuario buscarUsuarioAndPass(String user, String pass)
        {
            return Usuario.buscarByUsuarioAndPass(user, pass);
        }
    }
}
