namespace YBOOK
{
    partial class MisLibros
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_Idioma = new System.Windows.Forms.Label();
            this.lb_NumeroPaginas = new System.Windows.Forms.Label();
            this.numeric_PaginaActual = new System.Windows.Forms.NumericUpDown();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PaginaActual)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(607, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 403);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "LIBRO";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ESTADO";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Progreso";
            this.Column3.Name = "Column3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 28);
            this.label7.TabIndex = 35;
            this.label7.Text = "Número de páginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Idioma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(533, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 28);
            this.label9.TabIndex = 43;
            this.label9.Text = "Página Actual";
            // 
            // lb_Idioma
            // 
            this.lb_Idioma.AutoSize = true;
            this.lb_Idioma.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Idioma.Location = new System.Drawing.Point(337, 128);
            this.lb_Idioma.Name = "lb_Idioma";
            this.lb_Idioma.Size = new System.Drawing.Size(90, 28);
            this.lb_Idioma.TabIndex = 48;
            this.lb_Idioma.Text = "------";
            // 
            // lb_NumeroPaginas
            // 
            this.lb_NumeroPaginas.AutoSize = true;
            this.lb_NumeroPaginas.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumeroPaginas.Location = new System.Drawing.Point(818, 128);
            this.lb_NumeroPaginas.Name = "lb_NumeroPaginas";
            this.lb_NumeroPaginas.Size = new System.Drawing.Size(90, 28);
            this.lb_NumeroPaginas.TabIndex = 49;
            this.lb_NumeroPaginas.Text = "------";
            // 
            // numeric_PaginaActual
            // 
            this.numeric_PaginaActual.Location = new System.Drawing.Point(823, 206);
            this.numeric_PaginaActual.Name = "numeric_PaginaActual";
            this.numeric_PaginaActual.Size = new System.Drawing.Size(120, 20);
            this.numeric_PaginaActual.TabIndex = 50;
            // 
            // cb_Estado
            // 
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Items.AddRange(new object[] {
            "Leído",
            "Leyendo",
            "Deseado"});
            this.cb_Estado.Location = new System.Drawing.Point(340, 197);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(121, 21);
            this.cb_Estado.TabIndex = 51;
            this.cb_Estado.SelectedIndexChanged += new System.EventHandler(this.cb_Estado_SelectedIndexChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(341, 85);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(411, 22);
            this.txtTitulo.TabIndex = 52;
            // 
            // MisLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1137, 712);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.cb_Estado);
            this.Controls.Add(this.numeric_PaginaActual);
            this.Controls.Add(this.lb_NumeroPaginas);
            this.Controls.Add(this.lb_Idioma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisLibros";
            this.ShowInTaskbar = false;
            this.Text = "MisLibros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PaginaActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lb_Idioma;
        private System.Windows.Forms.Label lb_NumeroPaginas;
        private System.Windows.Forms.NumericUpDown numeric_PaginaActual;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}