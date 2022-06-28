using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBTurno
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[TURNOS]";
        private readonly static string query_findByIdTurno = "SELECT * FROM [dbo].[TURNOS] WHERE [id_turno]=@ID_TURNO";
        private readonly static string query_findByIdRecursoTecnologico = "SELECT * FROM [dbo].[TURNOS] WHERE [id_recurso_tecnologico]=@ID_RECURSO_TECNOLOGICO";
        private readonly static string query_findByIdRecursoTecnologicoAndMenorFechaInicio = "SELECT [t].* " +
            "FROM [dbo].[TURNOS] t JOIN [dbo].[PERSONAL_CIENTIFICO] pc ON [t].[id_personal_cientifico]=[pc].[legajo] " +
            "WHERE [id_recurso_tecnologico]=@ID_RECURSO_TECNOLOGICO AND [fecha_inicio]<=@FECHA_FIN_PREVISTA " +
            "ORDER BY [pc].[apellidos]";

        private static List<Turno> buildTurnos(DataRowCollection drc)
        {
            List<Turno> turnos = new List<Turno>();
            foreach (DataRow dr in drc)
            {
                turnos.Add(buildTurno(dr));
            }
            return turnos;
        }
        private static Turno buildTurno(DataRow dr)
        {
            int id_turno = Convert.ToInt32(dr["id_turno"]);
            int id_recurso_tecnologico = Convert.ToInt32(dr["id_recurso_tecnologico"]);
            int id_cientifico = Convert.ToInt32(dr["id_cientifico"]);
            int id_personal_cientifico = Convert.ToInt32(dr["id_personal_cientifico"]);
            int id_centro_investigacion = Convert.ToInt32(dr["id_centro_investigacion"]);
            DateTime fecha_inicio = DateTime.Parse(Convert.ToDateTime(dr["fecha_inicio"]).Date.ToString());
            TimeSpan hora_inicio = TimeSpan.Parse(Convert.ToString(dr["hora_inicio"]));
            //DateTime fecha_fin = DateTime.Parse(dr["fecha_fin"] == DBNull.Value? null: Convert.ToDateTime(dr["fecha_fin"]).Date.ToString());
            TimeSpan hora_fin = dr["hora_fin"]== DBNull.Value ? TimeSpan.MinValue :TimeSpan.Parse(Convert.ToString(dr["hora_fin"]));
            return new Turno(id_turno , id_recurso_tecnologico, id_cientifico, id_personal_cientifico, id_centro_investigacion, fecha_inicio, hora_inicio, DateTime.MinValue, hora_fin);
        }

        internal static List<Turno> findAll()
        {
            DataTable dt = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = dt.Rows;
            return buildTurnos(drc);
        }
        internal static Turno findByIdTurno(int id_turno)
        {
            Conexion.agregarParametro("@ID_TURNO", id_turno);
            DataTable dt = Conexion.EjecutarComando(query_findByIdRecursoTecnologico);

            DataRow dr = dt.Rows[0];
            return buildTurno(dr);
        }
        internal static List<Turno> findByIdRecursoTecnologicoAndMenorFechaInicio(int id_recurso_tecnologico, DateTime fecha_fin_prevista)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"ID_RECURSO_TECNOLOGICO",id_recurso_tecnologico },
                {"FECHA_FIN_PREVISTA", fecha_fin_prevista}
            };
            DataTable dt = Conexion.EjecutarComando(parametros, query_findByIdRecursoTecnologicoAndMenorFechaInicio);
            DataRowCollection drc = dt.Rows;
            return buildTurnos(drc);
        }
    }
}
