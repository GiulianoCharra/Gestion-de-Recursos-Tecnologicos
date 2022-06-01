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

        public Sesion(int id_sesion, Usuario usuario, DateTime fecha_hora_inicio)
        {
            this.id_sesion = id_sesion;
            this.usuario = usuario;
            this.fecha_hora_inicio = fecha_hora_inicio;
        }

        public bool iniciarSesion(string user, string pass)
        {
            if (!Usuario.esUsuarioHabilitado(user, pass))
            {
                return false;
            }

            fecha_hora_inicio = DateTime.Now;

            return true;
        }

        public void cerrarSesion()
        {
            fecha_hora_fin = DateTime.Now;
            string actualizar = "UPDATE INTO [dbo].[SESIONES] SET ([fecha_hora_fin] = @FECHA_HORA_FIN) WHERE id_sesion = @ID_SESION";
            SqlCommand con = Conexion.agregarParametro("@ID_SESION", id_sesion);
            Conexion.EjecutarComando(con, actualizar);
        }

        public void agregarSesion(string user)
        {
            string crear = "INSERT INTO [dbo].[SESIONES]([fecha_hora_inicio],[id_usuario]) VALUES(@FECHA_HORA_INICIO,@ID_USUARIO)";

            //Conexion.agregarParametro("@FECHA_HORA_INICIO", fecha_hora_inicio);
            //Conexion.agregarParametro("@ID_USUARIO", id_sesion);


            Dictionary<string, object> dict = new Dictionary<string, object>();

            dict.Add("@FECHA_HORA_INICIO", fecha_hora_inicio);
            dict.Add("@ID_USUARIO", user);

            SqlCommand comando = Conexion.agregarParametro(dict);
            Conexion.EjecutarComando(comando, crear);

        }

        internal static Sesion sesionActual()
        {
            throw new NotImplementedException();
        }

    }
}
