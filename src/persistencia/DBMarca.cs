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
        private readonly static string query_insert = "INSERT INTO [dbo].[MARCAS] ([nombre] ,[descripcion]) VALUES (@NOMBRE, @DESCRIPCION )";


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
            throw new NotImplementedException();
        }

        internal static List<Marca> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = ds.Rows;

            return buildMarcas(drc);
        }

        internal static Marca findById(int id_marca)
        {
            throw new NotImplementedException();
        }


    }
}
