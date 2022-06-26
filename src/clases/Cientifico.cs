using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Cientifico
    {
        public int id_cientifico { get; set; }
        public PersonalCientifico personal_cientifico { set; get; }
        public CentroInvestigacion centro_investigacion { set; get; }
        public Usuario usuario { get; set; }
        public DateTime fecha_hora_inicio { get; set; }
        public DateTime fecha_hora_fin { get; set; }

        public Cientifico(int id_cientifico, PersonalCientifico personal_cientifico, CentroInvestigacion centro_investigacion, Usuario usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            this.id_cientifico = id_cientifico;
            this.personal_cientifico = personal_cientifico;
            this.centro_investigacion = centro_investigacion;
            this.usuario = usuario;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }

        public Cientifico(int id_cientifico, int id_personal_cientifico, int id_centro_investigacion, string usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            this.id_cientifico = id_cientifico;
            this.personal_cientifico = PersonalCientifico.buscarPorPersonalCientifico(id_personal_cientifico);
            this.centro_investigacion = CentroInvestigacion.buscarPorCentroInvestigacion(id_centro_investigacion);
            this.usuario = Usuario.buscarPorUsuario(usuario);
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }


        internal static Cientifico buscarPorIdCientifico(int id_cientifico)
        {
            return DBCientifico.findByIdCientifico(id_cientifico);
        }
        internal static Cientifico buscarPorUsuario(string user)
        {
            return DBCientifico.findByUser(user);
        }
        internal static List<Cientifico> buscarPorIdCentroInvestigacion(int id_centro_investigacion)
        {
            return DBCientifico.findByCentroInvestigacion(id_centro_investigacion);
        }
    }
}
