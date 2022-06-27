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
        public int id_marca { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public List<Modelo> modelos { get; set; }

        public Marca(int id_marca, string nombre, string descripcion, List<Modelo> modelos)
        {
            this.id_marca = id_marca;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.modelos = modelos;
        }


        internal static void registrar(string nombre, string descripcion)
        {
            DBMarca.insert(nombre, descripcion);
        }

        internal static void actualizar(int id_marca, string nombre, string descripcion)
        {
            DBMarca.update(id_marca, nombre, descripcion);
        }

        public Marca(int id_marca, string nombre, string descripcion)
        {
            this.id_marca = id_marca;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.modelos = Modelo.findByIdMarca(id_marca);
        }

        public static List<Marca> buscarTodas()
        {
            return DBMarca.findAll();
        }

        internal static Marca buscarPorId(int id_marca)
        {
            return DBMarca.findById(id_marca);
        }
    }

}
