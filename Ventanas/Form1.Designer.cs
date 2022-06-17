namespace Gestión_de_Recursos_Tecnológicos
{
    partial class frm_recursoTecnologico
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.redondeadoTextBox4 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            this.redondeadoTextBox3 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            this.redondeadoTextBox2 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            this.redondeadoTextBox1 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 35);
            this.panel1.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.IconSize = 30;
            this.btn_close.Location = new System.Drawing.Point(898, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 9;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 406);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLogo.Controls.Add(this.label2);
            this.PanelLogo.Controls.Add(this.pictureBox3);
            this.PanelLogo.Controls.Add(this.label3);
            this.PanelLogo.Location = new System.Drawing.Point(364, 41);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(243, 234);
            this.PanelLogo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "HiperMegaRed";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gestión_de_Recursos_Tecnológicos.Properties.Resources.Logo_homero_solo_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(53, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "CompuMundo";
            // 
            // redondeadoTextBox4
            // 
            this.redondeadoTextBox4.BackColor = System.Drawing.Color.White;
            this.redondeadoTextBox4.BorderColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox4.BorderFocusColor = System.Drawing.Color.Gray;
            this.redondeadoTextBox4.BorderRadio = 0;
            this.redondeadoTextBox4.BorderSize = 2;
            this.redondeadoTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox4.Location = new System.Drawing.Point(555, 314);
            this.redondeadoTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox4.Multiline = false;
            this.redondeadoTextBox4.Name = "redondeadoTextBox4";
            this.redondeadoTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox4.Size = new System.Drawing.Size(250, 31);
            this.redondeadoTextBox4.TabIndex = 16;
            this.redondeadoTextBox4.Texts = "";
            this.redondeadoTextBox4.UnderlinedStyle = false;
            // 
            // redondeadoTextBox3
            // 
            this.redondeadoTextBox3.BackColor = System.Drawing.Color.White;
            this.redondeadoTextBox3.BorderColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox3.BorderFocusColor = System.Drawing.Color.Gray;
            this.redondeadoTextBox3.BorderRadio = 0;
            this.redondeadoTextBox3.BorderSize = 2;
            this.redondeadoTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox3.Location = new System.Drawing.Point(162, 314);
            this.redondeadoTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox3.Multiline = false;
            this.redondeadoTextBox3.Name = "redondeadoTextBox3";
            this.redondeadoTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox3.Size = new System.Drawing.Size(250, 31);
            this.redondeadoTextBox3.TabIndex = 15;
            this.redondeadoTextBox3.Texts = "";
            this.redondeadoTextBox3.UnderlinedStyle = false;
            // 
            // redondeadoTextBox2
            // 
            this.redondeadoTextBox2.BackColor = System.Drawing.Color.White;
            this.redondeadoTextBox2.BorderColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox2.BorderFocusColor = System.Drawing.Color.Gray;
            this.redondeadoTextBox2.BorderRadio = 15;
            this.redondeadoTextBox2.BorderSize = 2;
            this.redondeadoTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox2.Location = new System.Drawing.Point(555, 368);
            this.redondeadoTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox2.Multiline = false;
            this.redondeadoTextBox2.Name = "redondeadoTextBox2";
            this.redondeadoTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox2.Size = new System.Drawing.Size(250, 31);
            this.redondeadoTextBox2.TabIndex = 14;
            this.redondeadoTextBox2.Texts = "";
            this.redondeadoTextBox2.UnderlinedStyle = false;
            // 
            // redondeadoTextBox1
            // 
            this.redondeadoTextBox1.BackColor = System.Drawing.Color.White;
            this.redondeadoTextBox1.BorderColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox1.BorderFocusColor = System.Drawing.Color.Gray;
            this.redondeadoTextBox1.BorderRadio = 15;
            this.redondeadoTextBox1.BorderSize = 2;
            this.redondeadoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox1.Location = new System.Drawing.Point(162, 368);
            this.redondeadoTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox1.Multiline = false;
            this.redondeadoTextBox1.Name = "redondeadoTextBox1";
            this.redondeadoTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox1.Size = new System.Drawing.Size(250, 31);
            this.redondeadoTextBox1.TabIndex = 13;
            this.redondeadoTextBox1.Texts = "";
            this.redondeadoTextBox1.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Iniciar Sesion";
            // 
            // frm_recursoTecnologico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(928, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelLogo);
            this.Controls.Add(this.redondeadoTextBox4);
            this.Controls.Add(this.redondeadoTextBox3);
            this.Controls.Add(this.redondeadoTextBox2);
            this.Controls.Add(this.redondeadoTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_recursoTecnologico";
            this.Text = "Actividad1_RT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.ComboBox comboBox1;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox1;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox2;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox3;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox4;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

