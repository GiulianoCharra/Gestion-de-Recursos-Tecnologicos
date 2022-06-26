using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Gestión_de_Recursos_Tecnológicos.src.Persistencia;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Usuario
    {
        public string user { get; set; }
        public string pass { get; set; }
        public Perfil perfil { get; set; }
        public bool habilitado { get; set; }

        public Usuario(string user, string pass, int perfil, bool habilidato)
            :this(user, pass, Perfil.buscarById(perfil), habilidato)
        {
        }
        public Usuario(string user, string pass, Perfil perfil, bool habilidato)
        {
            this.user = user;
            this.pass = pass;
            this.perfil = perfil;
            this.habilitado = habilidato;
        }

        internal static Usuario buscarPorUsuario(string usuario)
        {
            return DBUsuario.findByUser(usuario);
        }

        /// <summary>
        /// Busca si el usuario ingresado existe
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static Usuario buscarByUsuarioAndPass(string user, string pass)
        {
            return DBUsuario.findByUserAndPass(user, pass);
        }

        /// <summary>
        /// Devuelver true si el usuario esta habilitado y false si no lo esta
        /// </summary>
        /// <returns></returns>
        internal bool esHabilitado()
        {
            return habilitado;
        }

        /// <summary>
        /// Pregunta si el usuario actual es Personal Tecnico
        /// </summary>
        /// <returns></returns>
        internal bool esUsuarioResponsableTecnico()
        {
            return perfil.esResponsableTecnico();
        }
        /// <summary>
        /// Pregunta si el usuario actual es Personal Tecnico
        /// </summary>
        /// <returns></returns>
        internal bool esUsuarioDirector()
        {
            return perfil.esDirector();
        }
        /// <summary>
        /// Pregunta si el usuario actual es Personal Tecnico
        /// </summary>
        /// <returns></returns>
        internal bool esUsuarioCientifico()
        {
            return perfil.esCientifico();
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
