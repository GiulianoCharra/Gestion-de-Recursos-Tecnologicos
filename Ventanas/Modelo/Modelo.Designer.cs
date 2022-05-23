namespace Gestión_de_Recursos_Tecnológicos.Ventanas
{
    partial class Modelo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmodeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestión_de_Recursos_TecnológicosDataSet = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSet();
            this.mODELOSTableAdapter = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSetTableAdapters.MODELOSTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gestióndeRecursosTecnológicosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestióndeRecursosTecnológicosDataSetBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmodeloDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mODELOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(419, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(540, 201);
            this.dataGridView1.TabIndex = 6;
            // 
            // idmodeloDataGridViewTextBoxColumn
            // 
            this.idmodeloDataGridViewTextBoxColumn.DataPropertyName = "id_modelo";
            this.idmodeloDataGridViewTextBoxColumn.HeaderText = "id_modelo";
            this.idmodeloDataGridViewTextBoxColumn.Name = "idmodeloDataGridViewTextBoxColumn";
            this.idmodeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mODELOSBindingSource
            // 
            this.mODELOSBindingSource.DataMember = "MODELOS";
            this.mODELOSBindingSource.DataSource = this.gestión_de_Recursos_TecnológicosDataSet;
            // 
            // gestión_de_Recursos_TecnológicosDataSet
            // 
            this.gestión_de_Recursos_TecnológicosDataSet.DataSetName = "Gestión_de_Recursos_TecnológicosDataSet";
            this.gestión_de_Recursos_TecnológicosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mODELOSTableAdapter
            // 
            this.mODELOSTableAdapter.ClearBeforeFill = true;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 8;
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
            // gestióndeRecursosTecnológicosDataSetBindingSource
            // 
            this.gestióndeRecursosTecnológicosDataSetBindingSource.DataSource = this.gestión_de_Recursos_TecnológicosDataSet;
            this.gestióndeRecursosTecnológicosDataSetBindingSource.Position = 0;
            // 
            // Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_nombre);
            this.Name = "Modelo";
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.Modelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestióndeRecursosTecnológicosDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_descripcion;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Gestión_de_Recursos_TecnológicosDataSet gestión_de_Recursos_TecnológicosDataSet;
        private System.Windows.Forms.BindingSource mODELOSBindingSource;
        private Gestión_de_Recursos_TecnológicosDataSetTableAdapters.MODELOSTableAdapter mODELOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource gestióndeRecursosTecnológicosDataSetBindingSource;
        private System.Windows.Forms.Button button1;
    }
}