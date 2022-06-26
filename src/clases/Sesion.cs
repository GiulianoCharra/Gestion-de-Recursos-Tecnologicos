using Gestión_de_Recursos_Tecnológicos.src.Comun;
using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Sesion
    {
        public int id_sesion { get; set; }
        public DateTime fecha_hora_inicio { get; set; }
        public DateTime fecha_hora_fin { get; set; }
        public Usuario usuario { get; set; }

        public Sesion()
        {
        }

        public Sesion(Usuario usuario):this(usuario, DateTime.Now)
        {
        }
        public Sesion(Usuario usuario, DateTime fecha_hora_inicio)
        {
            this.usuario = usuario;
            this.fecha_hora_inicio = fecha_hora_inicio;
        }        
        public Sesion(int id_sesion, String usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
            : this(id_sesion, Usuario.buscarPorUsuario(usuario), fecha_hora_inicio, fecha_hora_fin)
        {
        }
        public Sesion(int id_sesion, Usuario usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            this.id_sesion = id_sesion;
            this.usuario = usuario;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }

        /// <summary>
        /// Cierra la sesion
        /// </summary>
        public void cerrarSesion()
        {
            fecha_hora_fin = DateTime.Now;
            DBSesion.singOff(id_sesion, fecha_hora_fin);
        }

        /// <summary>
        /// Crea una nueva sesion y la guarda en la DB
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Sesion iniciarSesion(Usuario user)
        {
            Sesion nueva = new Sesion(user);
            int id_sesion = DBSesion.insert(user.user,nueva.fecha_hora_inicio);
            nueva.id_sesion = id_sesion;
            return nueva;
        }

        /// <summary>
        /// Devuelve la sesion actual
        /// </summary>
        /// <returns></returns>
        internal static Sesion sesionActual()
        {
            return Cache.sesionActual;
        }

    }
}
