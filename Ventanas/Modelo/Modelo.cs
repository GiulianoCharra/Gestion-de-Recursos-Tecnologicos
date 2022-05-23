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
    public partial class Modelo : Form
    {
        public Modelo()
        {
            InitializeComponent();
        }

        private void Modelo_Load(object sender, EventArgs e)
        {
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (tx_nombre.Text.Trim() == "")
            {
                return;
            }
            string nombre = tx_nombre.Text;
            string descripcion = tx_descripcion.Text;

            string nuevo = "INSERT INTO [dbo].[MODELOS] (nombre,descripcion) VALUES " + "('" + nombre + "','" + descripcion + "')";
            Conexion.EjecutarComando(nuevo);
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
            foreach (TextBox item in this.Controls)
            {
                item.Text = "";
            }
        }
    }
}
