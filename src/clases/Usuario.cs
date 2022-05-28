using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Usuario
    {
        private string nombre;
        private string contraseña;

        public Usuario(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }


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

        internal bool esUsuarioHabilitado(string user, string pass)
        {
            return true;
        }
    }
}
