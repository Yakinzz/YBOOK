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
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_progreso = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Idioma = new System.Windows.Forms.ComboBox();
            this.txt_paginasTotales = new System.Windows.Forms.TextBox();
            this.txtPaginaActual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Acephimere", 14.25F);
            this.label7.Location = new System.Drawing.Point(702, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total de páginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Acephimere", 14.25F);
            this.label3.Location = new System.Drawing.Point(702, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Idioma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Acephimere", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(701, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Acephimere", 14.25F);
            this.label1.Location = new System.Drawing.Point(702, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Acephimere", 14.25F);
            this.label9.Location = new System.Drawing.Point(896, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Página Actual";
            // 
            // cb_Estado
            // 
            this.cb_Estado.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Estado.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Items.AddRange(new object[] { "Leído", "Leyendo", "Deseado" });
            this.cb_Estado.Location = new System.Drawing.Point(702, 576);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(121, 28);
            this.cb_Estado.TabIndex = 51;
            this.cb_Estado.SelectedIndexChanged += new System.EventHandler(this.cb_Estado_SelectedIndexChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.Snow;
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Acephimere", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(702, 320);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(411, 27);
            this.txtTitulo.TabIndex = 52;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Acephimere", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(702, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(411, 264);
            this.listBox1.TabIndex = 53;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lb_progreso
            // 
            this.lb_progreso.AutoSize = true;
            this.lb_progreso.Font = new System.Drawing.Font("Acephimere", 14.25F);
            this.lb_progreso.Location = new System.Drawing.Point(702, 634);
            this.lb_progreso.Name = "lb_progreso";
            this.lb_progreso.Size = new System.Drawing.Size(90, 24);
            this.lb_progreso.TabIndex = 54;
            this.lb_progreso.Text = "Progreso";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(702, 661);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(411, 31);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YBOOK.Properties.Resources.fondoMisLibros;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 688);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Idioma
            // 
            this.txt_Idioma.Enabled = false;
            this.txt_Idioma.Font = new System.Drawing.Font("Acephimere", 12F);
            this.txt_Idioma.FormattingEnabled = true;
            this.txt_Idioma.Items.AddRange(new object[] { "Azerí", "Afrikaans", "Albanés", "Alemán", "Alsaciano", "Amárico", "Anglosajón", "Árabe", "Aragonés", "Armenio", "Aymara", "Bajo sajón", "Bengalí", "Bielorruso", "Birmano", "Bosnio", "Bretón", "Búlgaro", "Canarés", "Catalán", "Chamorro", "Checo", "Cheroqui", "Chino mandarín", "Coreano", "Corso", "Croata", "Curdo", "Danés", "Eslovaco ", "Esloveno", "Español", "Esperanto", "Estonio", "Euskera", "Feroés", "Fiyiano", "Finlandés", "Francés", "Frisón", "Galés", "Gallego", "Georgiano", "Griego", "Guaraní", "Gujaratí", "Hebreo israelí", "Hindi", "Holandés", "Húngaro", "Ido", "Igbo", "Indonesio", "Inglés", "Interlingua", "Irlandés", "Islandés", "Italiano", "Japonés", "Javanés", "Kazako", "Laosiano", "Latín", "Letón", "Lingala", "Lituano", "Luxemburgués", "Macedonio", "Malabar", "Malayo", "Malgache", "Maltés", "Manés", "Maorí", "Marati", "Moldavo", "Mongol", "Náhuatl", "Nauruano", "Noruego", "Occitano", "Papiamento", "Persa moderno", "Polaco", "Portugués", "Punjabí", "Quechua", "Quirguiz", "Romanche", "Rumano", "Ruso", "Sardo", "Serbio", "Sesotho", "Siciliano", "Somalí", "Sueco", "Swahili", "Tagalo", "Tailandés", "Tamil", "Tártaro", "Tártaro de Crimea", "Tegulú", "Tibetano", "Turco", "Turcomano", "Ucraniano", "Urdu", "Uzbeko", "Valón", "Vietnamita", "Volapuk", "Xhosa", "Yidish", "Yoruba", "Zulú" });
            this.txt_Idioma.Location = new System.Drawing.Point(702, 407);
            this.txt_Idioma.Name = "txt_Idioma";
            this.txt_Idioma.Size = new System.Drawing.Size(239, 28);
            this.txt_Idioma.TabIndex = 57;
            // 
            // txt_paginasTotales
            // 
            this.txt_paginasTotales.BackColor = System.Drawing.Color.Snow;
            this.txt_paginasTotales.Enabled = false;
            this.txt_paginasTotales.Font = new System.Drawing.Font("Acephimere", 12F);
            this.txt_paginasTotales.Location = new System.Drawing.Point(702, 496);
            this.txt_paginasTotales.Name = "txt_paginasTotales";
            this.txt_paginasTotales.Size = new System.Drawing.Size(122, 27);
            this.txt_paginasTotales.TabIndex = 58;
            // 
            // txtPaginaActual
            // 
            this.txtPaginaActual.BackColor = System.Drawing.Color.Snow;
            this.txtPaginaActual.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginaActual.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPaginaActual.Location = new System.Drawing.Point(896, 496);
            this.txtPaginaActual.Name = "txtPaginaActual";
            this.txtPaginaActual.Size = new System.Drawing.Size(122, 27);
            this.txtPaginaActual.TabIndex = 59;
            this.txtPaginaActual.TextChanged += new System.EventHandler(this.txtPaginaActual_TextChanged);
            // 
            // MisLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1137, 712);
            this.Controls.Add(this.txtPaginaActual);
            this.Controls.Add(this.txt_paginasTotales);
            this.Controls.Add(this.txt_Idioma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lb_progreso);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.cb_Estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MisLibros";
            this.ShowInTaskbar = false;
            this.Text = "MisLibros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPaginaActual;

        private System.Windows.Forms.TextBox txt_paginasTotales;

        private System.Windows.Forms.ComboBox txt_Idioma;

        private System.Windows.Forms.PictureBox pictureBox1;

        // private System.Windows.Forms.NumericUpDown numeric_PaginaActual;

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        //private System.Windows.Forms.NumericUpDown numeric_PaginaActual;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lb_progreso;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}