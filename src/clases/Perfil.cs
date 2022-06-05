using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Perfil
    {
        private int id_perfil { get; set; }
        private string nombre { get; set; }

        public Perfil(int id_perfil, string nombre)
        {
            this.id_perfil = id_perfil;
            this.nombre = nombre;
        }

        internal bool esResponsableTecnico()
        {
            return nombre.Equals("Responsable Tecnico") ? true : false;
        }


        internal bool esCientifico()
        {
            return nombre.Equals("Cientifico") ? true : false;
        }

        internal bool esDirector()
        {
            return nombre.Equals("Director") ? true : false;
        }

        internal static Perfil buscarPerfil(int id_perfil)
        {
            string consultar = "SELECT [id_perfil],[nombre] FROM[dbo].[PERFILES] WHERE [id_perfil]=@ID_PERFIL";

            Dictionary<string, object> parametros = new Dictionary<string, object> {
                { "@ID_PERFIL", id_perfil } 
            };
            
            DataTable dt = Conexion.EjecutarComando(parametros,consultar);
            Perfil perfil = new Perfil(
                (int)dt.Rows[0][0],
                (string)dt.Rows[0][1]);

            return perfil;
        }

        public StringBuilder mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Id: ").Append(id_perfil);
            sb.Append("Nombre: ").Append(nombre);
            return sb;
        }
    }
}