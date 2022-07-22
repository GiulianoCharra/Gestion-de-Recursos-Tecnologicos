using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBMantenimiento
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[MANTENIMIENTOS]";
        private readonly static string query_findByIdMantenimiento = "SELECT * FROM [dbo].[MANTENIMIENTOS] WHERE [id_mantenimiento]=@ID_MANTENIMIENTO";
        private readonly static string query_findByIdRecursoTecnologico = "SELECT * FROM [dbo].[MANTENIMIENTOS] WHERE [id_recurso_tecnologico]=@ID_RECURSO_TECNOLOGICO";
        private readonly static string query_insert = "INSERT INTO [dbo].[MANTENIMIENTOS] ([id_recurso_tecnologico] ,[id_tipo_mantenimiento], [fecha_hora_ingreso], [fecha_hora_fin_prevista], [motivo]) VALUES (@ID_RECURSO_TECNOLOGICO, @ID_TIPO_MANTENIMIENTO, @FECHA_HORA_INGRESO, @FECHA_HORA_FIN_PREVISTA, @MOTIVO)";
        private readonly static string query_update = "UPDATE [dbo].[MANTENIMIENTOS] SET [fecha_hora_fin_mantenimiento_real] = @FECHA_HORA_FIN_MANTENIMIENTO_REAL WHERE [id_mantenimiento]=@ID_MANTENIMIENTO";

        /// <summary>
        /// Contruye y debuelve una lista de Mantenimientos
        /// </summary>
        /// <param name="drc"></param>
        /// <returns></returns>
        private static List<Mantenimiento> buildMantenimientos(DataRowCollection drc)
        {
            List<Mantenimiento> historial_turnos = new List<Mantenimiento>();
            foreach (DataRow dr in drc)
            {
                historial_turnos.Add(buildMantenimiento(dr));
            }
            return historial_turnos;
        }
        /// <summary>
        /// Construye y devuelve un Mantenimiento
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private static Mantenimiento buildMantenimiento(DataRow dr)
        {
            int id_mantenimiento = Convert.ToInt32(dr["id_mantenimiento"]);
            int id_recurso_tecnologico = Convert.ToInt32(dr["id_recurso_tecnologico"]);
            int id_tipo_mantenimiento = Convert.ToInt32(dr["id_tipo_mantenimiento"]);
            DateTime fecha_hora = DateTime.Parse(Convert.ToString(dr["fecha_hora_ingreso"]));
            DateTime fecha_hora_inicio_mantenimiento = DateTime.Parse(Convert.ToString(dr["fecha_hora_inicio"]));
            DateTime fecha_hora_fin_prevista = DateTime.Parse(Convert.ToString(dr["fecha_hora_fin_prevista"]));
            DateTime fecha_hora_fin_mantenimiento_real = DateTime.Parse(Convert.ToString(dr["fecha_hora_fin_real"]));
            string motivo = Convert.ToString(dr["motivo"]);
            return new Mantenimiento(id_mantenimiento, id_recurso_tecnologico, id_tipo_mantenimiento, fecha_hora, fecha_hora_inicio_mantenimiento, fecha_hora_fin_prevista, fecha_hora_fin_mantenimiento_real, motivo);
        }

        /// <summary>
        /// Busca y devuelve todos los Mantenimiento
        /// </summary>
        /// <returns></returns>
        internal static List<Mantenimiento> findAll()
        {
            DataTable dt = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = dt.Rows;
            return buildMantenimientos(drc);
        }
        /// <summary>
        /// Busca y devuelve todos los Historiales y un Turno en especifico
        /// </summary>
        /// <param name="id_turno"></param>
        /// <returns></returns>
        internal static List<Mantenimiento> findById(int id_mantenimiento)
        {
            Conexion.agregarParametro("@ID_MANTENIMIENTO", id_mantenimiento);
            DataTable dt = Conexion.EjecutarComando(query_findByIdMantenimiento);
            DataRowCollection drc = dt.Rows;
            return buildMantenimientos(drc);
        }
        /// <summary>
        /// Realiza la actualizacion de un Mantenimiento
        /// </summary>
        /// <param name="id_turno"></param>
        /// <param name="id_estado"></param>
        /// <param name="fecha_hora_inicio"></param>
        /// <param name="fecha_hora_fin"></param>
        internal static void update(int id_turno, int id_estado, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@ID_TURNO", id_turno},
                {"@ID_ESTADO", id_estado},
                {"@FECHA_HORA_INICIO", fecha_hora_inicio},
                {"@FECHA_HORA_FIN", fecha_hora_fin}
            };
            Conexion.EjecutarInsercion(parametros, query_update);
        }
        /// <summary>
        /// Realiza la insercion de un nuevo Mantenimiento
        /// cambio de estado y se nececita agregar el nuevo
        /// </summary>
        /// <param name="id_turno"></param>
        /// <param name="id_estado"></param>
        /// <param name="fecha_hora_inicio"></param>
        internal static void insert(int id_recurso_tecnologico,int id_tipo_mantenimiento,DateTime fecha_hora_ingreso, DateTime fecha_hora_fin_prevista, string motivo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@ID_RECURSO_TECNOLOGICO", id_recurso_tecnologico},
                {"@ID_TIPO_MANTENIMIENTO", id_tipo_mantenimiento},
                {"@FECHA_HORA_INGRESO", fecha_hora_ingreso},
                {"@FECHA_HORA_FIN_PREVISTA", fecha_hora_fin_prevista},
                {"@MOTIVO", motivo}
            };
            Conexion.EjecutarInsercion(parametros, query_insert);
        }
    }
}
