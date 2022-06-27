using Gestión_de_Recursos_Tecnológicos.src.clases;
using Gestión_de_Recursos_Tecnológicos.src.Ventanas.Mantenimiento;
using Gestión_de_Recursos_Tecnológicos.Ventanas.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Gestores
{
    internal class GestorIngresoRecursoTecnologicoMantenimientoCorrectivo
    {
        private static ResponsableTecnico responsable { get; set; }
        private static List<RecursoTecnologico> recursosAsignados { get; set; }
        private static List<RecursoTecnologico> recursosAsignadosDisponibles { get; set; }
        private static List<ViewRecursoTecnologico> resultados { get; set; }

        public GestorIngresoRecursoTecnologicoMantenimientoCorrectivo()
        {

        }

        internal static List<ViewRecursoTecnologico> buscarRecursosAsociadosDisponibles()
        {
            Sesion sesionActual = Sesion.sesionActual();
            Usuario userActual = sesionActual.usuario;
            if (!userActual.esUsuarioResponsableTecnico())
            {
                return null;
            }

            responsable = ResponsableTecnico.buscarPorUsuario(userActual.user);
            int id_responsable_tecnico = responsable.id_responsable_tecnico;
            int id_personal_cientifico = responsable.personal_cientifico.legajo;
            int id_centro_investigacion = responsable.id_centro_investigacion;

            
            recursosAsignados = RecursoTecnologico.buscarPorResponsable(id_responsable_tecnico, id_personal_cientifico, id_centro_investigacion);
            recursosAsignadosDisponibles = new List<RecursoTecnologico>();
            resultados = new List<ViewRecursoTecnologico>();

            foreach (RecursoTecnologico rt in recursosAsignados)
            {
                if (rt.esDisponible())
                {
                    recursosAsignadosDisponibles.Add(rt);
                    resultados.Add(new ViewRecursoTecnologico(rt.tipo_recurso_tecnologico.nombre, rt.id_recurso_tecnologico, rt.marca.nombre, rt.modelo.nombre));
                }
            }


            //DataTable dt = RecursoTecnologico.buscarParaMostrarPorResponsable(id_responsable_tecnico, id_personal_cientifico, id_centro_investigacion);
            return resultados;
        }

        private void buildRecursosParaMostrar()
        {
            List<ViewRecursoTecnologico> toShow = new List<ViewRecursoTecnologico>();
            //IngresoMantenimiento.mostrarResultados(toShow);
        }

        internal static void registrarIngresoMantenimientoCorrectivo()
        {
            throw new NotImplementedException();
        }
    }
}
