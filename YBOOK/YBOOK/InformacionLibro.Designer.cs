namespace YBOOK
{
    partial class InformacionLibro
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtFechaPublicacion = new System.Windows.Forms.TextBox();
            this.txtNumeroPaginas = new System.Windows.Forms.TextBox();
            this.btnFavorito = new System.Windows.Forms.Button();
            this.btnNoFavorito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackgroundImage = global::YBOOK.Properties.Resources.close_icon;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(763, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.TabIndex = 14;
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Número de páginas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha Publicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Editorial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Idioma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Autor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(351, 48);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(193, 20);
            this.txtTitulo.TabIndex = 22;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(351, 106);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(193, 20);
            this.txtAutor.TabIndex = 23;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(351, 156);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.ReadOnly = true;
            this.txtIdioma.Size = new System.Drawing.Size(193, 20);
            this.txtIdioma.TabIndex = 24;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(351, 214);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.ReadOnly = true;
            this.txtEditorial.Size = new System.Drawing.Size(193, 20);
            this.txtEditorial.TabIndex = 25;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(351, 262);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(193, 20);
            this.txtCategoria.TabIndex = 26;
            // 
            // txtFechaPublicacion
            // 
            this.txtFechaPublicacion.Location = new System.Drawing.Point(351, 315);
            this.txtFechaPublicacion.Name = "txtFechaPublicacion";
            this.txtFechaPublicacion.ReadOnly = true;
            this.txtFechaPublicacion.Size = new System.Drawing.Size(193, 20);
            this.txtFechaPublicacion.TabIndex = 27;
            // 
            // txtNumeroPaginas
            // 
            this.txtNumeroPaginas.Location = new System.Drawing.Point(351, 371);
            this.txtNumeroPaginas.Name = "txtNumeroPaginas";
            this.txtNumeroPaginas.ReadOnly = true;
            this.txtNumeroPaginas.Size = new System.Drawing.Size(193, 20);
            this.txtNumeroPaginas.TabIndex = 28;
            // 
            // btnFavorito
            // 
            this.btnFavorito.Location = new System.Drawing.Point(661, 368);
            this.btnFavorito.Name = "btnFavorito";
            this.btnFavorito.Size = new System.Drawing.Size(75, 23);
            this.btnFavorito.TabIndex = 29;
            this.btnFavorito.Text = "+";
            this.btnFavorito.UseVisualStyleBackColor = true;
            // 
            // btnNoFavorito
            // 
            this.btnNoFavorito.Location = new System.Drawing.Point(661, 326);
            this.btnNoFavorito.Name = "btnNoFavorito";
            this.btnNoFavorito.Size = new System.Drawing.Size(75, 23);
            this.btnNoFavorito.TabIndex = 30;
            this.btnNoFavorito.Text = "--";
            this.btnNoFavorito.UseVisualStyleBackColor = true;
            // 
            // InformacionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoFavorito);
            this.Controls.Add(this.btnFavorito);
            this.Controls.Add(this.txtNumeroPaginas);
            this.Controls.Add(this.txtFechaPublicacion);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformacionLibro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformacionLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtFechaPublicacion;
        private System.Windows.Forms.TextBox txtNumeroPaginas;
        private System.Windows.Forms.Button btnFavorito;
        private System.Windows.Forms.Button btnNoFavorito;
    }
}