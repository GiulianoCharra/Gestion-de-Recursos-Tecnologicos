using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBAmbito
    {

        private readonly static string query_findById = "SELECT * FROM [dbo].[AMBITOS] WHERE [id_ambito]=@ID_AMBITO";


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



        internal static Ambito findById(int id_ambito)
        {
            Conexion.agregarParametro("@ID_AMBITO", id_ambito);

            DataTable ds = Conexion.EjecutarComando(query_findById);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildAmbito(dr);
        }
    }
}
