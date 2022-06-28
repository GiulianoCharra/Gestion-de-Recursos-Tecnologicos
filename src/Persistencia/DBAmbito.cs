using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBAmbito
    {

        private readonly static string query_findAll = "SELECT * FROM [dbo].[AMBITOS]";
        private readonly static string query_findById = "SELECT * FROM [dbo].[AMBITOS] WHERE [id_ambito]=@ID_AMBITO";
        private readonly static string query_findByNombre = "SELECT * FROM [dbo].[AMBITOS] WHERE [nombre]=@NOMBRE";


        private static List<Ambito> buildAmbitos(DataRowCollection drc)
        { 
            List<Ambito> ambitos = new List<Ambito>();
            foreach (DataRow dr in drc)
            {
                ambitos.Add(buildAmbito(dr));
            }
            return ambitos;
        }
        private static Ambito buildAmbito(DataRow dr)
        {
            int id_ambito = Convert.ToInt32(dr["id_ambito"]);
            string nombre = Convert.ToString(dr["nombre"]);

            return new Ambito(id_ambito, nombre);
        }


        internal static List<Ambito> findAll()
        {
            DataTable ds = Conexion.EjecutarComando(query_findById);
            DataRowCollection drc = ds.Rows;

            return buildAmbitos(drc);
        }
        internal static Ambito findById(int id_ambito)
        {
            Conexion.limpiarParametros();
            Conexion.agregarParametro("@ID_AMBITO", id_ambito);

            DataTable ds = Conexion.EjecutarComando(query_findById);
            DataRowCollection drc = ds.Rows;

            DataRow dr = drc[0];
            return buildAmbito(dr);
        }
        internal static Ambito findByNombre(string nombre)
        {
            Conexion.agregarParametro("@NOMBRE", nombre);

            DataTable ds = Conexion.EjecutarComando(query_findByNombre);
            DataRowCollection drc = ds.Rows;

            DataRow dr = drc[0];
            return buildAmbito(dr);
        }
    }
}
