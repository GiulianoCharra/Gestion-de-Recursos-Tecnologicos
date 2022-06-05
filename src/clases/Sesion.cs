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

        public Sesion(Usuario usuario, DateTime fecha_hora_inicio)
        {
            this.usuario = usuario;
            this.fecha_hora_inicio = fecha_hora_inicio;
            agregarSesion(usuario.user);
        }
        public Sesion(int id_sesion, Usuario usuario, DateTime fecha_hora_inicio)
        {
            this.id_sesion = id_sesion;
            this.usuario = usuario;
            this.fecha_hora_inicio = fecha_hora_inicio;
        }

        public void cerrarSesion()
        {
            fecha_hora_fin = DateTime.Now;
            string actualizar = "UPDATE INTO [dbo].[SESIONES] SET ([fecha_hora_fin] = @FECHA_HORA_FIN) WHERE id_sesion = @ID_SESION";
            
            Dictionary<string, object> parametros = new Dictionary<string, object>() { 
                {"@ID_SESION", id_sesion } 
            };
            Conexion.EjecutarComando(parametros, actualizar);
        }

        public void agregarSesion(string user)
        {
            string crear = "INSERT INTO [dbo].[SESIONES]([fecha_hora_inicio],[id_usuario]) VALUES(@FECHA_HORA_INICIO,@ID_USUARIO)";

            Dictionary<string, object> parametros = new Dictionary<string, object>() { 
                {"@FECHA_HORA_INICIO", fecha_hora_inicio},
                {"@ID_USUARIO", user} 
            };

            Conexion.EjecutarComando(parametros, crear);
        }

        internal static Sesion sesionActual()
        {
            throw new NotImplementedException();
        }

    }
}
