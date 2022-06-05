namespace Gestión_de_Recursos_Tecnológicos.src.ventanas
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_cargar_modelo = new System.Windows.Forms.Button();
            this.btn_cargar_marca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pan_principal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 655);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btn_cargar_modelo);
            this.groupBox1.Controls.Add(this.btn_cargar_marca);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(3, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(3, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_cargar_modelo
            // 
            this.btn_cargar_modelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cargar_modelo.Location = new System.Drawing.Point(3, 39);
            this.btn_cargar_modelo.Name = "btn_cargar_modelo";
            this.btn_cargar_modelo.Size = new System.Drawing.Size(194, 23);
            this.btn_cargar_modelo.TabIndex = 1;
            this.btn_cargar_modelo.Text = "Cargar Modelo";
            this.btn_cargar_modelo.UseVisualStyleBackColor = true;
            this.btn_cargar_modelo.Click += new System.EventHandler(this.btn_cargar_modelo_Click);
            // 
            // btn_cargar_marca
            // 
            this.btn_cargar_marca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cargar_marca.Location = new System.Drawing.Point(3, 16);
            this.btn_cargar_marca.Name = "btn_cargar_marca";
            this.btn_cargar_marca.Size = new System.Drawing.Size(194, 23);
            this.btn_cargar_marca.TabIndex = 0;
            this.btn_cargar_marca.Text = "Cargar Marca";
            this.btn_cargar_marca.UseVisualStyleBackColor = true;
            this.btn_cargar_marca.Click += new System.EventHandler(this.btn_cargar_marca_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pan_principal
            // 
            this.pan_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_principal.Location = new System.Drawing.Point(200, 0);
            this.pan_principal.Name = "pan_principal";
            this.pan_principal.Size = new System.Drawing.Size(966, 655);
            this.pan_principal.TabIndex = 1;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 655);
            this.Controls.Add(this.pan_principal);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaPrincipal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_cargar_modelo;
        private System.Windows.Forms.Button btn_cargar_marca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pan_principal;
    }
}