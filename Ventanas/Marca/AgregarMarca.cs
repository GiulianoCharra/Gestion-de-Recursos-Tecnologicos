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
            btn_agregar_modificar.Text = "Modificar";

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

            string nuevo = "INSERT INTO [dbo].[MARCAS] ([nombre] ,[descripcion]) VALUES (@NOMBRE, @DESCRIPCION )";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);

            Conexion.EjecutarComando(cmd, nuevo);
            limpiar();
            cargarTabla();
        }

        private void modificarMarca()
        {
            if (txt_nombre.Text.TrimStart().Length == 0)
            {
                return;
            }

            int id_marca = int.Parse(dgv_Marcas.SelectedCells[0].Value.ToString());
            string nombre = txt_nombre.Text;
            string descripcion = txt_descripcion.Text;

            string update = "UPDATE [dbo].[MARCAS] SET [nombre] = @NOMBRE ,[descripcion] = @DESCRIPCION WHERE [id_marca] = @ID";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id_marca);
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);


            ejecutarComando(cmd, update);
            limpiar();
            cargarTabla();
            estado = Estados.AGREGAR;
            btn_agregar_modificar.Text = "Agregar"; 
        }

        private void eliminarMarca()
        {
            string eliminar = "DELETE FROM [dbo].[MODELOS] WHERE id = @ID";
            ejecutarComando(eliminar);
            
        }

        private void ejecutarComando(string query)
        {
            Conexion.EjecutarComando(query);
        }

        private void ejecutarComando(SqlCommand com , string query)
        {
            Conexion.EjecutarComando(cmd, query);
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
