using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Perfil
    {
        public int id_perfil { get; set; }
        public string nombre { get; set; }

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

        internal static Perfil buscarById(int id_perfil)
        {
            return DBPerfil.findById(id_perfil);
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