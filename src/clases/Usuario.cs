using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Usuario
    {
        public string user { get; set; }
        public string pass { get; set; }
        public Perfil perfil { get; set; }
        public bool habilitado { get; set; }

        public Usuario(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public Usuario(string user, string pass, Perfil perfil, bool habilidato) : this(user, pass)
        {
            this.perfil = perfil;
            this.habilitado = habilidato;
        }

        public static Usuario existeUsuario(string user, string pass)
        {
            string consultarUsuario = "SELECT * FROM [dbo].[USUARIOS] WHERE [usuario]=@USUARIO AND [contraseña]=@CONTRASEÑA";
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@USUARIO", user},
                {"@CONTRASEÑA", pass}
            };

            DataTable ds = Conexion.EjecutarComando(parametros, consultarUsuario);
            DataRowCollection dwc = ds.Rows;

            if (dwc.Count == 1)
            {
                string username = (string)dwc[0][0];
                string password = (string)dwc[0][1];
                Perfil perfil = Perfil.buscarPerfil((int)dwc[0][2]);
                bool habilidato = (bool)dwc[0][3];

                return new Usuario(username, password, perfil, habilidato);
            }

            return null;
        }

        internal static bool esUsuarioHabilitado(Usuario user)
        {
            return user.habilitado;
        }
        internal bool esUsuarioResponsableTecnico()
        {
            return perfil.esResponsableTecnico();
        }

        public StringBuilder mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Usuario: ").Append(user);   
            sb.Append("Contraseña: ").Append(pass);   
            sb.Append("Habilitado: ").Append(habilitado);   
            sb.Append("Perfil: ").Append("\t").Append(perfil.mostrarDatos());
            sb.Append("\n");
            return sb;
        }
    }
}
