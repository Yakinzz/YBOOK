namespace YBOOK
{
    partial class Valoracion
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
            this.cb_libros = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddValoracion = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_EliminarValoracion = new System.Windows.Forms.Button();
            this.lbLibro = new System.Windows.Forms.Label();
            this.lbPuntuacion = new System.Windows.Forms.Label();
            this.lbComentario = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_libros
            // 
            this.cb_libros.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cb_libros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_libros.FormattingEnabled = true;
            this.cb_libros.Location = new System.Drawing.Point(12, 12);
            this.cb_libros.Name = "cb_libros";
            this.cb_libros.Size = new System.Drawing.Size(290, 21);
            this.cb_libros.TabIndex = 0;
            this.cb_libros.SelectedIndexChanged += new System.EventHandler(this.cb_libros_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1113, 431);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "LIBRO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "USUARIO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PUNTUACIÓN";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "COMENTARIO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FECHA";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btn_AddValoracion
            // 
            this.btn_AddValoracion.Location = new System.Drawing.Point(347, 12);
            this.btn_AddValoracion.Name = "btn_AddValoracion";
            this.btn_AddValoracion.Size = new System.Drawing.Size(110, 23);
            this.btn_AddValoracion.TabIndex = 2;
            this.btn_AddValoracion.Text = "Añadir Valoracion";
            this.btn_AddValoracion.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(481, 12);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            // 
            // btn_EliminarValoracion
            // 
            this.btn_EliminarValoracion.Location = new System.Drawing.Point(616, 10);
            this.btn_EliminarValoracion.Name = "btn_EliminarValoracion";
            this.btn_EliminarValoracion.Size = new System.Drawing.Size(110, 23);
            this.btn_EliminarValoracion.TabIndex = 4;
            this.btn_EliminarValoracion.Text = "Eliminar";
            this.btn_EliminarValoracion.UseVisualStyleBackColor = true;
            this.btn_EliminarValoracion.Visible = false;
            // 
            // lbLibro
            // 
            this.lbLibro.AutoSize = true;
            this.lbLibro.Location = new System.Drawing.Point(14, 107);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(42, 13);
            this.lbLibro.TabIndex = 5;
            this.lbLibro.Text = "LIBRO:";
            this.lbLibro.Visible = false;
            // 
            // lbPuntuacion
            // 
            this.lbPuntuacion.AutoSize = true;
            this.lbPuntuacion.Location = new System.Drawing.Point(14, 168);
            this.lbPuntuacion.Name = "lbPuntuacion";
            this.lbPuntuacion.Size = new System.Drawing.Size(81, 13);
            this.lbPuntuacion.TabIndex = 6;
            this.lbPuntuacion.Text = "PUNTUACION:";
            this.lbPuntuacion.Visible = false;
            // 
            // lbComentario
            // 
            this.lbComentario.AutoSize = true;
            this.lbComentario.Location = new System.Drawing.Point(467, 107);
            this.lbComentario.Name = "lbComentario";
            this.lbComentario.Size = new System.Drawing.Size(82, 13);
            this.lbComentario.TabIndex = 7;
            this.lbComentario.Text = "COMENTARIO:";
            this.lbComentario.Visible = false;
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(130, 104);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(273, 20);
            this.txtLibro.TabIndex = 8;
            this.txtLibro.Visible = false;
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(130, 161);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(273, 20);
            this.txtPuntuacion.TabIndex = 9;
            this.txtPuntuacion.Visible = false;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(583, 100);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(410, 136);
            this.txtComentario.TabIndex = 10;
            this.txtComentario.Visible = false;
            // 
            // Valoracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1137, 712);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.lbComentario);
            this.Controls.Add(this.lbPuntuacion);
            this.Controls.Add(this.lbLibro);
            this.Controls.Add(this.btn_EliminarValoracion);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_AddValoracion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_libros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Valoracion";
            this.Text = "Valoracion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_libros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_AddValoracion;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_EliminarValoracion;
        private System.Windows.Forms.Label lbLibro;
        private System.Windows.Forms.Label lbPuntuacion;
        private System.Windows.Forms.Label lbComentario;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.TextBox txtComentario;
    }
}