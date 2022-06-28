using Gestión_de_Recursos_Tecnológicos.src.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class ResponsableTecnico
    {
        public int id_responsable_tecnico { get; set; }
        public PersonalCientifico personal_cientifico { set; get; }
        public int id_centro_investigacion { get; set; }
        public Usuario usuario { get; set; }
        public DateTime fecha_hora_inicio { get; set; }
        public DateTime fecha_hora_fin { get; set; }


        public ResponsableTecnico(int id_responsable_tecnico, int id_personal_cientifico, int id_centro_investigacion, string usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        :this(id_responsable_tecnico,
             PersonalCientifico.buscarPorIdPersonalCientifico(id_personal_cientifico),
             id_centro_investigacion,
             Usuario.buscarPorUsuario(usuario),
             fecha_hora_inicio,
             fecha_hora_fin)
        {
        }
        public ResponsableTecnico(int id_responsable_tecnico, PersonalCientifico personal_cientifico,int id_centro_investigacion, Usuario usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            this.id_responsable_tecnico = id_responsable_tecnico;
            this.personal_cientifico = personal_cientifico;
            this.id_centro_investigacion = id_centro_investigacion;
            this.usuario = usuario;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }

        internal static ResponsableTecnico buscarPorUsuario(Usuario user)
        {
            return DBResponsableTecnico.findByUser(user.user);
        }
        internal static ResponsableTecnico buscarPorUsuario(string user)
        {
            return DBResponsableTecnico.findByUser(user);
        }

        internal static List<ResponsableTecnico> buscarPorCentroInvestigacion(int id_centro_investigacion)
        {
            return DBResponsableTecnico.findByCentroInvestigacion(id_centro_investigacion);
        }

        internal static ResponsableTecnico buscarPorId(int id_responsable_tecnico, int id_personal_cientifico, int id_centro_investigacion)
        {
            return DBResponsableTecnico.findById(id_responsable_tecnico, id_personal_cientifico, id_centro_investigacion);
        }
    }
}
