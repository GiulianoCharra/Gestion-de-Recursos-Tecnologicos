using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.persistencia
{
    internal class DBResponsableTecnico
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[RESPONSABLES_TECNICOS]";
        private readonly static string query_findByUser = "SELECT * FROM [dbo].[RESPONSABLES_TECNICOS] WHERE [usuario]=@USUARIO";
        private readonly static string query_findByIdResponsableTecnico = "SELECT * FROM [dbo].[CIENTIFICOS] WHERE [id_responsable_tecnico]=@ID_RESPONSABLE_TECNICO";
        private readonly static string query_findByIdCentroInvestigacion = "SELECT * FROM [dbo].[CIENTIFICOS] WHERE [id_centro_investigacion]=@ID_CENTRO_INVESTIGACION";
        private readonly static string query_findById = "SELECT * FROM [dbo].[RESPONSABLES_TECNICOS] WHERE [id_responsable_tecnico]=@ID_RESPONSABLE_TECNICO AND [id_personal_cientifico]=@ID_PERSONAL_CIENTIFICO AND [id_centro_investigacion]=@ID_CENTRO_INVESTIGACION";


        private static List<ResponsableTecnico> buildResponsablesTecnicos(DataRowCollection dwc)
        {
            List<ResponsableTecnico> responsablesTecnicos = new List<ResponsableTecnico>();
            foreach (DataRow dr in dwc)
            {
                responsablesTecnicos.Add(buildResponsableTecnico(dr));
            }
            return responsablesTecnicos;
        }
        private static ResponsableTecnico buildResponsableTecnico(DataRow dr)
        {
            int id_responsable_tecnico = Convert.ToInt32(dr["id_responsable_tecnico"]);
            int id_personal_cientifico = Convert.ToInt32(dr["id_personal_cientifico"]);
            int id_centro_investigacion = Convert.ToInt32(dr["id_centro_investigacion"]);
            string usuario = Convert.ToString(dr["usuario"]);
            DateTime fecha_hora_inicio = Convert.ToDateTime(dr["fecha_hora_inicio"]);
            DateTime fecha_hora_fin = Convert.ToDateTime(dr["fecha_hora_fin"]);

            return new ResponsableTecnico(id_responsable_tecnico, id_personal_cientifico, id_centro_investigacion, usuario, fecha_hora_inicio, fecha_hora_fin);
        }

        internal static List<ResponsableTecnico> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = ds.Rows;

            return buildResponsablesTecnicos(drc);
        }
        internal static ResponsableTecnico findById(int id_responsable_tecnico, int id_personal_cientifico, int id_centro_investigacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_RESPONSABLE_TECNICO", id_responsable_tecnico},
                {"@ID_PERSONAL_CIENTIFICO", id_personal_cientifico},
                {"@ID_CENTRO_INVESTIGACION", id_centro_investigacion}
            };

            DataTable dt= Conexion.EjecutarComando(parametros, query_findById);
            DataRowCollection drc = dt.Rows;

            DataRow dr = drc[0];
            return buildResponsableTecnico(dr);
        }
        internal static ResponsableTecnico findByIdResponsableTecnico(int id_responsable_tecnico)
        {
            Conexion.agregarParametro("@ID_RESPONSABLE_TECNICO", id_responsable_tecnico);

            DataTable ds = Conexion.EjecutarComando(query_findByIdResponsableTecnico);
            DataRowCollection drc = ds.Rows;

            DataRow dr = drc[0];
            return buildResponsableTecnico(dr);
        }
        internal static ResponsableTecnico findByUser(string user)
        {
            Conexion.agregarParametro("@USUARIO", user);

            DataTable ds = Conexion.EjecutarComando(query_findByUser);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildResponsableTecnico(dr);
        }
        internal static List<ResponsableTecnico> findByCentroInvestigacion(int id_centro_investigacion)
        {
            Conexion.agregarParametro("@ID_CENTRO_INVESTIGACION", id_centro_investigacion);

            DataTable ds = Conexion.EjecutarComando(query_findByIdCentroInvestigacion);
            DataRowCollection drc = ds.Rows;

            return buildResponsablesTecnicos(drc);
        }
    }
}
