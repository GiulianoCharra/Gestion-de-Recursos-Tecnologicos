using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Recursos_Tecnológicos.Ventanas
{
    public partial class AgregarModelo : Form
    {
        public AgregarModelo()
        {
            InitializeComponent();
        }

        private void Modelo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestión_de_Recursos_TecnológicosDataSet.MARCAS' Puede moverla o quitarla según sea necesario.
            this.mARCASTableAdapter.Fill(this.gestión_de_Recursos_TecnológicosDataSet.MARCAS);
            cargarTabla();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (tx_nombre.Text.Trim() == "")
            {
                return;
            }
            int id_marca = (int)cmb_marcas.SelectedValue;
            string nombre = tx_nombre.Text;
            string descripcion = tx_descripcion.Text;

            string nuevo = "INSERT INTO [dbo].[MODELOS] ([id_marca], [nombre], [descripcion]) VALUES (@ID_MARCA,@NOMRE,@DESCRIPCION)";

            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"@ID_MARCA", id_marca},
                {"@NOMRE", nombre},
                {"@DESCRIPCION", descripcion}
            };

            Conexion.EjecutarComando(parametros, nuevo);
            limpiar();
            cargarTabla();
        }

        private void tx_nombre_Enter(object sender, EventArgs e)
        {
            if (tx_nombre.Text == "Ingrese nombre...")
            {
                tx_nombre.ForeColor = Color.Black;
                tx_nombre.Text = "";
            }
        }

        private void tx_nombre_Leave(object sender, EventArgs e)
        {
            if (tx_nombre.Text.Length == 0)
            {
                tx_nombre.ForeColor = Color.Red;
                tx_nombre.Text = "Ingrese nombre...";
            }
        }

        private void limpiar()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void cargarTabla()
        {
            string cargarTabla = "SELECT mod.id_modelo, mar.nombre as Marca, mod.nombre, mod.descripcion FROM MODELOS mod JOIN MARCAS mar ON mod.id_marca = mar.id_marca";
            dgv_modelos.DataSource = Conexion.EjecutarComando(cargarTabla);
        }
    }
}
