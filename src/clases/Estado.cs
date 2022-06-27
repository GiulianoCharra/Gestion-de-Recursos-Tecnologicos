using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
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

        internal static List<Estado> buscarByAmbitoMantenimiento()
        {
            return buscarByAmbito("Mantenimiento");
        }
        internal static List<Estado> buscarByAmbitoTurno()
        {            
            return buscarByAmbito("Turno");
        }
        internal static List<Estado> buscarByAmbitoRecursoTecnologico()
        {
            return buscarByAmbito("Recurso Tecnologico");
        }
        internal static List<Estado> buscarByAmbito(string ambito)
        {
            int id_ambito = Ambito.buscarByNombre(ambito).id_ambito;
            return DBEstado.findByIdAmbito(id_ambito);
        }
        internal static Estado buscarByIdEstado(int id_estado)
        {
            return DBEstado.findById(id_estado);
        }

        internal bool esDisponible()
        {
            return nombre.Equals("Disponible");
        }
    }
}
