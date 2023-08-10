using System.ComponentModel;

namespace YBOOK
{
    partial class ConfirmacionEstado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtPaginaActual = new System.Windows.Forms.TextBox();
            this.cb_Estados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_paginas = new System.Windows.Forms.Label();
            this.label_barra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.txtTotalPaginas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPaginaActual
            // 
            this.txtPaginaActual.Font = new System.Drawing.Font("Acephimere", 8.999999F);
            this.txtPaginaActual.Location = new System.Drawing.Point(471, 155);
            this.txtPaginaActual.Name = "txtPaginaActual";
            this.txtPaginaActual.Size = new System.Drawing.Size(65, 22);
            this.txtPaginaActual.TabIndex = 1;
            // 
            // cb_Estados
            // 
            this.cb_Estados.Font = new System.Drawing.Font("Acephimere", 8.999999F);
            this.cb_Estados.FormattingEnabled = true;
            this.cb_Estados.Items.AddRange(new object[] { "Leido", "Deseado", "Leyendo" });
            this.cb_Estados.Location = new System.Drawing.Point(451, 77);
            this.cb_Estados.Name = "cb_Estados";
            this.cb_Estados.Size = new System.Drawing.Size(216, 23);
            this.cb_Estados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Acephimere", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona el estado del libro";
            // 
            // label_paginas
            // 
            this.label_paginas.Font = new System.Drawing.Font("Acephimere", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paginas.Location = new System.Drawing.Point(451, 129);
            this.label_paginas.Name = "label_paginas";
            this.label_paginas.Size = new System.Drawing.Size(204, 23);
            this.label_paginas.TabIndex = 3;
            this.label_paginas.Text = "Indique el número de página actual";
            // 
            // label_barra
            // 
            this.label_barra.Font = new System.Drawing.Font("Acephimere", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_barra.Location = new System.Drawing.Point(542, 149);
            this.label_barra.Name = "label_barra";
            this.label_barra.Size = new System.Drawing.Size(20, 35);
            this.label_barra.TabIndex = 4;
            this.label_barra.Text = "/";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YBOOK.Properties.Resources.fondoEstado;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 286);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_LogIn.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LogIn.Location = new System.Drawing.Point(516, 266);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(235, 32);
            this.btn_LogIn.TabIndex = 25;
            this.btn_LogIn.Text = "Agregar a mis libros";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            // 
            // txtTotalPaginas
            // 
            this.txtTotalPaginas.Enabled = false;
            this.txtTotalPaginas.Font = new System.Drawing.Font("Acephimere", 8.999999F);
            this.txtTotalPaginas.Location = new System.Drawing.Point(568, 155);
            this.txtTotalPaginas.Name = "txtTotalPaginas";
            this.txtTotalPaginas.ReadOnly = true;
            this.txtTotalPaginas.Size = new System.Drawing.Size(65, 22);
            this.txtTotalPaginas.TabIndex = 26;
            // 
            // ConfirmacionEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(763, 310);
            this.Controls.Add(this.txtTotalPaginas);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_barra);
            this.Controls.Add(this.label_paginas);
            this.Controls.Add(this.cb_Estados);
            this.Controls.Add(this.txtPaginaActual);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmacionEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmacionEstado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTotalPaginas;

        private System.Windows.Forms.Button btn_LogIn;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label label_paginas;
        private System.Windows.Forms.Label label_barra;

        private System.Windows.Forms.ComboBox cb_Estados;

        private System.Windows.Forms.TextBox txtPaginaActual;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}