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
        private int id_centro_investigacion { get; set; }
        private string nombre { get; set; }
        private string sigla { get; set; }
        private string direccion { get; set; }
        private string email { get; set; }
        private DateTime fecha_alta { get; set; }
        private string actividad { get; set; }
        private string reglamento { get; set; }
        private DateTime tiempo_antelacion { get; set; }
        private List<Director> directores { get; set; }
        private List<Cientifico> cientificos { get; set; }
        private List<ResponsableTecnico> responsables_tecnicos { get; set; }
        private DateTime fecha_baja { get; set; }
        private string motivo_baja { get; set; }



        public CentroInvestigacion(int id_centro_investigacion, string nombre, string sigla, string direccion, string email, DateTime fecha_alta, string actividad, string reglamento, DateTime tiempo_antelacion, DateTime fecha_baja, string motivo_baja)
        {
            this.id_centro_investigacion = id_centro_investigacion;
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.email = email;
            this.fecha_alta = fecha_alta;
            this.actividad = actividad;
            this.reglamento = reglamento;
            this.tiempo_antelacion = tiempo_antelacion;
            this.directores = Director.buscarCentroInvestigacion(id_centro_investigacion);
            this.cientificos = Cientifico.buscarPorIdCentroInvestigacion(id_centro_investigacion);
            this.responsables_tecnicos = ResponsableTecnico.buscarPorCentroInvestigacion(id_centro_investigacion);
            this.fecha_baja = fecha_baja;
            this.motivo_baja = motivo_baja;
        }

        public CentroInvestigacion(int id_centro_investigacion, string nombre, string sigla, string direccion, string email, DateTime fecha_alta, string actividad, string reglamento, DateTime tiempo_antelacion, List<Director> directores, List<PersonalCientifico> personales_cientificos, List<ResponsableTecnico> responsables_tecnicos, DateTime fecha_baja, string motivo_baja)
        {
            this.id_centro_investigacion = id_centro_investigacion;
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.email = email;
            this.fecha_alta = fecha_alta;
            this.actividad = actividad;
            this.reglamento = reglamento;
            this.tiempo_antelacion = tiempo_antelacion;
            this.directores = directores;
            this.cientificos = personales_cientificos;
            this.responsables_tecnicos = responsables_tecnicos;
            this.fecha_baja = fecha_baja;
            this.motivo_baja = motivo_baja;
        }

        internal static CentroInvestigacion buscarPorCentroInvestigacion(int id_centro_investigacion)
        {
            return DBCentroInvestigacion.findById(id_centro_investigacion);
        }
    }
}
