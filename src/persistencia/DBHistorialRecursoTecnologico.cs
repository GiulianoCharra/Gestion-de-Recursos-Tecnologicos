using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.persistencia
{
    internal class DBHistorialRecursoTecnologico
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[HISTORIALES_RECURSOS_TECNOLOGICOS]";
        private readonly static string query_findById = "SELECT * FROM [dbo].[HISTORIALES_RECURSOS_TECNOLOGICOS] WHERE [id_recurso_tecnologico] = @ID_RECURSO_TECNOLOGICO AND [id_estado]=@ID_ESTADO AND [fecha_hora_inicio]=@FECHA_HORA_INICIO";
        private readonly static string query_findByIdRecursoTecnologico = "SELECT * FROM [dbo].[HISTORIALES_RECURSOS_TECNOLOGICOS] WHERE [id_recurso_tecnologico] = @ID_RECURSO_TECNOLOGICO";
        private readonly static string query_insert = "INSERT INTO [dbo].[HISTORIALES_RECURSOS_TECNOLOGICOS] ([id_recurso_tecnologico], [id_estado] ,[fecha_hora_inicio]) VALUES (@ID_RECURSO_TECNOLOGICO, @ID_ESTADO, @FECHA_HORA_INICIO)";
        private readonly static string query_update = "UPDATE [dbo].[HISTORIALES_RECURSOS_TECNOLOGICOS] SET [fecha_hora_fin] = @FECHA_HORA_FIN WHERE [id_recurso_tecnologico] = @ID_RECURSO_TECNOLOGICO AND [id_estado]=@ID_ESTADO AND [fecha_hora_inicio]=@FECHA_HORA_INICIO";

        private static List<HistorialRecursoTecnologico> buildHistorialesRecursosTecnologicos(DataRowCollection drc)
        {
            List<HistorialRecursoTecnologico> marcas = new List<HistorialRecursoTecnologico>();
            foreach (DataRow dr in drc)
            {
                marcas.Add(buildHistorialRecursoTecnologico(dr));
            }
            return marcas;
        }
        private static HistorialRecursoTecnologico buildHistorialRecursoTecnologico(DataRow dr)
        {
            int id_recurso_tecnologico = Convert.ToInt32(dr["id_recurso_tecnologico"]);
            int id_estado = Convert.ToInt32(dr["id_estado"]);
            DateTime fecha_hora_inicio = Convert.ToDateTime(dr["fecha_hora_inicio"]);
            DateTime fecha_hora_fin = Convert.ToDateTime(dr["fecha_hora_fin"] == DBNull.Value? null: dr["fecha_hora_fin"]);
            return new HistorialRecursoTecnologico(id_recurso_tecnologico, id_estado, fecha_hora_inicio, fecha_hora_fin);
        }

        internal static void insert(int id_recurso_tecnologico, int id_estado, DateTime fecha_hora_inicio)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_RECURSO_TECNOLOGICO", id_recurso_tecnologico},
                {"@ID_ESTADO", id_estado},
                {"@FECHA_HORA_INICIO", fecha_hora_inicio}
            };

            Conexion.EjecutarInsercion(parametros, query_insert);
        }
        internal static void update(int id_recurso_tecnologico, int id_estado, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_RECURSO_TECNOLOGICO", id_recurso_tecnologico},
                {"@ID_ESTADO", id_estado},
                {"@FECHA_HORA_INICIO", fecha_hora_inicio},
                {"@FECHA_HORA_FIN", fecha_hora_fin}
            };

            Conexion.EjecutarInsercion(parametros, query_update);
        }

        internal static HistorialRecursoTecnologico findById(int id_marca)
        {
            Conexion.agregarParametro("@ID_MARCA", id_marca);

            DataTable ds = Conexion.EjecutarComando(query_findById);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildHistorialRecursoTecnologico(dr);
        }
        internal static List<HistorialRecursoTecnologico> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = ds.Rows;

            return buildHistorialesRecursosTecnologicos(drc);
        }
        internal static List<HistorialRecursoTecnologico> findByIdRecursoTecnologico(int id_recurso_tecnologico)
        {
            Conexion.agregarParametro("@ID_RECURSO_TECNOLOGICO", id_recurso_tecnologico);

            DataTable ds = Conexion.EjecutarComando(query_findByIdRecursoTecnologico);
            DataRowCollection drc = ds.Rows;
            return buildHistorialesRecursosTecnologicos(drc);
        }
    }
}
