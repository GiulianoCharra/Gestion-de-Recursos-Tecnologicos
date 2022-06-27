using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.persistencia
{
    internal class DBModelo
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[MODELOS]";
        private readonly static string query_findByIdMarca = "SELECT * FROM [dbo].[MODELOS] WHERE [id_marca] = @ID_MARCA";
        private readonly static string query_findByIdModelo = "SELECT * FROM [dbo].[MODELOS] WHERE [id_modelo] = @ID_MODELO";
        private readonly static string query_findByIdModeloAndIdMarca = "SELECT * FROM [dbo].[MODELOS] WHERE [id_modelo] = @ID_MODELO AND [id_marca] = @ID_MARCA";
        private readonly static string query_insert = "INSERT INTO [dbo].[MODELOS] ([id_marca], [nombre] ,[descripcion]) VALUES (@ID_MARCA, @NOMBRE, @DESCRIPCION )";
        private readonly static string query_update = "UPDATE [dbo].[MODELOS] SET [nombre] = @NOMBRE ,[descripcion] = @DESCRIPCION WHERE [id_modelo] = @ID_MODELO AND [id_marca] = @ID_MARCA";

        private static List<Modelo> buildModelos(DataRowCollection drc)
        {
            List<Modelo> modelos = new List<Modelo>();
            foreach (DataRow dr in drc)
            {
                modelos.Add(buildModelo(dr));
            }
            return modelos;
        }
        private static Modelo buildModelo(DataRow dr)
        {
            int id_modelo = Convert.ToInt32(dr["id_modelo"]);
            int id_marca = Convert.ToInt32(dr["id_marca"]);
            string nombre = Convert.ToString(dr["nombre"]);
            string descripcion = Convert.ToString(dr["descripcion"]);
            return new Modelo(id_modelo, id_marca, nombre, descripcion);
        }

        internal static void insert(int id_marca, string nombre, string descripcion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@ID_MARCA", id_marca},
                {"@NOMBRE", nombre},
                {"@DESCRIPCION", descripcion}
            };
            Conexion.EjecutarInsercion(parametros, query_insert);
        }
        internal static void update(int id_modelo, int id_marca, string nombre, string descripcion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_MODELO", id_modelo},
                {"@ID_MARCA", id_marca},
                {"@NOMBRE", nombre},
                {"@DESCRIPCION", descripcion}
            };

            Conexion.EjecutarInsercion(parametros, query_update);
        }


        internal static Modelo findById(int id_modelo, int id_marca)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"@ID_MODELO", id_modelo},
                {"@ID_MARCA", id_marca}
            };

            DataTable ds = Conexion.EjecutarComando(parametros, query_findByIdModeloAndIdMarca);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildModelo(dr);
        }
        internal static List<Modelo> findByIdMarca(int id_marca)
        {
            Conexion.limpiarParametros();
            Conexion.agregarParametro("@ID_MARCA", id_marca);

            DataTable ds = Conexion.EjecutarComando(query_findByIdMarca);
            DataRowCollection drc = ds.Rows;
            return buildModelos(drc);
        }
        internal static List<Modelo> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = ds.Rows;

            return buildModelos(drc);
        }
    }
}
