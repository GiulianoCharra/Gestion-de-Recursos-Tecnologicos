using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBCientifico
    {

        private readonly static string query_findAll = "SELECT * FROM [dbo].[CIENTIFICOS]";
        private readonly static string query_findById = "SELECT * FROM [dbo].[CIENTIFICOS] WHERE [id_cientifico]=@ID_CIENTIFICO AND [id_personal_cientifico]=@ID_PERSONAL_CIENTIFICO AND [id_centro_investigacion]=@ID_CENTRO_INVESTIGACION";
        private readonly static string query_findByIdCientifico = "SELECT * FROM [dbo].[CIENTIFICOS] WHERE [id_cientifico]=@ID_CIENTIFICO";
        private readonly static string query_findByUser = "SELECT * FROM [dbo].[CIENTIFICOS] WHERE [usuario] = @USUARIO";
        private readonly static string query_findByIdCentroInvestigacion = "SELECT * FROM [dbo].[CIENTIFICOS] WHERE [id_centro_investigacion]=@ID_CENTRO_INVESTIGACION";


        private static List<Cientifico> buildCientificos(DataRowCollection dwc)
        {
            List<Cientifico> cientificos = new List<Cientifico>();
            foreach (DataRow dr in dwc)
            {
                cientificos.Add(buildCientifico(dr));
            }
            return cientificos;
        }
        private static Cientifico buildCientifico(DataRow dr)
        {
            int id_cientifico = Convert.ToInt32(dr["id_cientifico"]);
            int id_personal_cientifico = Convert.ToInt32(dr["id_personal_cientifico"]);
            int id_centro_investigacion = Convert.ToInt32(dr["id_centro_investigacion"]);
            string usuario = Convert.ToString(dr["usuario"]);
            DateTime fecha_hora_inicio = Convert.ToDateTime(dr["fecha_hora_inicio"]);
            DateTime fecha_hora_fin = Convert.ToDateTime(dr["fecha_hora_fin"]);

            return new Cientifico(id_cientifico, id_personal_cientifico, id_centro_investigacion, usuario, fecha_hora_inicio, fecha_hora_fin);
        }


        internal static List<Cientifico> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findByUser);
            DataRowCollection drc = ds.Rows;

            return buildCientificos(drc);
        }
        internal static Cientifico findById(int id_cientifico, int id_personal_cientifico, int id_centro_investigacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_CIENTIFICO", id_cientifico},
                {"@ID_PERSONAL_CIENTIFICO", id_personal_cientifico},
                {"@ID_CENTRO_INVESTIGACION", id_centro_investigacion}
            };

            DataTable dt = Conexion.EjecutarComando(parametros, query_findByIdCientifico);
            DataRowCollection drc = dt.Rows;

            DataRow dr = drc[0];
            return buildCientifico(dr);
        }
        internal static Cientifico findByIdCientifico(int id_cientifico)
        {
            Conexion.agregarParametro("@ID_CIENTIFICO", id_cientifico);

            DataTable ds = Conexion.EjecutarComando(query_findByIdCientifico);
            DataRowCollection drc = ds.Rows;

            DataRow dr = drc[0];
            return buildCientifico(dr);
        }
        internal static Cientifico findByUser(string user)
        {
            Conexion.agregarParametro("@USUARIO", user);

            DataTable ds = Conexion.EjecutarComando(query_findByUser);
            DataRowCollection drc = ds.Rows;

            DataRow dr = drc[0];
            return buildCientifico(dr);
        }
        internal static List<Cientifico> findByCentroInvestigacion(int id_centro_investigacion)
        {
            Conexion.agregarParametro("@ID_CENTRO_INVESTIGACION", id_centro_investigacion);

            DataTable ds = Conexion.EjecutarComando(query_findByIdCentroInvestigacion);
            DataRowCollection drc = ds.Rows;

            return buildCientificos(drc);
        }

    }
}
