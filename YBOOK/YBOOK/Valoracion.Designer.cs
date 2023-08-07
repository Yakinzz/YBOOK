﻿namespace YBOOK
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
            this.btn_AddValoracion = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_EliminarValoracion = new System.Windows.Forms.Button();
            this.lbLibro = new System.Windows.Forms.Label();
            this.lbPuntuacion = new System.Windows.Forms.Label();
            this.lbComentario = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.tb_Puntuacion = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Puntuacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_libros
            // 
            this.cb_libros.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cb_libros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_libros.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_libros.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_libros.FormattingEnabled = true;
            this.cb_libros.Location = new System.Drawing.Point(668, 107);
            this.cb_libros.Name = "cb_libros";
            this.cb_libros.Size = new System.Drawing.Size(409, 23);
            this.cb_libros.TabIndex = 0;
            this.cb_libros.SelectedIndexChanged += new System.EventHandler(this.cb_libros_SelectedIndexChanged);
            // 
            // btn_AddValoracion
            // 
            this.btn_AddValoracion.Location = new System.Drawing.Point(727, 177);
            this.btn_AddValoracion.Name = "btn_AddValoracion";
            this.btn_AddValoracion.Size = new System.Drawing.Size(72, 44);
            this.btn_AddValoracion.TabIndex = 2;
            this.btn_AddValoracion.Text = "Añadir Valoracion";
            this.btn_AddValoracion.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(841, 177);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(72, 44);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            // 
            // btn_EliminarValoracion
            // 
            this.btn_EliminarValoracion.Location = new System.Drawing.Point(948, 177);
            this.btn_EliminarValoracion.Name = "btn_EliminarValoracion";
            this.btn_EliminarValoracion.Size = new System.Drawing.Size(72, 44);
            this.btn_EliminarValoracion.TabIndex = 4;
            this.btn_EliminarValoracion.Text = "Eliminar";
            this.btn_EliminarValoracion.UseVisualStyleBackColor = true;
            this.btn_EliminarValoracion.Visible = false;
            // 
            // lbLibro
            // 
            this.lbLibro.AutoSize = true;
            this.lbLibro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibro.Location = new System.Drawing.Point(665, 252);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(63, 19);
            this.lbLibro.TabIndex = 5;
            this.lbLibro.Text = "LIBRO:";
            this.lbLibro.Visible = false;
            // 
            // lbPuntuacion
            // 
            this.lbPuntuacion.AutoSize = true;
            this.lbPuntuacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntuacion.Location = new System.Drawing.Point(665, 326);
            this.lbPuntuacion.Name = "lbPuntuacion";
            this.lbPuntuacion.Size = new System.Drawing.Size(108, 19);
            this.lbPuntuacion.TabIndex = 6;
            this.lbPuntuacion.Text = "PUNTUACION:";
            this.lbPuntuacion.Visible = false;
            // 
            // lbComentario
            // 
            this.lbComentario.AutoSize = true;
            this.lbComentario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComentario.Location = new System.Drawing.Point(665, 393);
            this.lbComentario.Name = "lbComentario";
            this.lbComentario.Size = new System.Drawing.Size(108, 19);
            this.lbComentario.TabIndex = 7;
            this.lbComentario.Text = "COMENTARIO:";
            this.lbComentario.Visible = false;
            // 
            // txtLibro
            // 
            this.txtLibro.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibro.ForeColor = System.Drawing.Color.White;
            this.txtLibro.Location = new System.Drawing.Point(668, 274);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(410, 20);
            this.txtLibro.TabIndex = 8;
            this.txtLibro.Visible = false;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(668, 415);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(410, 226);
            this.txtComentario.TabIndex = 10;
            this.txtComentario.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtNacionalidad);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombreAutor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 174);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AUTOR";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidad.ForeColor = System.Drawing.Color.White;
            this.txtNacionalidad.Location = new System.Drawing.Point(147, 115);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.ReadOnly = true;
            this.txtNacionalidad.Size = new System.Drawing.Size(263, 30);
            this.txtNacionalidad.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.ForeColor = System.Drawing.Color.White;
            this.txtApellidos.Location = new System.Drawing.Point(147, 75);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(263, 30);
            this.txtApellidos.TabIndex = 7;
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreAutor.ForeColor = System.Drawing.Color.White;
            this.txtNombreAutor.Location = new System.Drawing.Point(147, 36);
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.ReadOnly = true;
            this.txtNombreAutor.Size = new System.Drawing.Size(263, 30);
            this.txtNombreAutor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nacionalidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Idioma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Editorial:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditorial.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.ForeColor = System.Drawing.Color.White;
            this.txtEditorial.Location = new System.Drawing.Point(177, 274);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.ReadOnly = true;
            this.txtEditorial.Size = new System.Drawing.Size(272, 30);
            this.txtEditorial.TabIndex = 9;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.White;
            this.txtCategoria.Location = new System.Drawing.Point(177, 314);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(272, 30);
            this.txtCategoria.TabIndex = 16;
            // 
            // txtIdioma
            // 
            this.txtIdioma.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIdioma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdioma.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.ForeColor = System.Drawing.Color.White;
            this.txtIdioma.Location = new System.Drawing.Point(177, 348);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.ReadOnly = true;
            this.txtIdioma.Size = new System.Drawing.Size(272, 30);
            this.txtIdioma.TabIndex = 17;
            // 
            // tb_Puntuacion
            // 
            this.tb_Puntuacion.Location = new System.Drawing.Point(668, 348);
            this.tb_Puntuacion.Name = "tb_Puntuacion";
            this.tb_Puntuacion.Size = new System.Drawing.Size(104, 45);
            this.tb_Puntuacion.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::YBOOK.Properties.Resources.valoraciones;
            this.pictureBox1.Location = new System.Drawing.Point(177, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 119);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Valoracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1137, 712);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_Puntuacion);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.lbComentario);
            this.Controls.Add(this.lbPuntuacion);
            this.Controls.Add(this.lbLibro);
            this.Controls.Add(this.btn_EliminarValoracion);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_AddValoracion);
            this.Controls.Add(this.cb_libros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Valoracion";
            this.Text = "Valoracion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Puntuacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_libros;
        private System.Windows.Forms.Button btn_AddValoracion;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_EliminarValoracion;
        private System.Windows.Forms.Label lbLibro;
        private System.Windows.Forms.Label lbPuntuacion;
        private System.Windows.Forms.Label lbComentario;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.TrackBar tb_Puntuacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}