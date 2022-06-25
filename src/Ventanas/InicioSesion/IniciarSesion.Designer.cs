namespace Gestión_de_Recursos_Tecnológicos.Ventanas.Sesion
{
    partial class IniciarSesion
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_datos_incorrectos = new System.Windows.Forms.Label();
            this.llbl_recuperar_contraseña = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(22, 70);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(50, 15);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(22, 104);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(70, 15);
            this.lbl_contraseña.TabIndex = 1;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(112, 66);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 3;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(112, 100);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña.TabIndex = 4;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(51, 161);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 5;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(147, 161);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(45, 5);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(177, 31);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Iniciar Sesion";
            // 
            // lbl_datos_incorrectos
            // 
            this.lbl_datos_incorrectos.AutoSize = true;
            this.lbl_datos_incorrectos.ForeColor = System.Drawing.Color.Red;
            this.lbl_datos_incorrectos.Location = new System.Drawing.Point(22, 45);
            this.lbl_datos_incorrectos.Name = "lbl_datos_incorrectos";
            this.lbl_datos_incorrectos.Size = new System.Drawing.Size(0, 13);
            this.lbl_datos_incorrectos.TabIndex = 8;
            // 
            // llbl_recuperar_contraseña
            // 
            this.llbl_recuperar_contraseña.AutoSize = true;
            this.llbl_recuperar_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_recuperar_contraseña.Location = new System.Drawing.Point(109, 128);
            this.llbl_recuperar_contraseña.Name = "llbl_recuperar_contraseña";
            this.llbl_recuperar_contraseña.Size = new System.Drawing.Size(112, 13);
            this.llbl_recuperar_contraseña.TabIndex = 9;
            this.llbl_recuperar_contraseña.TabStop = true;
            this.llbl_recuperar_contraseña.Text = "Recuperar Contraseña";
            this.llbl_recuperar_contraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_recuperar_contraseña_LinkClicked);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 196);
            this.ControlBox = false;
            this.Controls.Add(this.llbl_recuperar_contraseña);
            this.Controls.Add(this.lbl_datos_incorrectos);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IniciarSesion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_datos_incorrectos;
        private System.Windows.Forms.LinkLabel llbl_recuperar_contraseña;
    }
}