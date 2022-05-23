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
            MODIFICAR
        }

        private Estados estado = Estados.AGREGAR;
        private SqlCommand cmd = new SqlCommand();

        public AgregarMarca()
        {
            InitializeComponent();
        }

        private void AgregarMarca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestión_de_Recursos_TecnológicosDataSet.MARCAS' Puede moverla o quitarla según sea necesario.
            this.mARCASTableAdapter.Fill(this.gestión_de_Recursos_TecnológicosDataSet.MARCAS);
        }

        private void agregarModificarMarca(object sender, EventArgs e)
        {
            if (estado == Estados.AGREGAR)
            {
                agregarMarca();
            }
        }

        private void cancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Marcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            estado = Estados.MODIFICAR;

            txt_nombre.Text = dgv_Marcas.SelectedCells[1].Value.ToString();
            txt_descripcion.Text = dgv_Marcas.SelectedCells[2].Value.ToString();
        }

        private void btn_agregar_modelo_Click(object sender, EventArgs e)
        {

        }

        private void agregarMarca()
        {
            string nombre = txt_nombre.Text;
            string descripcion = txt_descripcion.Text;

            string nuevo = "INSERT INTO [dbo].[MARCAS] ([nombre] ,[descripcion]) VALUES ('@nombre', @descripcion )";

            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);

            Conexion.EjecutarComando(nuevo, cmd);
        }

        private void modificarMarca()
        {
            int id = int.Parse(dgv_Marcas.SelectedCells[0].Value.ToString());
            string nombre = txt_nombre.Text;
            string descripcion = txt_descripcion.Text;

            string update = "UPDATE [dbo].[MARCAS] SET [nombre] = @NOMBRE ,[descripcion] = @DESCRIPCION WHERE id = @ID";
            
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);


            Conexion.EjecutarComando(update, cmd);
        }

        private void eliminarMarca()
        {
            string eliminar = "DELETE FROM [dbo].[MODELOS] WHERE id = @ID";
            
        }

        private void ejecutarComando(string query)
        {
            Conexion.EjecutarComando(query);
        }
    }
}
