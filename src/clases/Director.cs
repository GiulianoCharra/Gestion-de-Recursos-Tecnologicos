using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Director
    {
        public int id_director { get; set; }
        public PersonalCientifico personal_cientifico { set; get; }
        public Usuario usuario { get; set; }
        public DateTime fecha_hora_inicio { get; set; }
        public DateTime fecha_hora_fin { get; set; }

        public Director(int id_director, PersonalCientifico personalCientifico, Usuario usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            this.id_director = id_director;
            this.personal_cientifico = personalCientifico;
            this.usuario = usuario;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }
        public Director(int id_director, int id_personal_cientifico, int id_centro_investigacion, string usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            this.id_director = id_director;
            this.personal_cientifico = PersonalCientifico.buscarPorPersonalCientifico(id_personal_cientifico);
            this.usuario = Usuario.buscarPorUsuario(usuario);
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }

        internal static Director buscarPorIdDirector(int id_director)
        {
            return DBDirector.findByIdDirector(id_director);
        }

        internal static List<Director> buscarCentroInvestigacion(int id_centro_investigacion)
        {
            return DBDirector.findByCentroInvestigacion(id_centro_investigacion);
        }

        internal static Director buscarPorUsuario(string user)
        {
            return DBDirector.findByUser(user);
        }


        internal static Director buscarPorId(int id_director, int id_personal_cientifico, int id_centro_investigacion)
        {
            return DBDirector.findById(id_director, id_personal_cientifico, id_centro_investigacion);
        }
    }
}
