using Gestión_de_Recursos_Tecnológicos.Ventanas;
using Gestión_de_Recursos_Tecnológicos.Ventanas.Marca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Recursos_Tecnológicos
{
    internal static class Principal
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AgregarMarca());
        }
    }
}
