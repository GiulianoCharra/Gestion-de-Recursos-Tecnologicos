using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Comun
{
    static class Cache
    {
        public static Sesion sesionActual { get; set; }
        public static PersonalCientifico personalCientifico { get; set; }

        internal static void guardarDatos(Sesion sesion)
        {
            sesionActual = sesion;

            Usuario user = Cache.sesionActual.usuario;
            string usuario = user.user;

            if (user.esUsuarioResponsableTecnico())
            {
                personalCientifico = ResponsableTecnico.buscarPorUsuario(usuario).personal_cientifico;
            }
            if (user.esUsuarioDirector())
            {
                personalCientifico = Director.buscarPorUsuario(usuario).personal_cientifico;
            }
            if (user.esUsuarioCientifico())
            {
                personalCientifico = Cientifico.buscarPorUsuario(usuario).personal_cientifico;
            }
        }
    }
}
