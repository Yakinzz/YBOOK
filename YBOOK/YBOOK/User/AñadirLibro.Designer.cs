namespace YBOOK
{
    partial class AñadirLibro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha_Publicacion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Numero_Páginas = new System.Windows.Forms.NumericUpDown();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.cb_Autor = new System.Windows.Forms.ComboBox();
            this.cb_Idioma = new System.Windows.Forms.ComboBox();
            this.txt_Editorial = new System.Windows.Forms.TextBox();
            this.cb_Categoria = new System.Windows.Forms.ComboBox();
            this.btn_AñadirLibro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AddAutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Páginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idioma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(884, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(650, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Publicación";
            // 
            // fecha_Publicacion
            // 
            this.fecha_Publicacion.Checked = false;
            this.fecha_Publicacion.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_Publicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_Publicacion.Location = new System.Drawing.Point(669, 488);
            this.fecha_Publicacion.Name = "fecha_Publicacion";
            this.fecha_Publicacion.Size = new System.Drawing.Size(125, 27);
            this.fecha_Publicacion.TabIndex = 6;
            this.fecha_Publicacion.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(917, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Número de páginas";
            // 
            // Numero_Páginas
            // 
            this.Numero_Páginas.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_Páginas.Location = new System.Drawing.Point(962, 488);
            this.Numero_Páginas.Name = "Numero_Páginas";
            this.Numero_Páginas.Size = new System.Drawing.Size(73, 27);
            this.Numero_Páginas.TabIndex = 8;
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_Titulo.Location = new System.Drawing.Point(613, 176);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(458, 27);
            this.txt_Titulo.TabIndex = 9;
            // 
            // cb_Autor
            // 
            this.cb_Autor.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Autor.FormattingEnabled = true;
            this.cb_Autor.Location = new System.Drawing.Point(613, 247);
            this.cb_Autor.Name = "cb_Autor";
            this.cb_Autor.Size = new System.Drawing.Size(220, 28);
            this.cb_Autor.TabIndex = 10;
            // 
            // cb_Idioma
            // 
            this.cb_Idioma.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Idioma.FormattingEnabled = true;
            this.cb_Idioma.Items.AddRange(new object[] { "Azerí", "Afrikaans", "Albanés", "Alemán", "Alsaciano", "Amárico", "Anglosajón", "Árabe", "Aragonés", "Armenio", "Aymara", "Bajo sajón", "Bengalí", "Bielorruso", "Birmano", "Bosnio", "Bretón", "Búlgaro", "Canarés", "Catalán", "Chamorro", "Checo", "Cheroqui", "Chino mandarín", "Coreano", "Corso", "Croata", "Curdo", "Danés", "Eslovaco ", "Esloveno", "Español", "Esperanto", "Estonio", "Euskera", "Feroés", "Fiyiano", "Finlandés", "Francés", "Frisón", "Galés", "Gallego", "Georgiano", "Griego", "Guaraní", "Gujaratí", "Hebreo israelí", "Hindi", "Holandés", "Húngaro", "Ido", "Igbo", "Indonesio", "Inglés", "Interlingua", "Irlandés", "Islandés", "Italiano", "Japonés", "Javanés", "Kazako", "Laosiano", "Latín", "Letón", "Lingala", "Lituano", "Luxemburgués", "Macedonio", "Malabar", "Malayo", "Malgache", "Maltés", "Manés", "Maorí", "Marati", "Moldavo", "Mongol", "Náhuatl", "Nauruano", "Noruego", "Occitano", "Papiamento", "Persa moderno", "Polaco", "Portugués", "Punjabí", "Quechua", "Quirguiz", "Romanche", "Rumano", "Ruso", "Sardo", "Serbio", "Sesotho", "Siciliano", "Somalí", "Sueco", "Swahili", "Tagalo", "Tailandés", "Tamil", "Tártaro", "Tártaro de Crimea", "Tegulú", "Tibetano", "Turco", "Turcomano", "Ucraniano", "Urdu", "Uzbeko", "Valón", "Vietnamita", "Volapuk", "Xhosa", "Yidish", "Yoruba", "Zulú" });
            this.cb_Idioma.Location = new System.Drawing.Point(613, 322);
            this.cb_Idioma.Name = "cb_Idioma";
            this.cb_Idioma.Size = new System.Drawing.Size(168, 28);
            this.cb_Idioma.TabIndex = 11;
            // 
            // txt_Editorial
            // 
            this.txt_Editorial.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Editorial.Location = new System.Drawing.Point(613, 398);
            this.txt_Editorial.Name = "txt_Editorial";
            this.txt_Editorial.Size = new System.Drawing.Size(234, 27);
            this.txt_Editorial.TabIndex = 12;
            // 
            // cb_Categoria
            // 
            this.cb_Categoria.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Categoria.FormattingEnabled = true;
            this.cb_Categoria.Items.AddRange(new object[] { "Narrativa", "Policiaca", "Terror", "Autoayuda", "Alimentacion", "Anime", "Educativo" });
            this.cb_Categoria.Location = new System.Drawing.Point(888, 398);
            this.cb_Categoria.Name = "cb_Categoria";
            this.cb_Categoria.Size = new System.Drawing.Size(220, 28);
            this.cb_Categoria.TabIndex = 13;
            // 
            // btn_AñadirLibro
            // 
            this.btn_AñadirLibro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AñadirLibro.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AñadirLibro.ForeColor = System.Drawing.Color.White;
            this.btn_AñadirLibro.Location = new System.Drawing.Point(888, 630);
            this.btn_AñadirLibro.Name = "btn_AñadirLibro";
            this.btn_AñadirLibro.Size = new System.Drawing.Size(220, 38);
            this.btn_AñadirLibro.TabIndex = 14;
            this.btn_AñadirLibro.Text = "Añadir Libro";
            this.btn_AñadirLibro.UseVisualStyleBackColor = false;
            this.btn_AñadirLibro.Click += new System.EventHandler(this.btn_AñadirLibro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YBOOK.Properties.Resources.fondoAddLibro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 659);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AddAutor
            // 
            this.btn_AddAutor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AddAutor.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAutor.ForeColor = System.Drawing.Color.White;
            this.btn_AddAutor.Location = new System.Drawing.Point(850, 246);
            this.btn_AddAutor.Name = "btn_AddAutor";
            this.btn_AddAutor.Size = new System.Drawing.Size(48, 28);
            this.btn_AddAutor.TabIndex = 16;
            this.btn_AddAutor.Text = "+";
            this.btn_AddAutor.UseVisualStyleBackColor = false;
            this.btn_AddAutor.Click += new System.EventHandler(this.btn_AddAutor_Click);
            // 
            // AñadirLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1137, 712);
            this.Controls.Add(this.btn_AddAutor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AñadirLibro);
            this.Controls.Add(this.cb_Categoria);
            this.Controls.Add(this.txt_Editorial);
            this.Controls.Add(this.cb_Idioma);
            this.Controls.Add(this.cb_Autor);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.Numero_Páginas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fecha_Publicacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AñadirLibro";
            this.Text = "AñadirLibro";
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Páginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_AddAutor;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fecha_Publicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Numero_Páginas;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.ComboBox cb_Autor;
        private System.Windows.Forms.ComboBox cb_Idioma;
        private System.Windows.Forms.TextBox txt_Editorial;
        private System.Windows.Forms.ComboBox cb_Categoria;
        private System.Windows.Forms.Button btn_AñadirLibro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}