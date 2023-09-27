namespace YBOOK.User
{
    partial class CambiarPassword
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
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseñaNuevaRepetida = new System.Windows.Forms.TextBox();
            this.btn_CambiarPassword = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.BackColor = System.Drawing.Color.Lavender;
            this.txtContraseñaActual.Font = new System.Drawing.Font("Acephimere", 8.999999F);
            this.txtContraseñaActual.Location = new System.Drawing.Point(64, 114);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(180, 22);
            this.txtContraseñaActual.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Acephimere", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña Actual";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Acephimere", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "CAMBIO DE CONTRASEÑA";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Acephimere", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nueva Contraseña";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Acephimere", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repite Nueva Contraseña";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.BackColor = System.Drawing.Color.Lavender;
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Acephimere", 8.999999F);
            this.txtNuevaContraseña.Location = new System.Drawing.Point(64, 197);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(180, 22);
            this.txtNuevaContraseña.TabIndex = 7;
            // 
            // txtContraseñaNuevaRepetida
            // 
            this.txtContraseñaNuevaRepetida.BackColor = System.Drawing.Color.Lavender;
            this.txtContraseñaNuevaRepetida.Font = new System.Drawing.Font("Acephimere", 8.999999F);
            this.txtContraseñaNuevaRepetida.Location = new System.Drawing.Point(64, 273);
            this.txtContraseñaNuevaRepetida.Name = "txtContraseñaNuevaRepetida";
            this.txtContraseñaNuevaRepetida.Size = new System.Drawing.Size(180, 22);
            this.txtContraseñaNuevaRepetida.TabIndex = 8;
            // 
            // btn_CambiarPassword
            // 
            this.btn_CambiarPassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_CambiarPassword.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CambiarPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CambiarPassword.Location = new System.Drawing.Point(64, 332);
            this.btn_CambiarPassword.Name = "btn_CambiarPassword";
            this.btn_CambiarPassword.Size = new System.Drawing.Size(180, 32);
            this.btn_CambiarPassword.TabIndex = 26;
            this.btn_CambiarPassword.Text = "Cambiar";
            this.btn_CambiarPassword.UseVisualStyleBackColor = false;
            this.btn_CambiarPassword.Click += new System.EventHandler(this.btn_CambiarPassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YBOOK.Properties.Resources.cambioPassword;
            this.pictureBox1.Location = new System.Drawing.Point(334, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackgroundImage = global::YBOOK.Properties.Resources.close_icon;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(720, 9);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.TabIndex = 28;
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(757, 394);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CambiarPassword);
            this.Controls.Add(this.txtContraseñaNuevaRepetida);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseñaActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtContraseñaNuevaRepetida;
        private System.Windows.Forms.Button btn_CambiarPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}