using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBHistorialTurno
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[HISTORIALES_TURNOS]";
        private readonly static string query_findByIdTurno = "SELECT * FROM [dbo].[HISTORIALES_TURNOS] WHERE [id_turno]=@ID_TURNO";
        private readonly static string query_findByIdRecursoTecnologico = "SELECT * FROM [dbo].[HISTORIALES_TURNOS] WHERE [id_recurso_tecnologico]=@ID_RECURSO_TECNOLOGICO";
        private readonly static string query_insert = "INSERT INTO [dbo].[HISTORIALES_TURNOS] ([id_turno] ,[id_estado], [fecha_hora_inicio]) VALUES (@ID_TURNO, @ID_ESTADO, @FECHA_HORA_INICIO )";
        private readonly static string query_update = "UPDATE [dbo].[HISTORIALES_TURNOS] SET [fecha_hora_fin] = @FECHA_HORA_FIN WHERE [id_turno]=@ID_TURNO AND [id_estado]=@ID_ESTADO AND [fecha_hora_inicio]=@FECHA_HORA_INICIO";

        /// <summary>
        /// Contruye y debuelve una lista de Historiales de Turnos
        /// </summary>
        /// <param name="drc"></param>
        /// <returns></returns>
        private static List<HistorialTurno> buildHistorialesTurnos(DataRowCollection drc)
        {
            List<HistorialTurno> historial_turnos = new List<HistorialTurno>();
            foreach (DataRow dr in drc)
            {
                historial_turnos.Add(buildHistorialTurno(dr));
            }
            return historial_turnos;
        }
        /// <summary>
        /// Construye y devuelve un Hitorial Turno
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private static HistorialTurno buildHistorialTurno(DataRow dr)
        {
            int id_turno = Convert.ToInt32(dr["id_turno"]);
            int id_estado = Convert.ToInt32(dr["id_estado"]);
            DateTime fecha_hora_inicio = DateTime.Parse(Convert.ToString(dr["fecha_hora_inicio"]));
            DateTime fecha_hora_fin = DateTime.Parse(Convert.ToString(dr["fecha_hora_fin"]));
            return new HistorialTurno(id_turno, id_estado, fecha_hora_inicio, fecha_hora_fin);
        }

        /// <summary>
        /// Busca y devuelve todos los Hitoriales
        /// </summary>
        /// <returns></returns>
        internal static List<HistorialTurno> findAll()
        {
            DataTable dt = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = dt.Rows;
            return buildHistorialesTurnos(drc);
        }        
        /// <summary>
        /// Busca y devuelve todos los Historiales y un Turno en especifico
        /// </summary>
        /// <param name="id_turno"></param>
        /// <returns></returns>
        internal static List<HistorialTurno> findByIdTurno(int id_turno)
        {
            Conexion.agregarParametro("@ID_TURNO", id_turno);
            DataTable dt = Conexion.EjecutarComando(query_findByIdRecursoTecnologico);
            DataRowCollection drc = dt.Rows;
            return buildHistorialesTurnos(drc);
        }
        /// <summary>
        /// Realiza la actualizacion de un Historial, normalmente esto se da cuando el turno
        /// cambio de estado y se nececita finalizar el anterior
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
        /// Realiza la insercion de un nuevo Historial, normalmente esto se da cuando el turno
        /// cambio de estado y se nececita agregar el nuevo
        /// </summary>
        /// <param name="id_turno"></param>
        /// <param name="id_estado"></param>
        /// <param name="fecha_hora_inicio"></param>
        internal static void insert(int id_turno, int id_estado, DateTime fecha_hora_inicio)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@ID_TURNO", id_turno},
                {"@ID_ESTADO", id_estado},
                {"@FECHA_HORA_INICIO", fecha_hora_inicio}
            };
            Conexion.EjecutarInsercion(parametros, query_insert);
        }
    }
}
