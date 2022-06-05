namespace Gestión_de_Recursos_Tecnológicos.Ventanas
{
    partial class AgregarModelo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.tx_descripcion = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_modelos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_marcas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gestión_de_Recursos_TecnológicosDataSet = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSet();
            this.mARCASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARCASTableAdapter = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSetTableAdapters.MARCASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(112, 33);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(260, 20);
            this.tx_nombre.TabIndex = 1;
            this.tx_nombre.Enter += new System.EventHandler(this.tx_nombre_Enter);
            this.tx_nombre.Leave += new System.EventHandler(this.tx_nombre_Leave);
            // 
            // tx_descripcion
            // 
            this.tx_descripcion.Location = new System.Drawing.Point(112, 67);
            this.tx_descripcion.Multiline = true;
            this.tx_descripcion.Name = "tx_descripcion";
            this.tx_descripcion.Size = new System.Drawing.Size(260, 46);
            this.tx_descripcion.TabIndex = 2;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(216, 211);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_modelos
            // 
            this.dgv_modelos.AllowUserToAddRows = false;
            this.dgv_modelos.AllowUserToDeleteRows = false;
            this.dgv_modelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modelos.Location = new System.Drawing.Point(419, 33);
            this.dgv_modelos.Name = "dgv_modelos";
            this.dgv_modelos.ReadOnly = true;
            this.dgv_modelos.Size = new System.Drawing.Size(540, 201);
            this.dgv_modelos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca";
            // 
            // cmb_marcas
            // 
            this.cmb_marcas.DataSource = this.mARCASBindingSource;
            this.cmb_marcas.DisplayMember = "nombre";
            this.cmb_marcas.FormattingEnabled = true;
            this.cmb_marcas.Location = new System.Drawing.Point(112, 127);
            this.cmb_marcas.Name = "cmb_marcas";
            this.cmb_marcas.Size = new System.Drawing.Size(260, 21);
            this.cmb_marcas.TabIndex = 8;
            this.cmb_marcas.ValueMember = "id_marca";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gestión_de_Recursos_TecnológicosDataSet
            // 
            this.gestión_de_Recursos_TecnológicosDataSet.DataSetName = "Gestión_de_Recursos_TecnológicosDataSet";
            this.gestión_de_Recursos_TecnológicosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mARCASBindingSource
            // 
            this.mARCASBindingSource.DataMember = "MARCAS";
            this.mARCASBindingSource.DataSource = this.gestión_de_Recursos_TecnológicosDataSet;
            // 
            // mARCASTableAdapter
            // 
            this.mARCASTableAdapter.ClearBeforeFill = true;
            // 
            // AgregarModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_marcas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_modelos);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_nombre);
            this.Name = "AgregarModelo";
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.Modelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_descripcion;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_modelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_marcas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Gestión_de_Recursos_TecnológicosDataSet gestión_de_Recursos_TecnológicosDataSet;
        private System.Windows.Forms.BindingSource mARCASBindingSource;
        private Gestión_de_Recursos_TecnológicosDataSetTableAdapters.MARCASTableAdapter mARCASTableAdapter;
    }
}