using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.persistencia
{
    internal class DBCentroInvestigacion
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[CENTROS_INVESTIGACION]";
        private readonly static string query_findById = "SELECT * FROM [dbo].[CENTROS_INVESTIGACION] WHERE [id_centro_investigacion]=@ID_CENTRO_INVESTIGACION";

        private static List<CentroInvestigacion> buildCentrosInvestigacion(DataRowCollection drc)
        {
            List<CentroInvestigacion> centros_ivestigacion = new List<CentroInvestigacion>();
            foreach (DataRow dr in drc)
            {
                centros_ivestigacion.Add(buildCentroInvestigacion(dr));
            }
            return centros_ivestigacion;
        }
        private static CentroInvestigacion buildCentroInvestigacion(DataRow dr)
        {
            int id_centro_investigacion = Convert.ToInt32(dr["id_centro_investigacion"]);
            string nombre = Convert.ToString(dr["nombre"]);
            string sigla = Convert.ToString(dr["sigla"]);
            string direccion = Convert.ToString(dr["direccion"]);
            DateTime fecha_hora_inicio = Convert.ToDateTime(dr["fecha_hora_inicio"]);
            string email = Convert.ToString(dr["email"]);
            string actividad = Convert.ToString(dr["actividad"]);
            string reglamento = Convert.ToString(dr["reglamento"]);
            int tiempo_antelacion = Convert.ToInt32(dr["tiempo_antelacion"] == DBNull.Value? null: dr["tiempo_antelacion"]);
            DateTime fecha_baja = Convert.ToDateTime(dr["fecha_baja"] == DBNull.Value ? null : dr["fecha_baja"]);
            string motivo_baja = Convert.ToString(dr["motivo_baja"]);

            return new CentroInvestigacion(id_centro_investigacion, nombre, sigla, direccion, fecha_hora_inicio, email, actividad, reglamento, tiempo_antelacion, fecha_baja, motivo_baja);
        }

        internal static List<CentroInvestigacion> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findAll);
            DataRowCollection dwc = ds.Rows;
            return buildCentrosInvestigacion(dwc);
        }
        internal static CentroInvestigacion findById(int id_centro_investigacion)
        {
            Conexion.agregarParametro("@ID_CENTRO_INVESTIGACION", id_centro_investigacion);

            DataTable ds = Conexion.EjecutarComando(query_findById);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildCentroInvestigacion(dr);
        }
    }
}
