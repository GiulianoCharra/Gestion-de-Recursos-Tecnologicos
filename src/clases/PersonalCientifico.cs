using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class PersonalCientifico
    {
        private int legajo { get; set; }
        private string apellidos { get; set; }
        private string nombres { get; set; }
        private string dni { get; set; }
        private string email_personal { get; set; }
        private string email_institucional { get; set; }
        private int telefono { get; set; }

        internal static PersonalCientifico findById(int id_personal_cientifico)
        {
            throw new NotImplementedException();
        }
    }
}
