using System.ComponentModel;

namespace YBOOK
{
    partial class NuevoActor
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Nacionalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.check_Fallecido = new System.Windows.Forms.CheckBox();
            this.dt_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dt_FechaFallecimiento = new System.Windows.Forms.DateTimePicker();
            this.label_FF = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_CrearAutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackgroundImage = global::YBOOK.Properties.Resources.close_icon;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(801, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.TabIndex = 15;
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(251)))));
            this.txt_Nombre.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_Nombre.Location = new System.Drawing.Point(32, 47);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(254, 27);
            this.txt_Nombre.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(251)))));
            this.txt_Apellidos.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_Apellidos.Location = new System.Drawing.Point(36, 128);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(250, 27);
            this.txt_Apellidos.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellidos";
            // 
            // cb_Nacionalidad
            // 
            this.cb_Nacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(251)))));
            this.cb_Nacionalidad.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nacionalidad.FormattingEnabled = true;
            this.cb_Nacionalidad.Location = new System.Drawing.Point(36, 204);
            this.cb_Nacionalidad.Name = "cb_Nacionalidad";
            this.cb_Nacionalidad.Size = new System.Drawing.Size(220, 28);
            this.cb_Nacionalidad.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nacionalidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // check_Fallecido
            // 
            this.check_Fallecido.Font = new System.Drawing.Font("Acephimere", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Fallecido.Location = new System.Drawing.Point(36, 320);
            this.check_Fallecido.Name = "check_Fallecido";
            this.check_Fallecido.Size = new System.Drawing.Size(104, 24);
            this.check_Fallecido.TabIndex = 24;
            this.check_Fallecido.Text = "Fallecido";
            this.check_Fallecido.UseVisualStyleBackColor = true;
            this.check_Fallecido.CheckedChanged += new System.EventHandler(this.check_Fallecido_CheckedChanged);
            // 
            // dt_FechaNacimiento
            // 
            this.dt_FechaNacimiento.CalendarFont = new System.Drawing.Font("Acephimere", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(251)))));
            this.dt_FechaNacimiento.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaNacimiento.Location = new System.Drawing.Point(36, 278);
            this.dt_FechaNacimiento.Name = "dt_FechaNacimiento";
            this.dt_FechaNacimiento.Size = new System.Drawing.Size(104, 27);
            this.dt_FechaNacimiento.TabIndex = 25;
            // 
            // dt_FechaFallecimiento
            // 
            this.dt_FechaFallecimiento.CalendarFont = new System.Drawing.Font("Acephimere", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaFallecimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(251)))));
            this.dt_FechaFallecimiento.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt_FechaFallecimiento.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(251)))));
            this.dt_FechaFallecimiento.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaFallecimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaFallecimiento.Location = new System.Drawing.Point(36, 384);
            this.dt_FechaFallecimiento.Name = "dt_FechaFallecimiento";
            this.dt_FechaFallecimiento.Size = new System.Drawing.Size(104, 27);
            this.dt_FechaFallecimiento.TabIndex = 27;
            // 
            // label_FF
            // 
            this.label_FF.AutoSize = true;
            this.label_FF.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FF.Location = new System.Drawing.Point(36, 357);
            this.label_FF.Name = "label_FF";
            this.label_FF.Size = new System.Drawing.Size(179, 24);
            this.label_FF.TabIndex = 26;
            this.label_FF.Text = "Fecha Fallecimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YBOOK.Properties.Resources.fondoCreaAutor;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(342, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 361);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btn_CrearAutor
            // 
            this.btn_CrearAutor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_CrearAutor.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearAutor.ForeColor = System.Drawing.Color.White;
            this.btn_CrearAutor.Location = new System.Drawing.Point(453, 406);
            this.btn_CrearAutor.Name = "btn_CrearAutor";
            this.btn_CrearAutor.Size = new System.Drawing.Size(220, 38);
            this.btn_CrearAutor.TabIndex = 29;
            this.btn_CrearAutor.Text = "Crear Autor";
            this.btn_CrearAutor.UseVisualStyleBackColor = false;
            this.btn_CrearAutor.Click += new System.EventHandler(this.btn_CrearAutor_Click);
            // 
            // NuevoActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(838, 475);
            this.Controls.Add(this.btn_CrearAutor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dt_FechaFallecimiento);
            this.Controls.Add(this.label_FF);
            this.Controls.Add(this.dt_FechaNacimiento);
            this.Controls.Add(this.check_Fallecido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Nacionalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoActor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoActor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_CrearAutor;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.DateTimePicker dt_FechaFallecimiento;
        private System.Windows.Forms.Label label_FF;

        private System.Windows.Forms.DateTimePicker dt_FechaNacimiento;

        private System.Windows.Forms.ComboBox cb_Nacionalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check_Fallecido;

        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btn_Cerrar;

        #endregion
    }
}