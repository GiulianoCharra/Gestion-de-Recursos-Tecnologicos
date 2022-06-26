using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBDirector
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[DIRECTORES]";
        private readonly static string query_findById = "SELECT * FROM [dbo].[DIRECTORES] WHERE [id_director]=@ID_DIRECTOR AND [id_personal_cientifico]=@ID_PERSONAL_CIENTIFICO AND [id_centro_investigacion]=@ID_CENTRO_INVESTIGACION";
        private readonly static string query_findByIdDirector = "SELECT * FROM [dbo].[DIRECTORES] WHERE [id_director]=@ID_DIRECTOR";
        private readonly static string query_findByUser = "SELECT * FROM [dbo].[DIRECTORES] WHERE [usuario] = @USUARIO";
        private readonly static string query_findByIdCentroInvestigacion = "SELECT * FROM [dbo].[DIRECTORES] WHERE [id_centro_investigacion]=@ID_CENTRO_INVESTIGACION";


        private static List<Director> buildDirectores(DataRowCollection dwc)
        {
            List<Director> directores = new List<Director>();
            foreach (DataRow dr in dwc)
            {
                directores.Add(buildDirector(dr));
            }
            return directores;
        }
        private static Director buildDirector(DataRow dr)
        {
            int id_director = Convert.ToInt32(dr["id_director"]);
            int id_personal_cientifico = Convert.ToInt32(dr["id_personal_cientifico"]);
            int id_centro_investigacion = Convert.ToInt32(dr["id_centro_investigacion"]);
            string usuario = Convert.ToString(dr["usuario"]);
            DateTime fecha_hora_inicio = Convert.ToDateTime(dr["fecha_hora_inicio"]);
            DateTime fecha_hora_fin = Convert.ToDateTime(dr["fecha_hora_fin"]);

            return new Director(id_director, id_personal_cientifico, id_centro_investigacion, usuario, fecha_hora_inicio, fecha_hora_fin);
        }


        internal static List<Director> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findByUser);
            DataRowCollection drc = ds.Rows;

            return buildDirectores(drc);
        }
        internal static Director findById(int id_cientifico, int id_personal_cientifico, int id_centro_investigacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_DIRECTOR", id_cientifico},
                {"@ID_PERSONAL_CIENTIFICO", id_personal_cientifico},
                {"@ID_CENTRO_INVESTIGACION", id_centro_investigacion}
            };

            DataTable dt = Conexion.EjecutarComando(parametros, query_findByIdDirector);
            DataRowCollection drc = dt.Rows;

            DataRow dr = drc[0];
            return buildDirector(dr);
        }
        internal static Director findByIdCientifico(int id_cientifico)
        {
            Conexion.agregarParametro("@ID_DIRECTOR", id_cientifico);

            DataTable ds = Conexion.EjecutarComando(query_findByIdDirector);
            DataRowCollection drc = ds.Rows;

            DataRow dr = drc[0];
            return buildDirector(dr);
        }
        internal static Director findByUser(string user)
        {
            Conexion.agregarParametro("@USUARIO", user);

            DataTable ds = Conexion.EjecutarComando(query_findByUser);
            DataRowCollection drc = ds.Rows;

            DataRow dr = drc[0];
            return buildDirector(dr);
        }
        internal static List<Director> findByCentroInvestigacion(int id_centro_investigacion)
        {
            Conexion.agregarParametro("@ID_CENTRO_INVESTIGACION", id_centro_investigacion);

            DataTable ds = Conexion.EjecutarComando(query_findByIdCentroInvestigacion);
            DataRowCollection drc = ds.Rows;

            return buildDirectores(drc);
        }

    }
}
