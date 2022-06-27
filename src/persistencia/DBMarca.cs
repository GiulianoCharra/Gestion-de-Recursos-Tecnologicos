using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.persistencia
{
    internal class DBMarca
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[MARCAS]";
        private readonly static string query_findById = "SELECT * FROM [dbo].[MARCAS] WHERE [id_marca] = @ID_MARCA";
        private readonly static string query_insert = "INSERT INTO [dbo].[MARCAS] ([nombre] ,[descripcion]) VALUES (@NOMBRE, @DESCRIPCION )";
        private readonly static string query_update = "UPDATE [dbo].[MARCAS] SET [nombre] = @NOMBRE ,[descripcion] = @DESCRIPCION WHERE [id_marca] = @ID_MARCA";


        private static List<Marca> buildMarcas(DataRowCollection drc)
        {
            List<Marca> marcas = new List<Marca>();
            foreach (DataRow dr in drc)
            {
                marcas.Add(buildMarca(dr));
            }
            return marcas;
        }
        private static Marca buildMarca(DataRow dr)
        {
            int id_marca = Convert.ToInt32(dr["id_marca"]);
            string nombre = Convert.ToString(dr["nombre"]);
            string descripcion = Convert.ToString(dr["descripcion"]);
            return new Marca(id_marca, nombre, descripcion);
        }

        internal static void insert(string nombre, string descripcion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@NOMBRE", nombre},
                {"@DESCRIPCION", descripcion}
            };

            Conexion.EjecutarInsercion(parametros, query_insert);
        }
        internal static void update(int id_marca, string nombre, string descripcion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_MARCA", id_marca},
                {"@NOMBRE", nombre},
                {"@DESCRIPCION", descripcion}
            };

            Conexion.EjecutarInsercion(parametros, query_update);
        }



        internal static Marca findById(int id_marca)
        {
            Conexion.agregarParametro("@ID_MARCA", id_marca);

            DataTable ds = Conexion.EjecutarComando(query_findById);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildMarca(dr);
        }
        internal static List<Marca> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = ds.Rows;

            return buildMarcas(drc);
        }
    }
}
