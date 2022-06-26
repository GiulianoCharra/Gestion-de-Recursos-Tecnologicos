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
        private readonly static string query_findByAmbito = "SELECT * FROM [dbo].[ESTADOS] WHERE [id_ambito]=@ID_AMBITO";
        private readonly static string query_findById = "SELECT * FROM [dbo].[ESTADOS] WHERE [id_estado]=@ID_ESTADO";
        private readonly static string query_findByNombre = "SELECT * FROM [dbo].[ESTADOS] WHERE [nombre]=@NOMBRE";
    

        private static List<Estado> buildEstados(DataRowCollection drc)
        {
            List<Estado> estados = new List<Estado>();
            foreach (DataRow dr in drc)
            {
                estados.Add(buildestado(dr));
            }
            return estados;
        }
        private static Estado buildestado(DataRow dr)
        {
            int id_estado = Convert.ToInt32(dr["id_estado"]);
            int id_ambito = Convert.ToInt32(dr["id_ambito"]);
            string nombre = Convert.ToString(dr["nombre"]);
            string descripcion = Convert.ToString(dr["descripcion"]);

            return new Estado(id_estado, id_ambito, nombre, descripcion);
        }


    }
}
