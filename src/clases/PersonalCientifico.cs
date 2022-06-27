using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class PersonalCientifico
    {
        public int legajo { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string dni { get; set; }
        public string email_personal { get; set; }
        public string email_institucional { get; set; }
        public string telefono { get; set; }

        public PersonalCientifico(int legajo, string apellidos, string nombres, string dni, string email_personal, string email_institucional, string telefono)
        {
            this.legajo = legajo;
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.dni = dni;
            this.email_personal = email_personal;
            this.email_institucional = email_institucional;
            this.telefono = telefono;
        }

        internal static PersonalCientifico buscarPorPersonalCientifico(int id_personal_cientifico)
        {
            return DBPersonalCientifico.findById(id_personal_cientifico);
        }
    }
}
