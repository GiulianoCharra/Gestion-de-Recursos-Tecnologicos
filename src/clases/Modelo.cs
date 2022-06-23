using Gestión_de_Recursos_Tecnológicos.src.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.clases
{
    internal class Modelo
    {
        private int id_modelo { get; set; }
        private Marca marca { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }

        public Modelo(int id_modelo, Marca marca, string nombre, string descripcion)
        {
            this.id_modelo = id_modelo;
            this.marca = marca;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public Modelo(int id_modelo, int id_marca, string nombre, string descripcion)
        {
            this.id_modelo = id_modelo;
            this.marca = Marca.findById(id_marca);
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        internal static List<Modelo> findByIdMarca(int id_marca)
        {
            return DBModelo.findByIdMarca(id_marca);
        }

        internal static Modelo findById(int id_modelo, int id_marca)
        {
            return DBModelo.findById(id_modelo, id_marca);
        }
    }
}
