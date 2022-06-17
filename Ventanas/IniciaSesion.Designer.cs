namespace Gestión_de_Recursos_Tecnológicos.Ventanas
{
    partial class frmIniciaSesion
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
            this.lbl_datos_incorrectos = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_recuperar_contraseña = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btn_minimizar = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.redondeadoTextBox2 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            this.redondeadoTextBox1 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            this.panelBarra.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_datos_incorrectos
            // 
            this.lbl_datos_incorrectos.AutoSize = true;
            this.lbl_datos_incorrectos.ForeColor = System.Drawing.Color.White;
            this.lbl_datos_incorrectos.Location = new System.Drawing.Point(57, 301);
            this.lbl_datos_incorrectos.Name = "lbl_datos_incorrectos";
            this.lbl_datos_incorrectos.Size = new System.Drawing.Size(0, 13);
            this.lbl_datos_incorrectos.TabIndex = 17;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(158)))));
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Location = new System.Drawing.Point(176, 445);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(158)))));
            this.btn_iniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_iniciar.Location = new System.Drawing.Point(80, 445);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 14;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // lbl_recuperar_contraseña
            // 
            this.lbl_recuperar_contraseña.AutoSize = true;
            this.lbl_recuperar_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recuperar_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(158)))));
            this.lbl_recuperar_contraseña.Location = new System.Drawing.Point(138, 416);
            this.lbl_recuperar_contraseña.Name = "lbl_recuperar_contraseña";
            this.lbl_recuperar_contraseña.Size = new System.Drawing.Size(110, 13);
            this.lbl_recuperar_contraseña.TabIndex = 11;
            this.lbl_recuperar_contraseña.Text = "Recuperar contraseña";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(158)))));
            this.lbl_contraseña.Location = new System.Drawing.Point(57, 360);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(70, 15);
            this.lbl_contraseña.TabIndex = 10;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(158)))));
            this.lbl_usuario.Location = new System.Drawing.Point(57, 299);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(50, 15);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "Usuario";
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.btn_minimizar);
            this.panelBarra.Controls.Add(this.btn_close);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(329, 35);
            this.panelBarra.TabIndex = 19;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            this.panelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseMove);
            this.panelBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseUp);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_minimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimizar.IconSize = 30;
            this.btn_minimizar.Location = new System.Drawing.Point(263, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar.TabIndex = 24;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.IconSize = 30;
            this.btn_close.Location = new System.Drawing.Point(299, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 13;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLogo.Controls.Add(this.label2);
            this.PanelLogo.Controls.Add(this.pictureBox3);
            this.PanelLogo.Controls.Add(this.label3);
            this.PanelLogo.Location = new System.Drawing.Point(43, 41);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(243, 234);
            this.PanelLogo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(158)))));
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
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(31, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "CompuMundo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "mensaje";
            // 
            // redondeadoTextBox2
            // 
            this.redondeadoTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.redondeadoTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(158)))));
            this.redondeadoTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(196)))));
            this.redondeadoTextBox2.BorderRadio = 0;
            this.redondeadoTextBox2.BorderSize = 2;
            this.redondeadoTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox2.Location = new System.Drawing.Point(60, 379);
            this.redondeadoTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox2.Multiline = false;
            this.redondeadoTextBox2.Name = "redondeadoTextBox2";
            this.redondeadoTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox2.Size = new System.Drawing.Size(206, 31);
            this.redondeadoTextBox2.TabIndex = 21;
            this.redondeadoTextBox2.Texts = "";
            this.redondeadoTextBox2.UnderlinedStyle = true;
            // 
            // redondeadoTextBox1
            // 
            this.redondeadoTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.redondeadoTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(158)))));
            this.redondeadoTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(196)))));
            this.redondeadoTextBox1.BorderRadio = 0;
            this.redondeadoTextBox1.BorderSize = 2;
            this.redondeadoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox1.Location = new System.Drawing.Point(60, 318);
            this.redondeadoTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox1.Multiline = false;
            this.redondeadoTextBox1.Name = "redondeadoTextBox1";
            this.redondeadoTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox1.Size = new System.Drawing.Size(206, 31);
            this.redondeadoTextBox1.TabIndex = 20;
            this.redondeadoTextBox1.Texts = "";
            this.redondeadoTextBox1.UnderlinedStyle = true;
            // 
            // frmIniciaSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(329, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelLogo);
            this.Controls.Add(this.redondeadoTextBox2);
            this.Controls.Add(this.redondeadoTextBox1);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.lbl_datos_incorrectos);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.lbl_recuperar_contraseña);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIniciaSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciaSesion";
            this.panelBarra.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_datos_incorrectos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label lbl_recuperar_contraseña;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Panel panelBarra;
        private FontAwesome.Sharp.IconButton btn_close;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox1;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox2;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_minimizar;
    }
}