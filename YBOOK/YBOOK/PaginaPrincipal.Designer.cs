﻿namespace YBOOK
{
    partial class PaginaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Username = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLoader = new System.Windows.Forms.Panel();
            this.label_NombreSeccion = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.btnAñadirLibro = new System.Windows.Forms.Button();
            this.btnValoracion = new System.Windows.Forms.Button();
            this.btnLibrosUsuario = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnEditarPerfil);
            this.panel1.Controls.Add(this.btnAñadirLibro);
            this.panel1.Controls.Add(this.btnValoracion);
            this.panel1.Controls.Add(this.btnLibrosUsuario);
            this.panel1.Controls.Add(this.btnLibros);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(169, 793);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Username);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 132);
            this.panel2.TabIndex = 0;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.Color.White;
            this.label_Username.Location = new System.Drawing.Point(28, 95);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(90, 22);
            this.label_Username.TabIndex = 17;
            this.label_Username.Text = "USERNAME";
            this.label_Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(0, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 1);
            this.panel3.TabIndex = 2;
            // 
            // panelLoader
            // 
            this.panelLoader.Location = new System.Drawing.Point(196, 60);
            this.panelLoader.Name = "panelLoader";
            this.panelLoader.Size = new System.Drawing.Size(1137, 712);
            this.panelLoader.TabIndex = 14;
            // 
            // label_NombreSeccion
            // 
            this.label_NombreSeccion.AutoSize = true;
            this.label_NombreSeccion.Font = new System.Drawing.Font("Acephimere", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreSeccion.ForeColor = System.Drawing.Color.Black;
            this.label_NombreSeccion.Location = new System.Drawing.Point(200, 12);
            this.label_NombreSeccion.Name = "label_NombreSeccion";
            this.label_NombreSeccion.Size = new System.Drawing.Size(208, 43);
            this.label_NombreSeccion.TabIndex = 16;
            this.label_NombreSeccion.Text = "USERNAME";
            this.label_NombreSeccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackgroundImage = global::YBOOK.Properties.Resources.close_icon;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(1308, 5);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.TabIndex = 13;
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::YBOOK.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(5, 755);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(159, 33);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEditarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnEditarPerfil.Image = global::YBOOK.Properties.Resources.editarPerfil;
            this.btnEditarPerfil.Location = new System.Drawing.Point(5, 276);
            this.btnEditarPerfil.Margin = new System.Windows.Forms.Padding(10);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(159, 35);
            this.btnEditarPerfil.TabIndex = 5;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnAñadirLibro
            // 
            this.btnAñadirLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAñadirLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAñadirLibro.FlatAppearance.BorderSize = 0;
            this.btnAñadirLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAñadirLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirLibro.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirLibro.ForeColor = System.Drawing.Color.White;
            this.btnAñadirLibro.Image = global::YBOOK.Properties.Resources.añadir_libro;
            this.btnAñadirLibro.Location = new System.Drawing.Point(5, 241);
            this.btnAñadirLibro.Margin = new System.Windows.Forms.Padding(10);
            this.btnAñadirLibro.Name = "btnAñadirLibro";
            this.btnAñadirLibro.Size = new System.Drawing.Size(159, 35);
            this.btnAñadirLibro.TabIndex = 4;
            this.btnAñadirLibro.Text = "Nuevo Libro";
            this.btnAñadirLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAñadirLibro.UseVisualStyleBackColor = true;
            this.btnAñadirLibro.Click += new System.EventHandler(this.btnAñadirLibro_Click_1);
            // 
            // btnValoracion
            // 
            this.btnValoracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValoracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnValoracion.FlatAppearance.BorderSize = 0;
            this.btnValoracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnValoracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValoracion.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValoracion.ForeColor = System.Drawing.Color.White;
            this.btnValoracion.Image = global::YBOOK.Properties.Resources.valoracion;
            this.btnValoracion.Location = new System.Drawing.Point(5, 206);
            this.btnValoracion.Margin = new System.Windows.Forms.Padding(10);
            this.btnValoracion.Name = "btnValoracion";
            this.btnValoracion.Size = new System.Drawing.Size(159, 35);
            this.btnValoracion.TabIndex = 3;
            this.btnValoracion.Text = "Valoración";
            this.btnValoracion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnValoracion.UseVisualStyleBackColor = true;
            this.btnValoracion.Click += new System.EventHandler(this.btnValoracion_Click);
            // 
            // btnLibrosUsuario
            // 
            this.btnLibrosUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLibrosUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibrosUsuario.FlatAppearance.BorderSize = 0;
            this.btnLibrosUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLibrosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrosUsuario.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrosUsuario.ForeColor = System.Drawing.Color.White;
            this.btnLibrosUsuario.Image = global::YBOOK.Properties.Resources.mislibros;
            this.btnLibrosUsuario.Location = new System.Drawing.Point(5, 169);
            this.btnLibrosUsuario.Margin = new System.Windows.Forms.Padding(10);
            this.btnLibrosUsuario.Name = "btnLibrosUsuario";
            this.btnLibrosUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.btnLibrosUsuario.Size = new System.Drawing.Size(159, 37);
            this.btnLibrosUsuario.TabIndex = 2;
            this.btnLibrosUsuario.Text = "Mis Libros";
            this.btnLibrosUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLibrosUsuario.UseVisualStyleBackColor = true;
            this.btnLibrosUsuario.Click += new System.EventHandler(this.btnLibrosUsuario_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLibros.CausesValidation = false;
            this.btnLibros.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.White;
            this.btnLibros.Image = global::YBOOK.Properties.Resources.biblioteca;
            this.btnLibros.Location = new System.Drawing.Point(5, 137);
            this.btnLibros.Margin = new System.Windows.Forms.Padding(10);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(159, 32);
            this.btnLibros.TabIndex = 1;
            this.btnLibros.Text = "Biblioteca";
            this.btnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.GhostWhite;
            this.panel4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.Location = new System.Drawing.Point(0, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 1);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.GhostWhite;
            this.panel5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel5.Location = new System.Drawing.Point(0, 206);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 1);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.GhostWhite;
            this.panel6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel6.Location = new System.Drawing.Point(0, 241);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 1);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.GhostWhite;
            this.panel7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel7.Location = new System.Drawing.Point(0, 276);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 1);
            this.panel7.TabIndex = 6;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 793);
            this.Controls.Add(this.label_NombreSeccion);
            this.Controls.Add(this.panelLoader);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnValoracion;
        private System.Windows.Forms.Button btnLibrosUsuario;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Panel panelLoader;
        private System.Windows.Forms.Label label_NombreSeccion;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Button btnAñadirLibro;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}