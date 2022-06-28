using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBPersonalCientifico
    {
        private readonly static string query_findById = "SELECT * FROM [dbo].[PERSONAL_CIENTIFICO] WHERE [legajo]=@LEGAJO";


        private static List<PersonalCientifico> buildPersonalCientificos(DataRowCollection dwc)
        {
            List<PersonalCientifico> personalcientificos = new List<PersonalCientifico>();
            foreach (DataRow dr in dwc)
            {
                personalcientificos.Add(buildPersonalCientifico(dr));
            }
            return personalcientificos;
        }

        private static PersonalCientifico buildPersonalCientifico(DataRow dr)
        {
            int legajo = Convert.ToInt32(dr["legajo"]);
            string apellidos = Convert.ToString(dr["apellidos"]);
            string nombres = Convert.ToString(dr["nombres"]);
            string dni = Convert.ToString(dr["dni"]);
            string email_personal = Convert.ToString(dr["email_personal"]);
            string email_institucional = Convert.ToString(dr["email_institucional"]);
            string telefono = Convert.ToString(dr["telefono"]);

            return new PersonalCientifico(legajo, apellidos, nombres, dni, email_personal, email_institucional, telefono);
        }

        internal static PersonalCientifico findById(int id_personal_cientifico)
        {
            Conexion.limpiarParametros();
            Conexion.agregarParametro("@LEGAJO", id_personal_cientifico);

            DataTable ds = Conexion.EjecutarComando(query_findById);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildPersonalCientifico(dr);
        }
    }
}
