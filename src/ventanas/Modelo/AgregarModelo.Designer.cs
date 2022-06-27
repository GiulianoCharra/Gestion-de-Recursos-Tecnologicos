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
            this.mARCASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestión_de_Recursos_TecnológicosDataSet = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSet();
            this.mARCASTableAdapter = new Gestión_de_Recursos_Tecnológicos.Gestión_de_Recursos_TecnológicosDataSetTableAdapters.MARCASTableAdapter();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cmb_marcas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.dgv_modelos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mARCASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelos)).BeginInit();
            this.SuspendLayout();
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
            // mARCASTableAdapter
            // 
            this.mARCASTableAdapter.ClearBeforeFill = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(173, 202);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 26;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cmb_marcas
            // 
            this.cmb_marcas.DataSource = this.mARCASBindingSource;
            this.cmb_marcas.DisplayMember = "nombre";
            this.cmb_marcas.FormattingEnabled = true;
            this.cmb_marcas.Location = new System.Drawing.Point(92, 154);
            this.cmb_marcas.Name = "cmb_marcas";
            this.cmb_marcas.Size = new System.Drawing.Size(230, 21);
            this.cmb_marcas.TabIndex = 25;
            this.cmb_marcas.ValueMember = "id_marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Marca";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(92, 202);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 23;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripcion";
            // 
            // tx_descripcion
            // 
            this.tx_descripcion.Location = new System.Drawing.Point(92, 94);
            this.tx_descripcion.Multiline = true;
            this.tx_descripcion.Name = "tx_descripcion";
            this.tx_descripcion.Size = new System.Drawing.Size(230, 46);
            this.tx_descripcion.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre";
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(92, 60);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(230, 20);
            this.tx_nombre.TabIndex = 20;
            // 
            // dgv_modelos
            // 
            this.dgv_modelos.AllowUserToAddRows = false;
            this.dgv_modelos.AllowUserToDeleteRows = false;
            this.dgv_modelos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_modelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_modelos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_modelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modelos.Location = new System.Drawing.Point(343, 60);
            this.dgv_modelos.Name = "dgv_modelos";
            this.dgv_modelos.ReadOnly = true;
            this.dgv_modelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_modelos.Size = new System.Drawing.Size(405, 159);
            this.dgv_modelos.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Agregar Modelo";
            // 
            // AgregarModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 231);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cmb_marcas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.dgv_modelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarModelo";
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.Modelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mARCASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestión_de_Recursos_TecnológicosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cmb_marcas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.DataGridView dgv_modelos;
        private System.Windows.Forms.Label label4;
    }
}