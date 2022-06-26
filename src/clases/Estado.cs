using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Estado
    {
        public int id_estado { get; set; }
        public Ambito ambito { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Estado(int id_estado, int id_ambito, string nombre, string descripcion)
            :this(id_estado, Ambito.buscarById(id_ambito),nombre, descripcion)
        {
        }

        public Estado(int id_estado, Ambito ambito, string nombre, string descripcion)
        {
            this.id_estado = id_estado;
            this.ambito = ambito;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public bool esAmbitoTurno()
        {
            return ambito.esTurno();

        }
        public bool esAmbitoMantenimiento()
        {
            return ambito.esMantenimiento();

        }
        public bool esAmbitoRecursoTecnologico()
        {
            return ambito.esRecursoTecnologico();
        }
    }
}
