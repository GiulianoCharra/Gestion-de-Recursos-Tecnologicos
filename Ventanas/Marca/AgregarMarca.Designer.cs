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
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestión_de_Recursos_TecnológicosDataSet = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSet();
            this.btn_agregar_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregar_modelo = new System.Windows.Forms.Button();
            this.mARCASTableAdapter = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSetTableAdapters.MARCASTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(78, 69);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(156, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(78, 105);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(156, 43);
            this.txt_descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // dgv_Marcas
            // 
            this.dgv_Marcas.AllowUserToAddRows = false;
            this.dgv_Marcas.AllowUserToDeleteRows = false;
            this.dgv_Marcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Marcas.AutoGenerateColumns = false;
            this.dgv_Marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Marcas.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgv_Marcas.DataSource = this.mARCASBindingSource;
            this.dgv_Marcas.Location = new System.Drawing.Point(270, 70);
            this.dgv_Marcas.Name = "dgv_Marcas";
            this.dgv_Marcas.ReadOnly = true;
            this.dgv_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Marcas.Size = new System.Drawing.Size(345, 218);
            this.dgv_Marcas.TabIndex = 4;
            this.dgv_Marcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Marcas_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_marca";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_marca";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn8.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // mARCASBindingSource
            // 
            this.mARCASBindingSource.DataMember = "MARCAS";
            this.mARCASBindingSource.DataSource = this.gestión_de_Recursos_TecnológicosDataSet;
            // 
            // gestión_de_Recursos_TecnológicosDataSet
            // 
            this.gestión_de_Recursos_TecnológicosDataSet.DataSetName = "Gestión_de_Recursos_TecnológicosDataSet";
            this.gestión_de_Recursos_TecnológicosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_agregar_modificar
            // 
            this.btn_agregar_modificar.Location = new System.Drawing.Point(78, 175);
            this.btn_agregar_modificar.Name = "btn_agregar_modificar";
            this.btn_agregar_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_modificar.TabIndex = 5;
            this.btn_agregar_modificar.Text = "Agregar";
            this.btn_agregar_modificar.UseVisualStyleBackColor = true;
            this.btn_agregar_modificar.Click += new System.EventHandler(this.agregarModificarMarca);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(159, 175);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.cancelar);
            // 
            // btn_agregar_modelo
            // 
            this.btn_agregar_modelo.Location = new System.Drawing.Point(78, 272);
            this.btn_agregar_modelo.Name = "btn_agregar_modelo";
            this.btn_agregar_modelo.Size = new System.Drawing.Size(90, 23);
            this.btn_agregar_modelo.TabIndex = 7;
            this.btn_agregar_modelo.Text = "Agregar Modelo";
            this.btn_agregar_modelo.UseVisualStyleBackColor = true;
            this.btn_agregar_modelo.Click += new System.EventHandler(this.btn_agregar_modelo_Click);
            // 
            // mARCASTableAdapter
            // 
            this.mARCASTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Agregar Marcas";
            // 
            // AgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 300);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.mARCASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn descripcionDataGridViewImageColumn;
        private System.Windows.Forms.Button btn_agregar_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Gestión_de_Recursos_TecnológicosDataSet gestión_de_Recursos_TecnológicosDataSet;
        private System.Windows.Forms.BindingSource mARCASBindingSource;
        private Gestión_de_Recursos_TecnológicosDataSetTableAdapters.MARCASTableAdapter mARCASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label3;
    }
}