using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.persistencia
{
    internal class DBRecursoTecnologico
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[RECURSOS_TECNOLOGICOS]";
        private readonly static string query_findIdRecursoTecnologico = "SELECT * FROM [dbo].[RECURSOS_TECNOLOGICOS] WHERE [id_recurso_tecnologico]=@ID_RECURSO_TECNOLOGICO";
        private readonly static string query_findByIdResponsableTecnicoAndIdPersonalCientificoAndIdCentroInvestigacionOrderByNombreTipoRecurso = "SELECT rt.* " +
            "FROM [dbo].[RECURSOS_TECNOLOGICOS] rt JOIN [dbo].[TIPOS_RECURSOS_TECNOLOGICOS] trt ON [rt].[id_tipo_recurso_tecnologico]=[trt].[id_tipo_recurso_tecnologico] " +
            "WHERE [id_responsable_tecnico]=@ID_RESPONSABLE_TECNICO AND [id_personal_cientifico]=@ID_PERSONAL_CIENTIFICO AND [id_centro_investigacion]=@ID_CENTRO_INVESTIGACION " +
            "ORDER BY [trt].[nombre]";

        private static List<RecursoTecnologico> buildRecursosTecnologicos(DataRowCollection drc)
        {
            List<RecursoTecnologico> recursos_tecnologicos = new List<RecursoTecnologico>();
            foreach (DataRow dr in drc)
            {
                recursos_tecnologicos.Add(buildRecursoTecnologico(dr));
            }
            return recursos_tecnologicos;
        }
        private static RecursoTecnologico buildRecursoTecnologico(DataRow dr)
        {
            int id_recurso_tecnologico = Convert.ToInt32(dr["id_recurso_tecnologico"]);
            int id_tipo_recurso_tecnologico = Convert.ToInt32(dr["id_tipo_recurso_tecnologico"]);
            int id_marca = Convert.ToInt32(dr["id_marca"]);
            int id_modelo = Convert.ToInt32(dr["id_modelo"]);
            DateTime fecha_alta = Convert.ToDateTime(dr["fecha_alta"]);
            TimeSpan fraccionamiento = TimeSpan.Parse(Convert.ToString(dr["fraccionamiento"]));
            //TimeSpan fraccionamiento = time == DateTime.MinValue ? TimeSpan.MinValue: new TimeSpan(time.Hour, time.Minute, time.Second);
            byte[] image = dr["imagen"] == DBNull.Value?null: soporte.ImageConverter.convertImageToBytes((Image)dr["imagen"]);
            string descripcion = Convert.ToString(dr["descripcion"]);
            int id_responsable_tecnico = Convert.ToInt32(dr["id_responsable_tecnico"]);
            int id_personal_cientifico = Convert.ToInt32(dr["id_personal_cientifico"]);
            int id_centro_investigacion = Convert.ToInt32(dr["id_centro_investigacion"]);
            
            return new RecursoTecnologico(
                id_recurso_tecnologico,
                id_tipo_recurso_tecnologico,
                id_marca,
                id_modelo,
                fecha_alta,
                fraccionamiento,
                image,
                descripcion,
                id_responsable_tecnico,
                id_centro_investigacion,
                id_personal_cientifico);
        }

        

        internal static RecursoTecnologico findById(int id_tipo_recurso_tecnologico)
        {
            Conexion.agregarParametro("@ID_RECURSO_TECNOLOGICO", id_tipo_recurso_tecnologico);
            DataTable ds = Conexion.EjecutarComando(query_findIdRecursoTecnologico);
            DataRowCollection dwc = ds.Rows;
            if (dwc.Count == 0)
            {
                return null;
            }
            DataRow dr = dwc[0];
            return buildRecursoTecnologico(dr);
        }
        internal static List<RecursoTecnologico> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findAll);
            DataRowCollection dwc = ds.Rows;
            return buildRecursosTecnologicos(dwc);
        }
        internal static List<RecursoTecnologico> findByIdResponsableTecnicoAndIdPersonalCientificoAndIdCentroInvestigacionOrderByNombreTipoRecurso(int id_responsable_tecnico, int id_personal_cientifico, int id_centro_investigacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@ID_RESPONSABLE_TECNICO", id_responsable_tecnico},
                {"@ID_PERSONAL_CIENTIFICO", id_personal_cientifico},
                {"@ID_CENTRO_INVESTIGACION", id_centro_investigacion}
            };
            DataTable ds = Conexion.EjecutarComando(parametros, query_findByIdResponsableTecnicoAndIdPersonalCientificoAndIdCentroInvestigacionOrderByNombreTipoRecurso);
            DataRowCollection dwc = ds.Rows;
            return buildRecursosTecnologicos(dwc);
        }
        internal static DataTable findByIdResponsableTecnicoAndIdPersonalCientificoAndIdCentroInvestigacionToShow(int id_responsable_tecnico, int id_personal_cientifico, int id_centro_investigacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@ID_RESPONSABLE_TECNICO", id_responsable_tecnico},
                {"@ID_PERSONAL_CIENTIFICO", id_personal_cientifico},
                {"@ID_CENTRO_INVESTIGACION", id_centro_investigacion}
            };
            return Conexion.EjecutarComando(parametros, query_findByIdResponsableTecnicoAndIdPersonalCientificoAndIdCentroInvestigacionOrderByNombreTipoRecurso);
        }
    }
}
