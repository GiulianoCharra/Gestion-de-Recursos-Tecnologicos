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
        public int id_modelo { get; set; }
        public int id_marca { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }


        public Modelo(int id_modelo, int id_marca, string nombre, string descripcion)
        {
            this.id_modelo = id_modelo;
            this.id_marca = id_marca;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }


        internal static void registrar(int id_marca, string nombre, string descripcion)
        {
            DBModelo.insert(id_marca, nombre, descripcion);
        }
        internal static void actualizar(int id_modelo, int id_marca, string nombre, string descripcion)
        {
            DBModelo.update(id_modelo, id_marca, nombre, descripcion);
        }

        internal static List<Modelo> findByIdMarca(int id_marca)
        {
            return DBModelo.findByIdMarca(id_marca);
        }
        internal static Modelo buscarPorId(int id_modelo, int id_marca)
        {
            return DBModelo.findById(id_modelo, id_marca);
        }
    }
}
