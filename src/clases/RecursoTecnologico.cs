﻿using Gestión_de_Recursos_Tecnológicos.src.persistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class RecursoTecnologico
    {
        public int id_recurso_tecnologico { get; set; }
        public TipoRecursoTecnologico tipo_recurso_tecnologico { get; set; }
        public Marca marca { get; set; }
        public Modelo modelo { get; set; }
        public DateTime fecha_alta { get; set; }
        public TimeSpan fraccionamiento { get; set; }
        public byte[] imagen { get; set; }
        public string descripcion { get; set; }
        public int id_responsable_tecnico { get; set; }
        public int id_personal_cientifico { get; set; }
        public int id_centro_investigacion { get; set; }
        public List<HistorialRecursoTecnologico> historiales_recurso_tecnologico { get; set; }

        public RecursoTecnologico()
        {
        }

        public RecursoTecnologico(
            int id_recurso_tecnologico,
            TipoRecursoTecnologico tipo_recurso_tecnologico,
            Marca marca,
            Modelo modelo,
            DateTime fecha_alta,
            TimeSpan fraccionamiento,
            byte[] imagen,
            string descripcion,
            int id_responsable_tecnico,
            int id_personal_cientifico,
            int id_centro_investigacion,
            List<HistorialRecursoTecnologico> historial_recurso_tecnologico)
        {
            this.id_recurso_tecnologico = id_recurso_tecnologico;
            this.tipo_recurso_tecnologico = tipo_recurso_tecnologico;
            this.marca = marca;
            this.modelo = modelo;
            this.fecha_alta = fecha_alta;
            this.fraccionamiento = fraccionamiento;
            this.imagen = imagen;
            this.descripcion = descripcion;
            this.id_responsable_tecnico = id_responsable_tecnico;
            this.id_personal_cientifico = id_personal_cientifico;
            this.id_centro_investigacion = id_centro_investigacion;
            this.historiales_recurso_tecnologico = historial_recurso_tecnologico;
        }

        public RecursoTecnologico(int id_recurso_tecnologico,
            int id_tipo_recurso_tecnologico,
            int id_marca,
            int id_modelo,
            DateTime fecha_alta,
            TimeSpan fraccionamiento,
            byte[] imagen,
            string descripcion,
            int id_responsable_tecnico,
            int id_personal_cientifico,
            int id_centro_investigacion)
        :this(
            id_recurso_tecnologico,
            TipoRecursoTecnologico.findById(id_tipo_recurso_tecnologico),
            Marca.buscarPorId(id_marca),
            Modelo.buscarPorId(id_modelo, id_marca),
            fecha_alta,
            fraccionamiento,
            imagen,
            descripcion,
            id_responsable_tecnico,
            id_personal_cientifico,
            id_centro_investigacion,
            HistorialRecursoTecnologico.buscarByIdRecursoTecnologico(id_recurso_tecnologico))
        {
        }

        public bool esDisponible()
        {
            return historiales_recurso_tecnologico.Last().esDisponible();
        }

        internal static List<RecursoTecnologico> buscarPorResponsable(int id_responsable_tecnico, int id_personal_cientifico, int id_centro_investigacion)
        {
            return DBRecursoTecnologico.findByIdResponsableTecnicoAndIdPersonalCientificoAndIdCentroInvestigacionOrderByNombreTipoRecurso(id_responsable_tecnico, id_personal_cientifico, id_centro_investigacion);
        }


        internal static DataTable buscarParaMostrarPorResponsable(int id_responsable_tecnico, int id_personal_cientifico, int id_centro_investigacion)
        {
            return DBRecursoTecnologico.findByIdResponsableTecnicoAndIdPersonalCientificoAndIdCentroInvestigacionToShow(id_responsable_tecnico, id_personal_cientifico, id_centro_investigacion);
        }


        internal void actualizarEstadoMantenimientoCorrectivo()
        {
            //Ambito recurso_tecnologico = Ambito.buscarAmbitoRecursoTecnologico();
            //Estado estadoMantenimiento = Estado.buscarEstadoRecursoTecnologicoMantenimiento(recurso_tecnologico);
            //HistorialRecursoTecnologico nuevo = new HistorialRecursoTecnologico(this, estadoMantenimiento, DateTime.Now);
        }
    }
}
