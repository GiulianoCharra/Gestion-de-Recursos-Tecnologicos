﻿using System;
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
    public partial class VentanaPrueba : Form
    {
        public VentanaPrueba()
        {
            InitializeComponent();
        }
                        
        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                this.MenuVertical.Width = 60;
            }
            else
            {
                this.MenuVertical.Width = 250;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
