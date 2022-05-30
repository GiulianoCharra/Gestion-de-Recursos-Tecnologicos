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
        private int id_sesion { get; set; }
        private DateTime fecha_hora_inicio { get; set; }
        private DateTime fecha_hora_fin { get; set; }
        private Usuario usuario { get; set; }

        public Sesion()
        {
        }

        public Sesion(int id_sesion, Usuario usuario, DateTime fecha_hora_inicio)
        {
            this.Id_sesion = id_sesion;
            this.Usuario = usuario;
            this.Fecha_hora_inicio = fecha_hora_inicio;
        }

        public int Id_sesion { get => id_sesion; set => id_sesion = value; }
        public DateTime Fecha_hora_inicio { get => fecha_hora_inicio; set => fecha_hora_inicio = value; }
        public DateTime Fecha_hora_fin { get => fecha_hora_fin; set => fecha_hora_fin = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }


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
            SqlCommand con = Conexion.agregarParametro("@ID_SESION", Id_sesion);
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
    }
}
