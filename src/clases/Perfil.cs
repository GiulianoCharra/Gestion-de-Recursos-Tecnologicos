using System;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Perfil
    {
        private int id_perfil { get; set; }
        private string nombre { get; set; }

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
    }
}