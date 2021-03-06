using Gestión_de_Recursos_Tecnológicos.src.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Recursos_Tecnológicos.Ventanas.Marca
{
    public partial class AgregarMarca : Form
    {
        private enum Estados
        {
            AGREGAR,
            MODIFICAR,
            BORRAR
        }
        private Estados estado = Estados.AGREGAR;

        public AgregarMarca()
        {
            InitializeComponent();
        }
        internal void opcionABMMarca()
        {
            habilitar();
        }
        public void habilitar()
        {
            this.Show();
        }

        private void AgregarMarca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestión_de_Recursos_TecnológicosDataSet.MARCAS' Puede moverla o quitarla según sea necesario.
            cargarTabla();
        }

        private void agregarModificarMarca(object sender, EventArgs e)
        {
            if (estado == Estados.AGREGAR)
            {
                agregarMarca();
            }
            else
                modificarMarca();

        }

        private void cancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Marcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            estado = Estados.MODIFICAR;
            cambiarTextoBoton();

            txt_nombre.Text = dgv_Marcas.SelectedCells[1].Value.ToString();
            txt_descripcion.Text = dgv_Marcas.SelectedCells[2].Value.ToString();
        }

        private void btn_agregar_modelo_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarMarca()
        {
            if (txt_nombre.Text.TrimStart().Length == 0)
            {
                return;
            }
            string nombre = txt_nombre.Text;
            string descripcion = txt_descripcion.Text;

            GestorRegistrarMarca.registrarMarca(nombre, descripcion);

            limpiar();
            cargarTabla();
        }

        private void modificarMarca()
        {
            if (txt_nombre.Text.TrimStart().Length == 0)
            {
                Console.WriteLine("Falta ingresar nombre");
                return;
            }

            int id_marca = int.Parse(dgv_Marcas.SelectedCells[0].Value.ToString());
            string nombre = txt_nombre.Text;
            string descripcion = txt_descripcion.Text;

            GestorActualizarMarca.actualizarMarca(id_marca, nombre, descripcion);

            limpiar();
            cargarTabla();
            estado = Estados.AGREGAR;
            cambiarTextoBoton(); 
        }

        private void eliminarMarca()
        {
            string eliminar = "DELETE FROM [dbo].[MODELOS] WHERE id = @ID";
            Conexion.EjecutarComando(eliminar);
            
        }

        private void cambiarTextoBoton()
        {
            string text = string.Empty;

            if (estado == Estados.AGREGAR)
            {
                text = "Agregar";
            }
            if (estado == Estados.MODIFICAR)
            {
                text = "Modificar";
            }
            if (estado == Estados.BORRAR)
            {
                text = "Borrar";
            }

            btn_agregar_modificar.Text = text;
        }

        private void limpiar()
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
        }

        private void cargarTabla()
        {
            this.mARCASTableAdapter.Fill(this.gestión_de_Recursos_TecnológicosDataSet.MARCAS);
        }

    }
}
