using Gestión_de_Recursos_Tecnológicos.src.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class TipoMantenimiento
    {
        public int id_tipo_mantenimiento { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public TipoMantenimiento(int id_tipo_mantenimiento, string nombre, string descripcion)
        {
            this.id_tipo_mantenimiento = id_tipo_mantenimiento;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        internal static List<TipoMantenimiento> buscarAll()
        {
            return DBTipoMantenimiento.findAll();
        }

        internal bool esTipoMantenimientoCorrectivo()
        {
            return nombre.Equals("Correctivo");
        }
        internal bool esTipoMantenimientoPreventivo()
        {
            return nombre.Equals("Preventivo");
        }

        internal static TipoMantenimiento buscarPorId(int id_tipo_mantenimiento)
        {
            return DBTipoMantenimiento.findById(id_tipo_mantenimiento);
        }
    }
}
