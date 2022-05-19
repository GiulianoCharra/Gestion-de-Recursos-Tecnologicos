namespace Gestión_de_Recursos_Tecnológicos.Ventanas
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.redondeadoTextBox1 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            this.redondeadoTextBox2 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            this.redondeadoTextBox3 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            this.redondeadoTextBox4 = new Gestión_de_Recursos_Tecnológicos.Clases.Soporte.RedondeadoTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(94, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(522, 396);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Legajo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Curso";
            this.Column3.Name = "Column3";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(36, 356);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(185, 23);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Aceptar";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.redondeadoTextBox4);
            this.panel1.Controls.Add(this.redondeadoTextBox3);
            this.panel1.Controls.Add(this.redondeadoTextBox2);
            this.panel1.Controls.Add(this.redondeadoTextBox1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(653, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 396);
            this.panel1.TabIndex = 3;
            // 
            // redondeadoTextBox1
            // 
            this.redondeadoTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redondeadoTextBox1.BackColor = System.Drawing.Color.White;
            this.redondeadoTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.redondeadoTextBox1.BorderFocusColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox1.BorderRadio = 0;
            this.redondeadoTextBox1.BorderSize = 2;
            this.redondeadoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox1.Location = new System.Drawing.Point(36, 18);
            this.redondeadoTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox1.Multiline = false;
            this.redondeadoTextBox1.Name = "redondeadoTextBox1";
            this.redondeadoTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox1.Size = new System.Drawing.Size(185, 31);
            this.redondeadoTextBox1.TabIndex = 3;
            this.redondeadoTextBox1.Texts = "";
            this.redondeadoTextBox1.UnderlinedStyle = false;
            // 
            // redondeadoTextBox2
            // 
            this.redondeadoTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redondeadoTextBox2.BackColor = System.Drawing.Color.White;
            this.redondeadoTextBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.redondeadoTextBox2.BorderFocusColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox2.BorderRadio = 0;
            this.redondeadoTextBox2.BorderSize = 2;
            this.redondeadoTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox2.Location = new System.Drawing.Point(36, 67);
            this.redondeadoTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox2.Multiline = false;
            this.redondeadoTextBox2.Name = "redondeadoTextBox2";
            this.redondeadoTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox2.Size = new System.Drawing.Size(185, 31);
            this.redondeadoTextBox2.TabIndex = 4;
            this.redondeadoTextBox2.Texts = "";
            this.redondeadoTextBox2.UnderlinedStyle = false;
            // 
            // redondeadoTextBox3
            // 
            this.redondeadoTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redondeadoTextBox3.BackColor = System.Drawing.Color.White;
            this.redondeadoTextBox3.BorderColor = System.Drawing.Color.DarkGray;
            this.redondeadoTextBox3.BorderFocusColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox3.BorderRadio = 0;
            this.redondeadoTextBox3.BorderSize = 2;
            this.redondeadoTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox3.Location = new System.Drawing.Point(36, 116);
            this.redondeadoTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox3.Multiline = false;
            this.redondeadoTextBox3.Name = "redondeadoTextBox3";
            this.redondeadoTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox3.Size = new System.Drawing.Size(185, 31);
            this.redondeadoTextBox3.TabIndex = 5;
            this.redondeadoTextBox3.Texts = "";
            this.redondeadoTextBox3.UnderlinedStyle = false;
            // 
            // redondeadoTextBox4
            // 
            this.redondeadoTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redondeadoTextBox4.BackColor = System.Drawing.Color.White;
            this.redondeadoTextBox4.BorderColor = System.Drawing.Color.DarkGray;
            this.redondeadoTextBox4.BorderFocusColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox4.BorderRadio = 0;
            this.redondeadoTextBox4.BorderSize = 2;
            this.redondeadoTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondeadoTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.redondeadoTextBox4.Location = new System.Drawing.Point(36, 164);
            this.redondeadoTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.redondeadoTextBox4.Multiline = false;
            this.redondeadoTextBox4.Name = "redondeadoTextBox4";
            this.redondeadoTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.redondeadoTextBox4.Size = new System.Drawing.Size(185, 31);
            this.redondeadoTextBox4.TabIndex = 6;
            this.redondeadoTextBox4.Texts = "";
            this.redondeadoTextBox4.UnderlinedStyle = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(928, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox1;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox4;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox3;
        private Clases.Soporte.RedondeadoTextBox redondeadoTextBox2;
    }
}