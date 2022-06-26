using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Ambito
    {
        public int id_ambito { get; set; }
        public string nombre { get; set; }

        public Ambito(int id_ambito, string nombre)
        {
            this.id_ambito = id_ambito;
            this.nombre = nombre;
        }

        internal static Ambito buscarById(int id_ambito)
        {
            return DBAmbito.findById(id_ambito);
        }

        internal bool esTurno()
        {
            return nombre.Equals("Turno");
        }

        internal bool esMantenimiento()
        {
            return nombre.Equals("Mantenimiento");
        }

        internal bool esRecursoTecnologico()
        {
            return nombre.Equals("Recurso Tecnologico");
        }
    }
}
