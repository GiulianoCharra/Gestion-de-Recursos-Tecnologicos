using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBSesion
    {
        private readonly static String query_insert = "INSERT INTO [dbo].[SESIONES]([fecha_hora_inicio],[id_usuario]) output INSERTED.id_sesion VALUES(@FECHA_HORA_INICIO,@ID_USUARIO)";
        private readonly static string query_singOff = "UPDATE INTO [dbo].[SESIONES] SET ([fecha_hora_fin] = @FECHA_HORA_FIN) WHERE id_sesion = @ID_SESION";


        private static List<Sesion> buildSessiones(DataTable dt)
        {
            List<Sesion> sesiones = new List<Sesion>();

            foreach (DataRow dr in dt.Rows)
            {
                sesiones.Add(buildSession(dr));
            }
            return sesiones;
        }

        private static Sesion buildSession(DataRow dr)
        {
            int id_sesion = Convert.ToInt32(dr[0]);
            String user = Convert.ToString(dr[1]);
            DateTime fecha_hora_inicio = Convert.ToDateTime(dr[2]);
            DateTime fecha_hora_fin = Convert.ToDateTime(dr[3]);

            return new Sesion(id_sesion, user, fecha_hora_inicio, fecha_hora_fin);
        }

        /// <summary>
        /// Guarda en la DB una nueva sesion
        /// </summary>
        /// <param name="user"></param>
        public static int insert(String user, DateTime fecha_hora_inicio)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@FECHA_HORA_INICIO", fecha_hora_inicio},
                {"@ID_USUARIO", user}
            };

            int id_sesion = Conexion.EjecutarInsercion(parametros, query_insert);
            return id_sesion;
        }

        internal static void singOff(int id_sesion, DateTime fecha_hora_fin)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@ID_SESION", id_sesion }
            };
            Conexion.EjecutarComando(parametros, query_singOff);
        }
    }
}
