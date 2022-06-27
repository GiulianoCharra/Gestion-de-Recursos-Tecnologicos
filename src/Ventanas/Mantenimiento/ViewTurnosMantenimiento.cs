using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Ventanas.Mantenimiento
{
    internal class ViewTurnosMantenimiento
    {
        [DisplayName("Cientifico")]
        public string nombreCompleto { get; set; }
        [DisplayName("Fecha")]
        public TimeSpan fecha { get; set; }
        [DisplayName("Hora")]
        public TimeSpan numero { get; set; }

        public ViewTurnosMantenimiento(string nombreCompleto, TimeSpan fecha, TimeSpan numero)
        {
            this.nombreCompleto = nombreCompleto;
            this.fecha = fecha;
            this.numero = numero;
        }
    }
}
