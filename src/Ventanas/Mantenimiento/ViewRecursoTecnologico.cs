using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.Ventanas.Mantenimiento
{
    internal class ViewRecursoTecnologico
    {
        [DisplayName("Tipo")]
        public string tipo { get; set; }
        [DisplayName("Numero")]
        public int numero { get; set; }
        [DisplayName("Marca")]
        public string marca { get; set; }
        [DisplayName("Modelo")]
        public string modelo { get; set; }

        public ViewRecursoTecnologico(string tipo, int numero, string marca, string modelo)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.marca = marca;
            this.modelo = modelo;
        }
    }
}

