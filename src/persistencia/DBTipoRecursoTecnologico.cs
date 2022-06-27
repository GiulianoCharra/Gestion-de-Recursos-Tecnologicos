using System;
using System.Collections.Generic;
using System.Data;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class DBTipoRecursoTecnologico
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[TIPOS_RECURSOS_TECNOLOGICOS]";
        private readonly static string query_findIdTipoRecursoTecnologico = "SELECT * FROM [dbo].[TIPOS_RECURSOS_TECNOLOGICOS] WHERE [id_tipo_recurso_tecnologico]=@ID_TIPO_RECURSO_TECNOLOGICO";

        private static List<TipoRecursoTecnologico> buildTiposRecursosTecnologicos(DataRowCollection drc)
        {
            List<TipoRecursoTecnologico> tipos_recursos_tecnologicos = new List<TipoRecursoTecnologico>();
            foreach (DataRow dr in drc)
            {
                tipos_recursos_tecnologicos.Add(buildTipoRecursoTecnologico(dr));
            }
            return tipos_recursos_tecnologicos;
        }

        private static TipoRecursoTecnologico buildTipoRecursoTecnologico(DataRow dr)
        {
            int id_marca = Convert.ToInt32(dr["id_tipo_recurso_tecnologico"]);
            string nombre = Convert.ToString(dr["nombre"]);
            string descripcion = Convert.ToString(dr["descripcion"]);
            return new TipoRecursoTecnologico(id_marca, nombre, descripcion);
        }

        internal static TipoRecursoTecnologico findById(int id_tipo_recurso_tecnologico)
        {
            Conexion.limpiarParametros();
            Conexion.agregarParametro("@ID_TIPO_RECURSO_TECNOLOGICO", id_tipo_recurso_tecnologico);
            DataTable ds = Conexion.EjecutarComando(query_findIdTipoRecursoTecnologico);
            DataRowCollection dwc = ds.Rows;
            if (dwc.Count == 0)
            {
                return null;
            }
            DataRow dr = dwc[0];
            return buildTipoRecursoTecnologico(dr);
        }
        internal static List<TipoRecursoTecnologico> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = ds.Rows;
            return buildTiposRecursosTecnologicos(drc);
        }
    }
}