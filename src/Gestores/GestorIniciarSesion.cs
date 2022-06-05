using Gestión_de_Recursos_Tecnológicos.src.clases;
using Gestión_de_Recursos_Tecnológicos.src.Comun;
using Gestión_de_Recursos_Tecnológicos.src.ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Usuario user = Usuario.existeUsuario(usuario, contraseña);

            if (user != null)
            {
                if (user.habilitado)
                {
                    Sesion sesion = new Sesion(user, DateTime.Now);
                    Cache.sesionActual = sesion;
                    return true;
                }
            }
            return false;
        }
    }
}
