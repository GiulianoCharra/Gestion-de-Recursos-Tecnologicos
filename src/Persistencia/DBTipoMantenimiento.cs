using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBTipoMantenimiento
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[TIPOS_MANTENIMIENTOS]";
        private readonly static string query_findByIdTipoMantenimiento = "SELECT * FROM [dbo].[TIPOS_MANTENIMIENTOS] WHERE [id_tipo_mantenimiento]=@ID_TIPO_MANTENIMIENTO";
        private readonly static string query_insert = "INSERT INTO [dbo].[TIPOS_MANTENIMIENTOS] ([nombre], [descripcion]) VALUES (@NOBMRE, @DESCRIPCION )";

        /// <summary>
        /// Contruye y debuelve una lista de Tipos de Mantenimiento
        /// </summary>
        /// <param name="drc"></param>
        /// <returns></returns>
        private static List<TipoMantenimiento> buildTipoMantenimientos(DataRowCollection drc)
        {
            List<TipoMantenimiento> historial_turnos = new List<TipoMantenimiento>();
            foreach (DataRow dr in drc)
            {
                historial_turnos.Add(buildTipoMantenimiento(dr));
            }
            return historial_turnos;
        }


        /// <summary>
        /// Construye y devuelve un Tipos de Mantenimiento
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private static TipoMantenimiento buildTipoMantenimiento(DataRow dr)
        {
            int id_tipo_mantenimiento = Convert.ToInt32(dr["id_tipo_mantenimiento"]);
            string nombre = Convert.ToString(dr["nombre"]);
            string descripcion = Convert.ToString(dr["descripcion"]);
            //DateTime fecha_hora_fin = DateTime.Parse(Convert.ToString(dr["fecha_hora_fin"]));
            return new TipoMantenimiento(id_tipo_mantenimiento, nombre, descripcion);
        }


        /// <summary>
        /// Busca y devuelve todos los Tipos de Mantenimiento
        /// </summary>
        /// <returns></returns>
        internal static List<TipoMantenimiento> findAll()
        {
            DataTable dt = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = dt.Rows;
            return buildTipoMantenimientos(drc);
        }
        /// <summary>
        /// Busca y devuelve todos los Tipos de Mantenimiento y un Turno en especifico
        /// </summary>
        /// <param name="id_turno"></param>
        /// <returns></returns>
        internal static TipoMantenimiento findById(int id_tipo_mantenimiento)
        {
            Conexion.agregarParametro("@ID_TIPO_MANTENIMIENTO", id_tipo_mantenimiento);
            DataTable dt = Conexion.EjecutarComando(query_findByIdTipoMantenimiento);
            DataRowCollection drc = dt.Rows;
            return buildTipoMantenimiento(drc[0]);
        }

        /// <summary>
        /// Realiza la insercion de un nuevo Tipos de Mantenimiento
        /// </summary>
        /// <param name="id_tipo_mantenimiento"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        internal static void insert(int id_tipo_mantenimiento, int nombre, DateTime descripcion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@ID_TIPO_MANTENIMIENTO", id_tipo_mantenimiento},
                {"@NOBMRE", nombre},
                {"@DESCRIPCION", descripcion}
            };
            Conexion.EjecutarInsercion(parametros, query_insert);
        }
    }
}
