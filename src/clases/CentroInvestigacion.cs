using Gestión_de_Recursos_Tecnológicos.src.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class CentroInvestigacion
    {
        public int id_centro_investigacion { get; set; }
        public string nombre { get; set; }
        public string sigla { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_hora_inicio { get; set; }
        public string email { get; set; }
        public string actividad { get; set; }
        public string reglamento { get; set; }
        public int tiempo_antelacion { get; set; }
        public DateTime fecha_baja { get; set; }
        public string motivo_baja { get; set; }


        public List<Director> directores { get; set; }
        public List<Cientifico> cientificos { get; set; }
        public List<ResponsableTecnico> responsables_tecnicos { get; set; }



        public CentroInvestigacion(int id_centro_investigacion, string nombre, string sigla, string direccion, DateTime fecha_hora_inicio, string email, string actividad, string reglamento, int tiempo_antelacion, DateTime fecha_baja, string motivo_baja)
        {
            this.id_centro_investigacion = id_centro_investigacion;
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.email = email;
            this.actividad = actividad;
            this.reglamento = reglamento;
            this.tiempo_antelacion = tiempo_antelacion;
            this.fecha_baja = fecha_baja;
            this.motivo_baja = motivo_baja;
            this.directores = Director.buscarCentroInvestigacion(id_centro_investigacion);
            this.cientificos = Cientifico.buscarPorIdCentroInvestigacion(id_centro_investigacion);
            this.responsables_tecnicos = ResponsableTecnico.buscarPorCentroInvestigacion(id_centro_investigacion);
        }

        public CentroInvestigacion(int id_centro_investigacion, string nombre, string sigla, string direccion, string email, DateTime fecha_alta, string actividad, string reglamento, int tiempo_antelacion, List<Director> directores, List<Cientifico> cientificos, List<ResponsableTecnico> responsables_tecnicos, DateTime fecha_baja, string motivo_baja)
        {
            this.id_centro_investigacion = id_centro_investigacion;
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.email = email;
            this.fecha_hora_inicio = fecha_alta;
            this.actividad = actividad;
            this.reglamento = reglamento;
            this.tiempo_antelacion = tiempo_antelacion;
            this.directores = directores;
            this.cientificos = cientificos;
            this.responsables_tecnicos = responsables_tecnicos;
            this.fecha_baja = fecha_baja;
            this.motivo_baja = motivo_baja;
        }

        internal static CentroInvestigacion buscarPorId(int id_centro_investigacion)
        {
            return DBCentroInvestigacion.findById(id_centro_investigacion);
        }
        internal static List<CentroInvestigacion> buscarAll(int id_centro_investigacion)
        {
            return DBCentroInvestigacion.findAll();
        }
    }
}
