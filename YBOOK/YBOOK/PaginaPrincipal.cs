using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace YBOOK
{
    public partial class PaginaPrincipal : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        
        public static string cadenaConexion = null;
        string username = null;
        int id_usuario;
        public PaginaPrincipal(List<Usuario> usuarios,string username, string cadenaConexionA, int id_usuarioA)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.username = username;
            cadenaConexion = cadenaConexionA;
            id_usuario = id_usuarioA;


            label_Username.Text = username;

            label_NombreSeccion.Text = "BIBLIOTECA";
            this.panelLoader.Controls.Clear();
            Biblioteca formBiblioteca = new Biblioteca(cadenaConexion,id_usuario)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formBiblioteca.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formBiblioteca);
            formBiblioteca.Show();
            btnLibros.Focus();
            this.id_usuario = id_usuario;
        }

        private void btn_Cerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Application.Exit();
        }



        private void btnLibros_Click(object sender, System.EventArgs e)
        {
            label_NombreSeccion.Text = "BIBLIOTECA";
            this.panelLoader.Controls.Clear();
            Biblioteca formBiblioteca = new Biblioteca(cadenaConexion,id_usuario)
            {
                Dock = DockStyle.Fill, TopLevel = false, TopMost = true
            };
            formBiblioteca.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formBiblioteca);
            formBiblioteca.Show();
        }

        private void btnLibrosUsuario_Click(object sender, EventArgs e)
        {
            label_NombreSeccion.Text = "MIS LIBROS";
            this.panelLoader.Controls.Clear();
            MisLibros formMisLibros = new MisLibros()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formMisLibros.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formMisLibros);
            formMisLibros.Show();
        }

        private void btnValoracion_Click(object sender, EventArgs e)
        {
            label_NombreSeccion.Text = "VALORACIÓN";
            this.panelLoader.Controls.Clear();
            Valoracion formValoracion = new Valoracion()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formValoracion.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formValoracion);
            formValoracion.Show();
        }

       

        private void btnAñadirLibro_Click_1(object sender, EventArgs e)
        {
            label_NombreSeccion.Text = "AÑADIR NUEVO LIBRO";
            this.panelLoader.Controls.Clear();
            AñadirLibro formNuevoLibro = new AñadirLibro()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formNuevoLibro.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formNuevoLibro);
            formNuevoLibro.Show();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            label_NombreSeccion.Text = "EDITAR PERFIL";
            this.panelLoader.Controls.Clear();
            EditarPerfil formEditarPeril = new EditarPerfil()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formEditarPeril.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formEditarPeril);
            formEditarPeril.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form_Inicial form = new Form_Inicial();
            form.Show();
            Hide();
        }
    }

    
}
