using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class RecursoTecnologico
    {
        private int id_recurso_tecnologico { get; set; }
        private TipoRecursoTecnologico tipo_recurso_tecnologico { get; set; }
        private Marca marca { get; set; }
        private Modelo modelo { get; set; }
        private DateTime fecha_alta { get; set; }
        private DateTime fraccionamiento { get; set; }
        private Image imagen { get; set; }
        private string descripcion { get; set; }
        private ResponsableTecnico responsable_tecnico { get; set; }
        private PersonalCientifico personal_cientifico { get; set; }
        private CentroInvestigacion centro_investigacion { get; set; }
        private List<HistorialRecursoTecnologico> historiales_recurso_tecnologico { get; set; }

        public RecursoTecnologico()
        {
        }

        public RecursoTecnologico(int id_recurso_tecnologico,
            TipoRecursoTecnologico tipo_recurso_tecnologico,
            Marca marca,
            Modelo modelo,
            DateTime fecha_alta,
            DateTime fraccionamiento,
            Image imagen,
            string descripcion,
            ResponsableTecnico responsable_tecnico,
            PersonalCientifico personal_cientifico,
            CentroInvestigacion centro_investigacion,
            HistorialRecursoTecnologico[] historial_recurso_tecnologico)
        {
            this.id_recurso_tecnologico = id_recurso_tecnologico;
            this.tipo_recurso_tecnologico = tipo_recurso_tecnologico;
            this.marca = marca;
            this.modelo = modelo;
            this.fecha_alta = fecha_alta;
            this.fraccionamiento = fraccionamiento;
            this.imagen = imagen;
            this.descripcion = descripcion;
            this.responsable_tecnico = responsable_tecnico;
            this.personal_cientifico = personal_cientifico;
            this.centro_investigacion = centro_investigacion;
            this.historiales_recurso_tecnologico = historiales_recurso_tecnologico;
        }


        public RecursoTecnologico(int id_recurso_tecnologico,
            int id_tipo_recurso_tecnologico,
            int id_marca,
            int id_modelo,
            DateTime fecha_alta,
            DateTime fraccionamiento,
            Image imagen,
            string descripcion,
            int id_responsable_tecnico,
            int id_personal_cientifico,
            int id_centro_investigacion)
        {
            this.id_recurso_tecnologico = id_recurso_tecnologico;
            this.tipo_recurso_tecnologico = TipoRecursoTecnologico.findById(id_tipo_recurso_tecnologico);
            this.marca = Marca.busrcarPorId(id_marca);
            this.modelo = Modelo.findById(id_modelo, id_marca);
            this.fecha_alta = fecha_alta;
            this.fraccionamiento = fraccionamiento;
            this.imagen = imagen;
            this.descripcion = descripcion;
            this.responsable_tecnico = ResponsableTecnico.buscarPorId(id_responsable_tecnico, id_personal_cientifico, id_centro_investigacion);
            this.centro_investigacion = CentroInvestigacion.buscarPorCentroInvestigacion(id_centro_investigacion);
            this.historiales_recurso_tecnologico = HistorialRecursoTecnologico.findByIdRecursoTecnologico(id_recurso_tecnologico);
        }


        internal void actualizarEstadoMantenimientoCorrectivo()
        {
            //Ambito recurso_tecnologico = Ambito.buscarAmbitoRecursoTecnologico();
            //Estado estadoMantenimiento = Estado.buscarEstadoRecursoTecnologicoMantenimiento(recurso_tecnologico);
            //HistorialRecursoTecnologico nuevo = new HistorialRecursoTecnologico(this, estadoMantenimiento, DateTime.Now);
        }
    }
}
