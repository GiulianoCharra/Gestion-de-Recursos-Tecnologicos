using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBEstado
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[ESTADOS]";
        private readonly static string query_findByIdAmbito = "SELECT * FROM [dbo].[ESTADOS] WHERE [id_ambito]=@ID_AMBITO";
        private readonly static string query_findByIdEstado = "SELECT * FROM [dbo].[ESTADOS] WHERE [id_estado]=@ID_ESTADO";
        private readonly static string query_findByNombreAmbito = "SELECT e.* FROM [dbo].[ESTADOS] e JOIN [dbo].[AMBITO] a ON [e].[id_ambito]=[a].[id_ambito] WHERE [a].[nombre_estado]=@NOMBRE";
        private readonly static string query_findByIdAmbitoAndIdEstado = "SELECT * FROM [dbo].[ESTADOS] WHERE [id_ambito]=@ID_AMBITO AND [id_estado]=@ID_ESTADO";
        private readonly static string query_findByIdAmbitoAndNombreEstado = "SELECT * FROM [dbo].[ESTADOS] WHERE [id_ambito]=@ID_AMBITO AND [nombre_estado]=@NOMBRE";
        private readonly static string query_findByNombreAmbitoAndIdEstado = "SELECT e.* FROM [dbo].[ESTADOS] e JOIN [dbo].[AMBITO] a ON [e].[id_ambito]=[a].[id_ambito] WHERE [a].[nombre]=@NOMBRE_AMBITO AND [e].[id_estado]=@ID_ESTADO";
        private readonly static string query_findByNombreAmbitoAndNombreEstado = "SELECT e.* FROM [dbo].[ESTADOS] e JOIN [dbo].[AMBITO] a ON [e].[id_ambito]=[a].[id_ambito] WHERE [a].[nombre]=@NOMBRE_AMBITO AND [e].[nombre]=@NOMBRE_ESTADO";
    

        private static List<Estado> buildEstados(DataRowCollection drc)
        {
            List<Estado> estados = new List<Estado>();
            foreach (DataRow dr in drc)
            {
                estados.Add(buildEstado(dr));
            }
            return estados;
        }
        private static Estado buildEstado(DataRow dr)
        {
            int id_estado = Convert.ToInt32(dr["id_estado"]);
            int id_ambito = Convert.ToInt32(dr["id_ambito"]);
            string nombre = Convert.ToString(dr["nombre"]);
            string descripcion = Convert.ToString(dr["descripcion"]);

            return new Estado(id_estado, id_ambito, nombre, descripcion);
        }

        internal static List<Estado> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findAll);
            DataRowCollection dwc = ds.Rows;
            return buildEstados(dwc);
        }
        internal static List<Estado> findByIdAmbito(int id_ambito)
        {
            Conexion.limpiarParametros();
            Conexion.agregarParametro("@ID_AMBITO", id_ambito);

            DataTable ds = Conexion.EjecutarComando(query_findByIdAmbito);
            DataRowCollection dwc = ds.Rows;
            return buildEstados(dwc);
        }
        internal static List<Estado> findByNombreAmbito(string nombre_ambito)
        {
            Conexion.agregarParametro("@NOMBRE", nombre_ambito);

            DataTable ds = Conexion.EjecutarComando(query_findByNombreAmbito);
            DataRowCollection dwc = ds.Rows;
            return buildEstados(dwc);
        }
        internal static Estado findById(int id_estado)
        {
            Conexion.agregarParametro("@ID_ESTADO", id_estado);

            DataTable ds = Conexion.EjecutarComando(query_findByIdEstado);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildEstado(dr);
        }
        internal static Estado findByIdAmbitoAndIdEstado(int id_ambito, int id_estado)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_ESTADO", id_estado},
                {"@ID_AMBITO", id_ambito}
            };

            DataTable ds = Conexion.EjecutarComando(parametros, query_findByIdAmbitoAndIdEstado);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildEstado(dr);
        }
        internal static Estado findByIdAmbitoAndNombreEstado(int id_ambito, string nombre_estado)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_AMBITO", id_ambito},
                {"@NOMBRE", nombre_estado}
            };

            DataTable ds = Conexion.EjecutarComando(parametros, query_findByIdAmbitoAndNombreEstado);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildEstado(dr);
        }
        internal static Estado findByNombreAmbitoAndIdEstado(string nombre_ambito, int id_estado)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@NOMBRE_AMBITO", nombre_ambito},
                {"@ID_AMBITO", id_estado}
            };

            DataTable ds = Conexion.EjecutarComando(parametros, query_findByNombreAmbitoAndIdEstado);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildEstado(dr);
        }
        internal static Estado findByNombreAmbitoAndNombreEstado(string nombre_ambito, string nombre_estado)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@NOMBRE_AMBITO", nombre_ambito},
                {"@NOMBRE_ESTADO", nombre_estado}
            };

            DataTable ds = Conexion.EjecutarComando(parametros, query_findByNombreAmbitoAndNombreEstado);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildEstado(dr);
        }
    }
}
