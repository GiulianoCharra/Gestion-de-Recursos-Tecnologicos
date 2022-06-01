using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Usuario
    {
        public string user { get; set; }
        public string pass { get; set; }
        public Perfil perfil { get; set; }
        public bool habilidato { get; set; }

        public Usuario(string user, string pass)
        {
            this.user = nombre;
            this.pass = contraseña;
        }



        public static bool existeUsuario(string user, string pass)
        {
            string consultarUsuario = "SELECT * FROM [dbo].[USUARIOS] WHERE usuario=@USUARIO AND contraseña=@CONTRASEÑA";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@USUARIO", user);   
            parametros.Add("@CONTRASEÑA", pass);   

           
            int cantFilas = Conexion.EjecutarComando(parametros, consultarUsuario).Rows.Count;

            if (cantFilas > 0)
            {
                return true;
            }
            return false;
        }

        internal static bool esUsuarioHabilitado(string user, string pass)
        {
            return true;
        }
        internal bool esUsuarioResponsableTecnico()
        {
            return perfil.esResponsableTecnico();
        }
    }
}
