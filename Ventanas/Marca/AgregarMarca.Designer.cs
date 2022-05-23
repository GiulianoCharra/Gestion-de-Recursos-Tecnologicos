namespace Gestión_de_Recursos_Tecnológicos.Ventanas.Marca
{
    partial class AgregarMarca
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Marcas = new System.Windows.Forms.DataGridView();
            this.btn_agregar_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gestión_de_Recursos_TecnológicosDataSet = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSet();
            this.mARCASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARCASTableAdapter = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSetTableAdapters.MARCASTableAdapter();
            this.idmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_agregar_modelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.txt_nombre.Location = new System.Drawing.Point(80, 6);
            this.txt_nombre.Name = "textBox1";
            this.txt_nombre.Size = new System.Drawing.Size(156, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // textBox2
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(80, 42);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "textBox2";
            this.txt_descripcion.Size = new System.Drawing.Size(156, 43);
            this.txt_descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // dgv_Marcas
            // 
            this.dgv_Marcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Marcas.AutoGenerateColumns = false;
            this.dgv_Marcas.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmarcaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewImageColumn});
            this.dgv_Marcas.DataSource = this.mARCASBindingSource;
            this.dgv_Marcas.Location = new System.Drawing.Point(275, 5);
            this.dgv_Marcas.Name = "dgv_Marcas";
            this.dgv_Marcas.Size = new System.Drawing.Size(384, 250);
            this.dgv_Marcas.TabIndex = 4;
            this.dgv_Marcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Marcas_CellContentClick);
            // 
            // btn_agregar_modificar
            // 
            this.btn_agregar_modificar.Location = new System.Drawing.Point(80, 112);
            this.btn_agregar_modificar.Name = "btn_agregar_modificar";
            this.btn_agregar_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_modificar.TabIndex = 5;
            this.btn_agregar_modificar.Text = "Agregar";
            this.btn_agregar_modificar.UseVisualStyleBackColor = true;
            this.btn_agregar_modificar.Click += new System.EventHandler(this.agregarModificarMarca);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(161, 112);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.cancelar);
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
            // idmarcaDataGridViewTextBoxColumn
            // 
            this.idmarcaDataGridViewTextBoxColumn.DataPropertyName = "id_marca";
            this.idmarcaDataGridViewTextBoxColumn.HeaderText = "id_marca";
            this.idmarcaDataGridViewTextBoxColumn.Name = "idmarcaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewImageColumn
            // 
            this.descripcionDataGridViewImageColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewImageColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewImageColumn.Name = "descripcionDataGridViewImageColumn";
            // 
            // btn_agregar_modelo
            // 
            this.btn_agregar_modelo.Location = new System.Drawing.Point(80, 209);
            this.btn_agregar_modelo.Name = "btn_agregar_modelo";
            this.btn_agregar_modelo.Size = new System.Drawing.Size(90, 23);
            this.btn_agregar_modelo.TabIndex = 7;
            this.btn_agregar_modelo.Text = "Agregar Modelo";
            this.btn_agregar_modelo.UseVisualStyleBackColor = true;
            this.btn_agregar_modelo.Click += new System.EventHandler(this.btn_agregar_modelo_Click);
            // 
            // AgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 261);
            this.Controls.Add(this.btn_agregar_modelo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar_modificar);
            this.Controls.Add(this.dgv_Marcas);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarMarca";
            this.Text = "AgregarMarca";
            this.Load += new System.EventHandler(this.AgregarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Marcas;
        private System.Windows.Forms.Button btn_agregar_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private Gestión_de_Recursos_TecnológicosDataSet gestión_de_Recursos_TecnológicosDataSet;
        private System.Windows.Forms.BindingSource mARCASBindingSource;
        private Gestión_de_Recursos_TecnológicosDataSetTableAdapters.MARCASTableAdapter mARCASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn descripcionDataGridViewImageColumn;
        private System.Windows.Forms.Button btn_agregar_modelo;
    }
}