using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Persistencia
{
    internal class DBUsuario
    {
        private readonly static string query_findByUser = "SELECT * FROM [dbo].[USUARIOS] WHERE [usuario]=@USUARIO";
        private readonly static string query_findByUserAndPass = "SELECT * FROM [dbo].[USUARIOS] WHERE [usuario]=@USUARIO AND [contraseña]=@CONTRASEÑA";

        private static Usuario buildUser(DataRow rs)
        {
            string username = Convert.ToString(rs[0]);
            string password = Convert.ToString(rs[1]);
            int perfil = Convert.ToInt32(rs[2]);
            bool habilidato = Convert.ToBoolean(rs[3]);

            return new Usuario(username, password, perfil, habilidato);
        }

        public static Usuario findByUserAndPass(string user, string pass)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@USUARIO", user},
                {"@CONTRASEÑA", pass}
            };

            DataTable ds = Conexion.EjecutarComando(parametros, query_findByUserAndPass);
            DataRowCollection dwc = ds.Rows;
            
            DataRow dr = dwc[0];
            return buildUser(dr);
        }
        internal static Usuario findByUser(string usuario)
        {
            Conexion.agregarParametro("@USUARIO", usuario);

            DataTable ds = Conexion.EjecutarComando(query_findByUser);
            DataRowCollection dwc = ds.Rows;

            DataRow dr = dwc[0];
            return buildUser(dr);
        }
    }
}
