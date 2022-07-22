using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Mantenimiento
    {
        public int id_matenimiento { get; set; }
        public RecursoTecnologico recurso_tecnologico { get; set; }
        public TipoMantenimiento tipo_mantenimiento { get; set; }
        public DateTime fecha_hora_ingreso { get; set; }
        public DateTime fecha_hora_inicio { get; set; }
        public DateTime fecha_hora_fin_prevista { get; set; }
        public DateTime fecha_hora_fin_real { get; set; }
        public string motivo { get; set; }

        public Mantenimiento(int id_matenimiento, RecursoTecnologico recurso_tecnologico, TipoMantenimiento tipo_mantenimiento, DateTime fecha_hora_ingreso, DateTime fecha_hora_inicio, DateTime fecha_hora_fin_prevista, DateTime fecha_hora_fin_real, string motivo)
        {
            this.id_matenimiento = id_matenimiento;
            this.recurso_tecnologico = recurso_tecnologico;
            this.tipo_mantenimiento = tipo_mantenimiento;
            this.fecha_hora_ingreso = fecha_hora_ingreso;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin_prevista = fecha_hora_fin_prevista;
            this.fecha_hora_fin_real = fecha_hora_fin_real;
            this.motivo = motivo;
        }
        public Mantenimiento(int id_matenimiento, int id_recurso_tecnologico, int id_tipo_mantenimiento, DateTime fecha_hora_ingreso, DateTime fecha_hora_inicio, DateTime fecha_hora_fin_prevista, DateTime fecha_hora_fin_real, string motivo)
        :this(id_matenimiento, RecursoTecnologico.buscarPorId(id_recurso_tecnologico), TipoMantenimiento.buscarPorId(id_tipo_mantenimiento), fecha_hora_ingreso, fecha_hora_inicio, fecha_hora_fin_prevista, fecha_hora_fin_real, motivo)
        {
        }

        internal static void insertarNuevoMantenimientoCorrectivo(int id_recurso_tecnologico,DateTime fecha_hora_inicio, DateTime fecha_hora_fin_prevista, string motivo)
        {
            List<TipoMantenimiento> tipos = TipoMantenimiento.buscarAll();
            TipoMantenimiento tipo = null;
            foreach (TipoMantenimiento t in tipos)
            {
                if (t.esTipoMantenimientoCorrectivo())
                {
                    tipo = t;
                    break;
                }
            }

            DBMantenimiento.insert(id_recurso_tecnologico, tipo.id_tipo_mantenimiento, fecha_hora_inicio, fecha_hora_fin_prevista, motivo);
        }
    }
}
