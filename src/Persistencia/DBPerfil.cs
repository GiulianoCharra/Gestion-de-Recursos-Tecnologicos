using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBPerfil
    {
        private readonly static string query_findAll = "SELECT * FROM [dbo].[PERFILES]";
        private readonly static string query_findById = "SELECT * FROM [dbo].[PERFILES] WHERE [id_perfil]=@ID_PERFIL";

        private static List<Perfil> buildPerfiles(DataRowCollection drc)
        {
            List<Perfil> perfiles = new List<Perfil>();
            foreach (DataRow dr in drc)
            {
                perfiles.Add(buildPerfil(dr));
            }
            return perfiles;
        }        
        private static Perfil buildPerfil(DataRow dr)
        {
            int id_perfil = Convert.ToInt32(dr["id_perfil"]);
            string nombre = Convert.ToString(dr["nombre"]);
            return new Perfil(id_perfil, nombre);
        }

        internal static List<Perfil> findAll()
        {
            DataTable dt = Conexion.EjecutarComando(query_findAll);
            DataRowCollection drc = dt.Rows;
            return buildPerfiles(drc);

        }
        internal static Perfil findById(int id_perfil)
        {
            Conexion.agregarParametro("@ID_PERFIL", id_perfil);
            DataTable dt = Conexion.EjecutarComando(query_findById);

            DataRow dr = dt.Rows[0];
            return buildPerfil(dr);
        }
    }
}
