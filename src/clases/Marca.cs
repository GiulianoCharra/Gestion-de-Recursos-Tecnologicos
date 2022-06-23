using Gestión_de_Recursos_Tecnológicos.src.persistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Marca
    {
        private int id_marca { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private List<Modelo> modelos { get; set; }

        public Marca(int id_marca, string nombre, string descripcion, List<Modelo> modelos)
        {
            this.id_marca = id_marca;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.modelos = modelos;
        }
        public Marca(int id_marca, string nombre, string descripcion)
        {
            this.id_marca = id_marca;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.modelos = Modelo.findByIdMarca(id_marca);
        }

        public ArrayList findAll()
        {
            return DBMarca.findAll();
        }

        internal static Marca findById(int id_marca)
        {
            return DBMarca.findById(id_marca);
        }
    }

}
