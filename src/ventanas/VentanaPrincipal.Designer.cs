namespace Gestión_de_Recursos_Tecnológicos.Ventanas
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
            this.components = new System.ComponentModel.Container();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btn_maximizar = new FontAwesome.Sharp.IconButton();
            this.btn_minimizar = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panelListIntegrantes = new System.Windows.Forms.Panel();
            this.btn_integrantes = new FontAwesome.Sharp.IconButton();
            this.panelSubActividad1 = new System.Windows.Forms.Panel();
            this.btn_act1_sub3 = new FontAwesome.Sharp.IconButton();
            this.btn_act1_sub2 = new FontAwesome.Sharp.IconButton();
            this.btn_act1_sub1 = new FontAwesome.Sharp.IconButton();
            this.btn_actividad1 = new FontAwesome.Sharp.IconButton();
            this.btn_Inicio = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_menu = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFromInferior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.fechaActual = new System.Windows.Forms.Timer(this.components);
            this.panelBarra.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            this.panelSubActividad1.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFromInferior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelBarra.Controls.Add(this.btn_maximizar);
            this.panelBarra.Controls.Add(this.btn_minimizar);
            this.panelBarra.Controls.Add(this.btn_close);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1184, 33);
            this.panelBarra.TabIndex = 0;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            this.panelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseMove);
            this.panelBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseUp);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_maximizar.IconColor = System.Drawing.Color.White;
            this.btn_maximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_maximizar.IconSize = 30;
            this.btn_maximizar.Location = new System.Drawing.Point(1119, 1);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_maximizar.Size = new System.Drawing.Size(30, 30);
            this.btn_maximizar.TabIndex = 13;
            this.btn_maximizar.UseVisualStyleBackColor = true;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_minimizar.IconColor = System.Drawing.Color.White;
            this.btn_minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimizar.IconSize = 30;
            this.btn_minimizar.Location = new System.Drawing.Point(1083, 1);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar.TabIndex = 11;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.IconSize = 30;
            this.btn_close.Location = new System.Drawing.Point(1155, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 12;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoScroll = true;
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.MenuVertical.Controls.Add(this.panelListIntegrantes);
            this.MenuVertical.Controls.Add(this.btn_integrantes);
            this.MenuVertical.Controls.Add(this.panelSubActividad1);
            this.MenuVertical.Controls.Add(this.btn_actividad1);
            this.MenuVertical.Controls.Add(this.btn_Inicio);
            this.MenuVertical.Controls.Add(this.PanelLogo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 33);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 528);
            this.MenuVertical.TabIndex = 1;
            // 
            // panelListIntegrantes
            // 
            this.panelListIntegrantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.panelListIntegrantes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListIntegrantes.Location = new System.Drawing.Point(0, 493);
            this.panelListIntegrantes.Name = "panelListIntegrantes";
            this.panelListIntegrantes.Size = new System.Drawing.Size(250, 5);
            this.panelListIntegrantes.TabIndex = 3;
            // 
            // btn_integrantes
            // 
            this.btn_integrantes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_integrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_integrantes.ForeColor = System.Drawing.Color.White;
            this.btn_integrantes.IconChar = FontAwesome.Sharp.IconChar.Cat;
            this.btn_integrantes.IconColor = System.Drawing.Color.White;
            this.btn_integrantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_integrantes.IconSize = 30;
            this.btn_integrantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_integrantes.Location = new System.Drawing.Point(0, 498);
            this.btn_integrantes.Name = "btn_integrantes";
            this.btn_integrantes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_integrantes.Size = new System.Drawing.Size(250, 30);
            this.btn_integrantes.TabIndex = 8;
            this.btn_integrantes.Text = "Informacion";
            this.btn_integrantes.UseVisualStyleBackColor = true;
            this.btn_integrantes.Click += new System.EventHandler(this.btn_integrantes_Click);
            // 
            // panelSubActividad1
            // 
            this.panelSubActividad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.panelSubActividad1.Controls.Add(this.btn_act1_sub3);
            this.panelSubActividad1.Controls.Add(this.btn_act1_sub2);
            this.panelSubActividad1.Controls.Add(this.btn_act1_sub1);
            this.panelSubActividad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubActividad1.Location = new System.Drawing.Point(0, 175);
            this.panelSubActividad1.Name = "panelSubActividad1";
            this.panelSubActividad1.Size = new System.Drawing.Size(250, 96);
            this.panelSubActividad1.TabIndex = 3;
            this.panelSubActividad1.Visible = false;
            // 
            // btn_act1_sub3
            // 
            this.btn_act1_sub3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_act1_sub3.FlatAppearance.BorderSize = 0;
            this.btn_act1_sub3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act1_sub3.ForeColor = System.Drawing.Color.Black;
            this.btn_act1_sub3.IconChar = FontAwesome.Sharp.IconChar.Modx;
            this.btn_act1_sub3.IconColor = System.Drawing.Color.Black;
            this.btn_act1_sub3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_act1_sub3.IconSize = 30;
            this.btn_act1_sub3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_act1_sub3.Location = new System.Drawing.Point(0, 60);
            this.btn_act1_sub3.Name = "btn_act1_sub3";
            this.btn_act1_sub3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_act1_sub3.Size = new System.Drawing.Size(250, 30);
            this.btn_act1_sub3.TabIndex = 5;
            this.btn_act1_sub3.Text = "Modelo";
            this.btn_act1_sub3.UseVisualStyleBackColor = true;
            this.btn_act1_sub3.Click += new System.EventHandler(this.btn_act1_sub3_Click);
            // 
            // btn_act1_sub2
            // 
            this.btn_act1_sub2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_act1_sub2.FlatAppearance.BorderSize = 0;
            this.btn_act1_sub2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act1_sub2.ForeColor = System.Drawing.Color.Black;
            this.btn_act1_sub2.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.btn_act1_sub2.IconColor = System.Drawing.Color.Black;
            this.btn_act1_sub2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_act1_sub2.IconSize = 30;
            this.btn_act1_sub2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_act1_sub2.Location = new System.Drawing.Point(0, 30);
            this.btn_act1_sub2.Name = "btn_act1_sub2";
            this.btn_act1_sub2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_act1_sub2.Size = new System.Drawing.Size(250, 30);
            this.btn_act1_sub2.TabIndex = 5;
            this.btn_act1_sub2.Text = "Marca";
            this.btn_act1_sub2.UseVisualStyleBackColor = true;
            this.btn_act1_sub2.Click += new System.EventHandler(this.btn_act1_sub2_Click);
            // 
            // btn_act1_sub1
            // 
            this.btn_act1_sub1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_act1_sub1.FlatAppearance.BorderSize = 0;
            this.btn_act1_sub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act1_sub1.ForeColor = System.Drawing.Color.Black;
            this.btn_act1_sub1.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            this.btn_act1_sub1.IconColor = System.Drawing.Color.Black;
            this.btn_act1_sub1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_act1_sub1.IconSize = 30;
            this.btn_act1_sub1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_act1_sub1.Location = new System.Drawing.Point(0, 0);
            this.btn_act1_sub1.Name = "btn_act1_sub1";
            this.btn_act1_sub1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_act1_sub1.Size = new System.Drawing.Size(250, 30);
            this.btn_act1_sub1.TabIndex = 5;
            this.btn_act1_sub1.Text = "Ingresar Mantenimiento \r\nCorrectivo";
            this.btn_act1_sub1.UseVisualStyleBackColor = true;
            this.btn_act1_sub1.Click += new System.EventHandler(this.btn_act1_sub1_Click);
            // 
            // btn_actividad1
            // 
            this.btn_actividad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_actividad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actividad1.ForeColor = System.Drawing.Color.White;
            this.btn_actividad1.IconChar = FontAwesome.Sharp.IconChar.Microscope;
            this.btn_actividad1.IconColor = System.Drawing.Color.White;
            this.btn_actividad1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_actividad1.IconSize = 30;
            this.btn_actividad1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actividad1.Location = new System.Drawing.Point(0, 145);
            this.btn_actividad1.Name = "btn_actividad1";
            this.btn_actividad1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_actividad1.Size = new System.Drawing.Size(250, 30);
            this.btn_actividad1.TabIndex = 5;
            this.btn_actividad1.Text = "Recurso Tecnologico";
            this.btn_actividad1.UseVisualStyleBackColor = true;
            this.btn_actividad1.Click += new System.EventHandler(this.btn_actividad1_Click);
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Inicio.IconColor = System.Drawing.Color.White;
            this.btn_Inicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Inicio.IconSize = 30;
            this.btn_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio.Location = new System.Drawing.Point(0, 115);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Inicio.Size = new System.Drawing.Size(250, 30);
            this.btn_Inicio.TabIndex = 4;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLogo.Controls.Add(this.label2);
            this.PanelLogo.Controls.Add(this.btn_menu);
            this.PanelLogo.Controls.Add(this.pictureBox3);
            this.PanelLogo.Controls.Add(this.label1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(250, 115);
            this.PanelLogo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "HiperMegaRed";
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btn_menu.IconColor = System.Drawing.Color.White;
            this.btn_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menu.IconSize = 30;
            this.btn_menu.Location = new System.Drawing.Point(200, 3);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_menu.Size = new System.Drawing.Size(30, 30);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gestión_de_Recursos_Tecnológicos.Properties.Resources.Logo_homero_solo_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(0, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CompuMundo";
            // 
            // panelCentral
            // 
            this.panelCentral.AutoScroll = true;
            this.panelCentral.BackColor = System.Drawing.Color.Transparent;
            this.panelCentral.Controls.Add(this.pictureBox1);
            this.panelCentral.Controls.Add(this.label4);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(250, 33);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(934, 456);
            this.panelCentral.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Gestión_de_Recursos_Tecnológicos.Properties.Resources.Logo_homero_solo_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(256, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 299);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(214, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "CompuMundo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(460, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "HiperMegaRed";
            // 
            // panelFromInferior
            // 
            this.panelFromInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelFromInferior.Controls.Add(this.panel1);
            this.panelFromInferior.Controls.Add(this.lbl_fecha);
            this.panelFromInferior.Controls.Add(this.lbl_hora);
            this.panelFromInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFromInferior.Location = new System.Drawing.Point(250, 489);
            this.panelFromInferior.Name = "panelFromInferior";
            this.panelFromInferior.Size = new System.Drawing.Size(934, 72);
            this.panelFromInferior.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(612, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 67);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Gestión_de_Recursos_Tecnológicos.Properties.Resources.UTN_LOGO_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 56);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(210, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "FACULTADAD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(210, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "CORDOBA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(210, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "REGIONAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(97, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "INGENERIA EN SISTEMAS DE INFROMACION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(97, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 50);
            this.label10.TabIndex = 6;
            this.label10.Text = "UTN";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Silver;
            this.lbl_fecha.Location = new System.Drawing.Point(16, 39);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 20);
            this.lbl_fecha.TabIndex = 7;
            this.lbl_fecha.Text = "fecha";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_hora.Location = new System.Drawing.Point(14, 5);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(72, 31);
            this.lbl_hora.TabIndex = 6;
            this.lbl_hora.Text = "hora";
            // 
            // fechaActual
            // 
            this.fechaActual.Enabled = true;
            this.fechaActual.Tick += new System.EventHandler(this.fechaActual_Tick);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelFromInferior);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.panelBarra);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrueba_Load);
            this.panelBarra.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            this.panelSubActividad1.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFromInferior.ResumeLayout(false);
            this.panelFromInferior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton btn_Inicio;
        private FontAwesome.Sharp.IconButton btn_actividad1;
        private FontAwesome.Sharp.IconButton btn_menu;
        private FontAwesome.Sharp.IconButton btn_integrantes;
        private System.Windows.Forms.Panel panelSubActividad1;
        private FontAwesome.Sharp.IconButton btn_act1_sub3;
        private FontAwesome.Sharp.IconButton btn_act1_sub2;
        private FontAwesome.Sharp.IconButton btn_act1_sub1;
        private System.Windows.Forms.Panel panelListIntegrantes;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelFromInferior;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btn_maximizar;
        private FontAwesome.Sharp.IconButton btn_minimizar;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer fechaActual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}