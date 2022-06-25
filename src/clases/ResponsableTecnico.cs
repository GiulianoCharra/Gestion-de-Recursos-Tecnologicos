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
        private int id_responsable_tecnico { get; set; }
        private PersonalCientifico personal_cientifico { set; get; }
        private CentroInvestigacion centro_investigacion { set; get; }
        private Usuario usuario { get; set; }
        private DateTime fecha_hora_inicio { get; set; }
        private DateTime fecha_hora_fin { get; set; }

        public ResponsableTecnico(int id_responsable_tecnico, PersonalCientifico personal_cientifico, CentroInvestigacion centro_investigacion, Usuario usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            this.id_responsable_tecnico = id_responsable_tecnico;
            this.personal_cientifico = personal_cientifico;
            this.centro_investigacion = centro_investigacion;
            this.usuario = usuario;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }
        public ResponsableTecnico(int id_responsable_tecnico, int id_personal_cientifico, int id_centro_investigacion, string usuario, DateTime fecha_hora_inicio, DateTime fecha_hora_fin)
        {
            this.id_responsable_tecnico = id_responsable_tecnico;
            this.personal_cientifico = PersonalCientifico.findById(id_personal_cientifico);
            this.centro_investigacion = CentroInvestigacion.findById(id_centro_investigacion);
            this.usuario = Usuario.buscarUsuario(usuario);
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
        }

        internal static ResponsableTecnico buscarResponsableTecnicoPorUsuario(Usuario user)
        {
            return DBResponsableTecnico.findByUser(user);
        }

        internal static ResponsableTecnico buscarResponsableTecnico(int id_responsable_tecnico, int id_personal_cientifico, int id_centro_investigacion)
        {
            return DBResponsableTecnico.findById(id_responsable_tecnico, id_personal_cientifico, id_centro_investigacion);
        }



    }
}
